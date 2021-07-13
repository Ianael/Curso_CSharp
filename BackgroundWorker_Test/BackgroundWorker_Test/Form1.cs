using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackgroundWorker_Test {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e) {
            if (!worker.IsBusy) {
                worker.RunWorkerAsync();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            if (worker.WorkerSupportsCancellation) {
                worker.CancelAsync();
            }
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e) {
            for (int i = 0; i < 10; i++) {
                if (worker.CancellationPending) {
                    e.Cancel = true;
                    break;
                } else {
                    Thread.Sleep(500);
                    worker.ReportProgress(i * 10);
                }
            }
        }

        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            lblPercentage.Text = e.ProgressPercentage.ToString() + "%";
            progress.Value = e.ProgressPercentage;
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            if (e.Cancelled) {
                lblPercentage.Text = "Cancelado!";
            } else if (e.Error != null) {
                lblPercentage.Text = "Erro: " + e.Error.Message;
            } else {
                lblPercentage.Text = "100% concluído!";
                progress.Value = 100;
            }
        }
    }
}
