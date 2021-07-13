using System;
using System.Text;
using System.Security.Cryptography;

namespace CriptoStringMD5 {
    class CriptoMD5 {
        public string RetornarMD5(string Senha) {
            using (MD5 md5Hash = MD5.Create()) {
                return RetornaHash(md5Hash, Senha); ;
            }
        }
        
        public bool CompararMD5(string senhaEntrada, string senhaMD5) {
            string senha = RetornarMD5(senhaEntrada);
            if (VerificarHash(senhaMD5, senha)) {
                return true;
            } else {
                return false;
            }
        }

        private string RetornaHash(MD5 md5Hash, string input) {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++) {
                sBuilder.Append(data[i].ToString("X2")); //Hexadecimal
            }

            return sBuilder.ToString();
        }

        private bool VerificarHash(string input, string hash) {
            StringComparer  comparar = StringComparer.OrdinalIgnoreCase;

            if (comparar.Compare(input, hash) == 0) { //0 - iguais
                return true;
            } else {
                return false;
            }
        }
    }
}
