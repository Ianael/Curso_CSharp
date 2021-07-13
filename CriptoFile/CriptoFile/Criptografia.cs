using System;
using System.IO;
using System.Security.Cryptography;

namespace CriptoFile {
    class Criptografia {
        //Declaração de CspParameters e RSACryptoServiceProvider
        //Objetos com escopo global na classe
        public static CspParameters cspp;
        public static RSACryptoServiceProvider rsa;

        //Caminhos, vars p/ fonte, pasta de criptografia e pasta de descriptografia
        private static string _encrFolder;
        public static string EncrFolder {
            get { return _encrFolder; }
            set {
                _encrFolder = value;
                PubKeyFile = _encrFolder + "rsaPublicKey.txt";
            }
        }

        public static string DecrFolder { get; set; }
        public static string SrcFolder { get; set; }

        //Arquivo de chave pública
        private static string PubKeyFile = EncrFolder + "rsaPublicKey.txt";

        //Chave contendo nome p/ private/public key value pair
        public static string keyName;

        //Método p/ criar chave pública
        public static string CreateAsmKeys() {
            string result = "";

            //Armazena key pair no key container
            if (string.IsNullOrEmpty(keyName)) {
                result = "Chave pública não definida";
                return result;
            }

            cspp.KeyContainerName = keyName;
            rsa = new RSACryptoServiceProvider(cspp);
            rsa.PersistKeyInCsp = true;

            if (rsa.PublicOnly) {
                result = "Key: " + cspp.KeyContainerName + " - Somente Pública";
            } else {
                result = "Key: " + cspp.KeyContainerName + " - Key Pair Completa";
            }

            return result;
        }

        //Método p/ exportar a chave pública em um arquivo
        public static bool ExportPublicKey() {
            bool result = true;

            if (rsa == null) {
                return false;
            }

            if (!Directory.Exists(EncrFolder)) {
                Directory.CreateDirectory(EncrFolder);
            }

            StreamWriter sw = new StreamWriter(PubKeyFile, false);
            try {
                sw.Write(rsa.ToXmlString(false));
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                result = false;
            } finally {
                sw.Close();
            }

            return result;
        }

        //Método p/ importar chave pública
        public static string ImportPublicKey() {
            string result = "";

            if (!File.Exists(PubKeyFile)) {
                result = "Arquivo de chave pública não encontrado.";
                return result;
            }

            if (string.IsNullOrEmpty(keyName)) {
                result = "Chave pública não definida.";
                return result;
            }

            StreamReader sr = new StreamReader(PubKeyFile);

            try {
                cspp.KeyContainerName = keyName;
                rsa = new RSACryptoServiceProvider(cspp);

                string keytxt = sr.ReadToEnd();
                rsa.FromXmlString(keytxt);
                rsa.PersistKeyInCsp = true;

                if (rsa.PublicOnly) {
                    result = "Key: " + cspp.KeyContainerName + " - Somente Pública";
                } else {
                    result = "Key: " + cspp.KeyContainerName + " - Key Pair Completa";
                }

            } catch (Exception ex) {
                result = ex.Message;
                Console.WriteLine(ex.Message);
            } finally {
                sr.Close();
            }

            return result;
        }

        //Método p/ criar uma chave privada a partir de um valor definido
        public static string GetPrivateKey() {
            string result = "";

            if (string.IsNullOrEmpty(keyName)) {
                result = "Chave privada não definida.";
                return result;
            }

            cspp.KeyContainerName = keyName;
            rsa = new RSACryptoServiceProvider(cspp);
            rsa.PersistKeyInCsp = true;

            if (rsa.PublicOnly) {
                result = "Key: " + cspp.KeyContainerName + " - Somente Pública";
            } else {
                result = "Key: " + cspp.KeyContainerName + " - Key Pair Completa";
            }

            return result;
        }

        //Método p/ criptografar um arquivo
        public static string EncryptFile(string inFile) {
            //Criar instância de Aes p/ criptografia simétrica de dados.
            Aes aes = Aes.Create();
            ICryptoTransform transform = aes.CreateEncryptor();

            //Usa RSACryptoServiceProvider p/ ciptografar a chave AES, rsa é instanciado anteriormente.

            byte[] keyEncrypted = rsa.Encrypt(aes.Key, false);

            //Cria matrizes de byte p/ conter valores de comprimento da chave e IV
            byte[] LenK = new byte[4];
            byte[] LenIV = new byte[4];

            int lKey = keyEncrypted.Length;
            LenK = BitConverter.GetBytes(lKey);
            int lIV = aes.IV.Length;
            LenIV = BitConverter.GetBytes(lIV);

            //Escreve no FileStream p/ arquivo criptografado (outFs):
            //  - comprimento da chave, - comprimento do IV, - chave criptografada
            //  - o IV, - o conteúdo da cifra criptografada

            int startFileName = inFile.LastIndexOf("\\") + 1;
            string outFile = EncrFolder + inFile.Substring(startFileName) + ".enc";

            try {
                using (FileStream outFs = new FileStream(outFile, FileMode.Create)) {
                    outFs.Write(LenK, 0, 4);
                    outFs.Write(LenIV, 0, 4);
                    outFs.Write(keyEncrypted, 0, lKey);
                    outFs.Write(aes.IV, 0, lIV);

                    //Escreve o texto cifrado usando CryptoStream p/ criptografar
                    using (CryptoStream outStreamEncrypted = new CryptoStream(outFs, transform, CryptoStreamMode.Write)) {
                        //Criptografar um pouco por vez, economiza memória
                        int count = 0;
                        int offset = 0; //deslocamento

                        //blockSizeBytes é arbitrário - tamanho da divisão de blocos a serem criptografados
                        int blockSizeBytes = aes.BlockSize / 8;
                        byte[] data = new byte[blockSizeBytes];
                        int bytesRead = 0;

                        using (FileStream inFs = new FileStream(inFile, FileMode.Open)) {
                            do {
                                count = inFs.Read(data, 0, blockSizeBytes);
                                offset += count;
                                outStreamEncrypted.Write(data, 0, count);
                                bytesRead += blockSizeBytes;
                            } while (count > 0);
                            inFs.Close();
                        }

                        outStreamEncrypted.FlushFinalBlock();
                        outStreamEncrypted.Close();
                    }

                    outFs.Close();
                    File.Delete(inFile);
                }
            } catch (Exception ex) {
                return ex.Message;
            }

            return $"Arquivo criptografado.\n Origem: {inFile}\n Destino:{outFile}";
        }

        //Método p/ descriptografar um arquivo
        public static string DecryptFile(string inFile) {
            //Cria instância AES p/ descriptografia semétrica dos dados.
            Aes aes = Aes.Create();

            //Cria matrizes de byte p/ obter valores de comprimento da chave e IV
            //São armazenados como 4 bytes no pacote de criptografia
            byte[] LenK = new byte[4];
            byte[] LenIV = new byte[4];

            //Constroe nome do arquivo p/ arquivo descriptografado
            string outFile = DecrFolder + inFile.Substring(0, inFile.LastIndexOf("."));

            try {
                //Objeto Filestream le o criptografado (inFs) e salva descriptografado (outFs)
                using (FileStream inFs = new FileStream(EncrFolder + inFile, FileMode.Open)) {
                    inFs.Seek(0, SeekOrigin.Begin);
                    inFs.Seek(0, SeekOrigin.Begin);
                    inFs.Read(LenK, 0, 3);
                    inFs.Seek(4, SeekOrigin.Begin);
                    inFs.Read(LenIV, 0, 3);

                    //Converte comprimentos em valores INT
                    int lenK = BitConverter.ToInt32(LenK, 0);
                    int lenIV = BitConverter.ToInt32(LenIV, 0);

                    //Determina posição inicial do texto cifrado(startC) e seu comprimento (lenS)
                    int startC = lenIV + lenK + 8;
                    int lenC = (int)inFs.Length - startC;

                    //Cria matriz de bytes p/ chave Aes criptografada, IV e texto cifrado
                    byte[] KeyEncrypted = new byte[lenK];
                    byte[] IV = new byte[lenIV];

                    //Extrai chave e IV, começando do índice 8 após comprimento
                    inFs.Seek(8, SeekOrigin.Begin);
                    inFs.Read(KeyEncrypted, 0, lenK);
                    inFs.Seek(8 + lenK, SeekOrigin.Begin);
                    inFs.Read(IV, 0, lenIV);

                    if (!Directory.Exists(DecrFolder)) {
                        Directory.CreateDirectory(DecrFolder);
                    }

                    //RSACryptoServiceProvider p/ descriptografar chave AES
                    byte[] KeyDecrypted = rsa.Decrypt(KeyEncrypted, false);

                    //Descriptografa a chave
                    ICryptoTransform transform = aes.CreateDecryptor(KeyDecrypted, IV);

                    //Descriptografa text cifrado do FileStream do arquivo (inFs) criptografado
                    //no FileStream p/ arquivo descriptografado (outFs)
                    using (FileStream outFs = new FileStream(outFile, FileMode.Create)) {
                        //Descriptografar um pouco por vez, economiza memória
                        int count = 0;
                        int offset = 0; //deslocamento

                        //blockSizeBytes é arbitrário - tamanho da divisão de blocos a serem criptografados
                        int blockSizeBytes = aes.BlockSize / 8;
                        byte[] data = new byte[blockSizeBytes];
                        int bytesRead = 0;

                        inFs.Seek(startC, SeekOrigin.Begin);
                        using (CryptoStream outStreamDecrypted = new CryptoStream(outFs, transform, CryptoStreamMode.Write)) {
                            do {
                                count = inFs.Read(data, 0, blockSizeBytes);
                                offset += count;
                                outStreamDecrypted.Write(data, 0, count);
                            } while (count > 0);

                            outStreamDecrypted.FlushFinalBlock();
                            outStreamDecrypted.Close();
                        }

                        outFs.Close();
                    }

                    inFs.Close();
                    File.Delete(inFile);
                }

            } catch (Exception ex) {
                return ex.Message;
            }

            return $"Arquivo descriptografado.\n Origem: {inFile}\n Destino:{outFile}";

        }
    }
}
