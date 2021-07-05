using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistLogin {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            Opacity = 0; //FadeIn
            Login login = new Login();

            while (Cadastro.LogedUser == null) {
                Visible = false;
                login.ShowDialog();

                if (Login.Cancelar) {
                    Application.Exit();
                    return; 
                }
            }

            lblWelcome.Text = "Bem-Vindo(a) " + Cadastro.LogedUser.Nome + "!";

            Visible = true;

            timerFade.Tick += new EventHandler(fadeIn);  //this calls the fade out function
            timerFade.Start();
        }

        void fadeIn(object sender, EventArgs e) {
            if (Opacity >= 1)
                timerFade.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.02;
        }

        void fadeOut(object sender, EventArgs e) {
            if (Opacity <= 0)     //check if opacity is 0

                timerFade.Stop();    //if it is, we stop the timer
            else
                Opacity -= 0.02;
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e) {
            if (this.WindowState == FormWindowState.Maximized) {
                this.WindowState = FormWindowState.Normal;
            } else {
                this.WindowState = FormWindowState.Maximized;
            }
        }
    }
}
