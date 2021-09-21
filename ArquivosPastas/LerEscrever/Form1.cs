using System;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace LerEscrever {
    public partial class Form1 : Form {
        byte[] buffer;

        public Form1() {
            InitializeComponent();
        }

        private void btnEscrever_Click(object sender, EventArgs e) {
            string path = @"E:\MoveTest\teste.txt";
            try {
                StreamWriter writer = new StreamWriter(path, true, Encoding.UTF8); //(path) -> sobrescreve

                string linha = txtConteudo.Text;
                writer.WriteLine(linha);

                writer.Flush(); //Limpa buffers
                writer.Dispose(); //Libera recursos
                writer.Close();
            } catch (Exception ex) {
                MessageBox.Show("Erro ao escrever no arquivo" + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtConteudo.Clear();
        }

        private void btnLer_Click(object sender, EventArgs e) {
            string path = @"E:\MoveTest\teste.txt";

            txtConteudo.Clear();

            try {
                StreamReader reader = new StreamReader(path, Encoding.UTF8);

                //string txt = reader.ReadToEnd();
                //txtConteudo.Text = txt;

                /*string linha = reader.ReadLine();
                while (linha != null) {
                    txtConteudo.Text += linha + "\n";
                    linha = reader.ReadLine();
                }*/

                while (!reader.EndOfStream) {
                    txtConteudo.Text += (char)reader.Read();
                }

                reader.Close();
            } catch (Exception ex) {
                MessageBox.Show("Erro ao ler arquivo: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLerBin_Click(object sender, EventArgs e) {
            string path = @"E:\MoveTest\teste.txt";
            txtConteudo.Clear();

            try {
                BinaryReader reader = new BinaryReader(File.OpenRead(path));

                while (reader.BaseStream.Position != reader.BaseStream.Length) {
                    txtConteudo.Text += reader.ReadByte();
                }

                //buffer = reader.ReadBytes((int)reader.BaseStream.Length);
                /*foreach (byte b in buffer) {
                    txtConteudo.Text += b;
                }*/
                //buffer = File.ReadAllBytes(path);
                reader.Close();
            } catch (Exception ex) {
                MessageBox.Show("Erro ao ler binário: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEscreverBin_Click(object sender, EventArgs e) {
            string path = @"E:\MoveTest\teste.txt";

            try {
                BinaryWriter writer = new BinaryWriter(File.OpenRead(path));

                writer.Write(buffer);

                writer.Flush();
                writer.Close();
            } catch (Exception ex) {
                MessageBox.Show("Erro ao escrever binário: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            txtConteudo.Clear();
        }
    }
}
