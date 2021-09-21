using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace EditorTXT {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        #region Menu Arquivo                
        private void mArquivoNovo_Click(object sender, EventArgs e) {
            txtConteudo.Clear();
            mArquivoSalvar.Enabled = true;
            Text = Application.ProductName;
        }

        private void mArquivoNovaJanela_Click(object sender, EventArgs e) {
            Thread t = new Thread(() => Application.Run(new Form1()));
            t.SetApartmentState(ApartmentState.STA); //Single Thread Apartment
            t.Start();
        }

        private void mArquivoAbrir_Click(object sender, EventArgs e) {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Abrir...";
            dialog.Filter = "Rich Text File |*.rtf| Texto |*.txt| Todos |*.*";

            DialogResult result = dialog.ShowDialog();
            if (result != DialogResult.Cancel && result != DialogResult.Abort) {
                if (File.Exists(dialog.FileName)) {
                    FileInfo file = new FileInfo(dialog.FileName);
                    Text = Application.ProductName + " - " + file.Name; //Título da aplicação: Editor TXT - Arquivo aberto

                    Gerenciador.FolderPath = file.DirectoryName + "\\";
                    Gerenciador.FileName = file.Name.Remove(file.Name.LastIndexOf(".")); //Remove Extensão
                    Gerenciador.FileExension = file.Extension;

                    StreamReader sr = null;
                    try {
                        sr = new StreamReader(file.FullName, true);

                        txtConteudo.Text = sr.ReadToEnd();
                        mArquivoSalvar.Enabled = true;
                    } catch (Exception ex) {
                        MessageBox.Show("Formato de arquivo não suportado: \n" + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } finally {
                        sr.Close();
                    }
                }
            }
        }

        private void SalvarArquivo(string path) {
            StreamWriter sw = null;
            try {
                sw = new StreamWriter(path, false);

                sw.Write(txtConteudo.Text);

                FileInfo file = new FileInfo(path);
                Gerenciador.FolderPath = file.DirectoryName + "\\";
                Gerenciador.FileName = file.Name.Remove(file.Name.LastIndexOf(".")); //Remove Extensão
                Gerenciador.FileExension = file.Extension;

                Text = Application.ProductName + " - " + file.Name;
                mArquivoSalvar.Enabled = false;
            } catch (Exception ex) {
                MessageBox.Show("Erro ao salvar arquivo: \n" + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                sw.Close();
            }
        }

        private void mArquivoSalvar_Click(object sender, EventArgs e) {
            if (File.Exists(Gerenciador.FilePath)) {
                SalvarArquivo(Gerenciador.FilePath);
            } else {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Title = "Salvar...";
                dialog.Filter = "Rich Text File |*.rtf| Texto |*.txt| Todos |*.*";
                dialog.CheckFileExists = false;
                dialog.CheckPathExists = true;

                DialogResult result = dialog.ShowDialog();
                if (result != DialogResult.Cancel && DialogResult != DialogResult.Abort) {
                    SalvarArquivo(dialog.FileName);
                }
            }
        }

        private void mArquivoSalvarComo_Click(object sender, EventArgs e) {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Salvar Como...";
            dialog.Filter = "Rich Text File |*.rtf| Texto |*.txt| Todos |*.*";
            dialog.CheckFileExists = false;
            dialog.CheckPathExists = true;

            DialogResult result = dialog.ShowDialog();
            if (result != DialogResult.Cancel && DialogResult != DialogResult.Abort) {
                SalvarArquivo(dialog.FileName);
            }
        }

        private void mArquivoSair_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Deseja realmente sair?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                Application.Exit();
            }
        }
        #endregion

        private void txtConteudo_TextChanged(object sender, EventArgs e) {
            mArquivoSalvar.Enabled = true;
        }

        #region Menu Editar
        private void mEditarDesfazer_Click(object sender, EventArgs e) {
            txtConteudo.Undo();
        }

        private void mEditarRefazer_Click(object sender, EventArgs e) {
            txtConteudo.Redo();
        }

        private void mEditarRecortar_Click(object sender, EventArgs e) {
            txtConteudo.Cut();
        }

        private void mEditarCopiar_Click(object sender, EventArgs e) {
            txtConteudo.Copy();
        }

        private void mEditarColar_Click(object sender, EventArgs e) {
            txtConteudo.Paste();
        }

        private void mEditarExcluir_Click(object sender, EventArgs e) {
            txtConteudo.Text = txtConteudo.Text.Remove(txtConteudo.SelectionStart, txtConteudo.SelectedText.Length); //Do inicio até o tamanho final        
        }

        private void mEditarDataHora_Click(object sender, EventArgs e) {
            int index = txtConteudo.SelectionStart;
            string dataHora = DateTime.Now.ToString();

            if (txtConteudo.SelectionStart == txtConteudo.Text.Length) { //Se esta no final do arquivo/texto
                txtConteudo.Text = txtConteudo.Text + dataHora;
                txtConteudo.SelectionStart = index + dataHora.Length;
                return;
            }

            string temp = "";
            for (int i = 0; i < txtConteudo.Text.Length; i++) {
                if (i == txtConteudo.SelectionStart) {
                    temp += dataHora;
                    temp += txtConteudo.Text[i];
                } else {
                    temp += txtConteudo.Text[i];
                }
            }

            txtConteudo.Text = temp;
            txtConteudo.SelectionStart = index + dataHora.Length;
        }
        #endregion

        #region Menu Formatar
        private void mFormatarQuebraLinha_Click(object sender, EventArgs e) {
            txtConteudo.WordWrap = mFormatarQuebraLinha.Checked;
        }

        private void mFormatarFonte_Click(object sender, EventArgs e) {
            FontDialog fonte = new FontDialog();

            fonte.ShowColor = true;
            fonte.ShowEffects = true;
            fonte.Font = txtConteudo.Font;
            fonte.Color = txtConteudo.ForeColor;

            if (fonte.ShowDialog() == DialogResult.OK) {
                txtConteudo.Font = fonte.Font;
                txtConteudo.ForeColor = fonte.Color;
            }
        }
        #endregion

        #region Menu Exibir
        private void mExibirZoomAmpliar_Click(object sender, EventArgs e) {
            txtConteudo.ZoomFactor += 0.1f;
            AtualizarStatusBar(txtConteudo.ZoomFactor);
        }

        private void mExibirZoomReduzir_Click(object sender, EventArgs e) {
            txtConteudo.ZoomFactor -= 0.1f;
            AtualizarStatusBar(txtConteudo.ZoomFactor);
        }

        private void mExibirZoomRestaurar_Click(object sender, EventArgs e) {
            txtConteudo.ZoomFactor = 1;
            AtualizarStatusBar(txtConteudo.ZoomFactor);
        }

        private void mExibirBarraStatus_Click(object sender, EventArgs e) {
            statusBar.Visible = mExibirBarraStatus.Checked;
        }

        private void AtualizarStatusBar(float zoom) {
            lblStatusBar.Text = $"{Math.Round(zoom * 100)}%";
        }
        #endregion

        #region Menu Ajuda
        private void mAjudaExibirAjuda_Click(object sender, EventArgs e) {
            FormAjuda f = new FormAjuda();
            f.Show();
        }

        private void mAjudaSobre_Click(object sender, EventArgs e) {
            FormSobre f = new FormSobre();
            f.Show();
        }
        #endregion

    }
}
