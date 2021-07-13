using System;
using System.Net;
using System.Net.Sockets;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ChatCliente {
    public partial class Form1 : Form {
        //Trata nome do usuário
        private string NomeUsuario;
        private StreamWriter stwSender;
        private StreamReader strReceptor;
        private TcpClient tcpServidor;

        //Necessário p/ atualizar formulário com msg da outra thread
        private delegate void AtualizaLogCallBack(string strMensagem);

        //Necessário p/ definir formulário p/ estado 'disconnected' de outra thread
        private delegate void FechaConexaoCallBack(string strMotivo);
        private Thread mensagemThread;
        private IPAddress enderecoIP;
        private int portaHost;
        private bool conectado;

        public Form1() {
            //Ao sair da aplicação -> desconectar
            Application.ApplicationExit += new EventHandler(OnApplicationExit);
            
            InitializeComponent();

            txtMensagem.Enabled = false;
            btnEnviar.Enabled = false;
        }

        private void btnConectar_Click(object sender, EventArgs e) {
            if (!conectado) {
                InicializaConexao();
            } else {
                FechaConexao("Desconectado a pedido do usuário.");
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e) {
            EnviaMensagem();
        }

        private void txtMensagem_KeyPress(object sender, KeyPressEventArgs e) {
            //Se pressionou ENTER
            if (e.KeyChar == (char)13) {
                EnviaMensagem();
            }
        }

        private void InicializaConexao() {
            try {
                //Trata o IP informado em um objeto IPAddress
                enderecoIP = IPAddress.Parse(txtIP.Text);
                portaHost = (int)txtPorta.Value;

                //Inicia nova conexao TCP com servidor
                tcpServidor = new TcpClient();
                tcpServidor.Connect(enderecoIP, portaHost);
                conectado = true;

                //Prepara formulário
                NomeUsuario = txtUsuario.Text;

                //Desabilita campos apropriados
                txtIP.Enabled = false;
                txtPorta.Enabled = false;
                txtUsuario.Enabled = false;
                txtMensagem.Enabled = true;
                btnEnviar.Enabled = true;
                btnConectar.ForeColor = Color.Red;
                btnConectar.Text = "Desconectar";

                //Envia nome do usuário ao servidor
                stwSender = new StreamWriter(tcpServidor.GetStream());
                stwSender.WriteLine(txtUsuario.Text);
                stwSender.Flush();

                //Inicia thread de recebimento de msgs e nova comunicação
                mensagemThread = new Thread(new ThreadStart(RecebeMensagens));
                mensagemThread.IsBackground = true;
                mensagemThread.Start();

                lblStatus.Invoke(new Action(() => {
                    lblStatus.ForeColor = Color.Green;
                    lblStatus.Text = $"Conectado ao Servidor de Chat {enderecoIP}:{portaHost}";
                }));
            } catch (Exception ex) {
                lblStatus.Invoke(new Action(() => {
                    lblStatus.ForeColor = Color.Red;
                    lblStatus.Text = "Erro na conexão com o servidor: \n" + ex.Message;                 
                }));
            }
        }

        private void RecebeMensagens() {
            strReceptor = new StreamReader(tcpServidor.GetStream());
            string conResposta = strReceptor.ReadLine();

            //Se o 1º char da resposta for 1 a conexão foi feita com sucesso
            if (conResposta[0] == '1') {
                this.Invoke(new AtualizaLogCallBack(this.AtualizaLog), new object[] {"Conectado com sucesso!"});
            } else {
                string motivo = "Não conectado: ";
                //Extrair motivo - começa no 3º char
                motivo += conResposta.Substring(2, conResposta.Length - 2);
                //Atualiza formulário com motivo da falha
                this.Invoke(new FechaConexaoCallBack(this.FechaConexao), new object[] {motivo});
                //Sai do método
                return;
            }

            //Enquanto conectado - le linhas que estão chegando
            while (conectado) {
                //Exibe no txtbox
                this.Invoke(new AtualizaLogCallBack(this.AtualizaLog), new object[] {strReceptor.ReadLine()});
            }
        }

        private void EnviaMensagem() {
            //Envia p/ servidor
            if (txtMensagem.Lines.Length >= 1) {
                stwSender.WriteLine(txtMensagem.Text);
                stwSender.Flush();
                txtMensagem.Lines = null;
            }
            txtMensagem.Text = "";
        }

        private void AtualizaLog(string strMensagem) {
            //Anexa texto ao final de cada linha
            txtLog.AppendText(strMensagem + "\r\n");
        }

        private void FechaConexao(string Motivo) {
            //Fecha conexão com o servidor
            //Mostra motivo
            txtLog.AppendText(Motivo + "\r\n");

            //Habilita e desabilita controles apropriados
            txtIP.Enabled = true;
            txtPorta.Enabled = true;
            txtUsuario.Enabled = true;
            txtMensagem.Enabled = false;
            btnEnviar.Enabled = false;
            btnConectar.ForeColor = Color.Green;
            btnConectar.Text = "Conectar";

            //Fecha objetos
            conectado = false;
            stwSender.Close();
            strReceptor.Close();
            tcpServidor.Close();

            lblStatus.Invoke(new Action(() => {
                lblStatus.ForeColor = Color.Green;
                lblStatus.Text = $"Desconectado do Servidor de Chat {enderecoIP}:{portaHost}";
            }));
        }

        //Tratador de evento p/ saída da aplicação
        public void OnApplicationExit(object sender, EventArgs e) {
            if (conectado) {
                //Fecha conexões, streams, etc...
                conectado = false;
                stwSender.Close();
                strReceptor.Close();
                tcpServidor.Close();

                lblStatus.Invoke(new Action(() => {
                    lblStatus.ForeColor = Color.Green;
                    lblStatus.Text = $"Desconectado do Servidor de Chat {enderecoIP}:{portaHost}";
                }));
            }
        }
    }
}
