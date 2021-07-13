using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBar_Test {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e) {
            #region Pt.1     
            /*Task part1 = Task.Factory.StartNew(new Action(() => {
                Thread.Sleep(2000);
                progress.Invoke(new Action( ()=> progress.Value = 25));
            }));

            Task part2 = part1.ContinueWith((x) => {
                Thread.Sleep(2000);
                progress.Invoke(new Action(() => progress.Value = 50));
            });

            Task part3 = part2.ContinueWith((x) => {
                Thread.Sleep(2000);
                progress.Invoke(new Action(() => progress.Value = 75));
            });

            Task part4 = part3.ContinueWith((x) => {
                Thread.Sleep(2000);
                progress.Invoke(new Action(() => progress.Value = 100));
            });*/
            #endregion

            List<Task> tasks = new List<Task>();

            tasks.Add(new Task(new Action(() => {
                Thread.Sleep(1000);
                progress.Invoke(new Action(() => progress.PerformStep()));
            })));

            tasks.Add(new Task(new Action(() => {
                Thread.Sleep(1500);
                progress.Invoke(new Action(() => progress.PerformStep()));
            })));

            tasks.Add(new Task(new Action(() => {
                Thread.Sleep(4000);
                progress.Invoke(new Action(() => progress.PerformStep()));
            })));

            tasks.Add(new Task(new Action(() => {
                Thread.Sleep(1000);
                progress.Invoke(new Action(() => progress.PerformStep()));
            })));

            tasks.Add(new Task(new Action(() => {
                Thread.Sleep(2000);
                progress.Invoke(new Action(() => progress.PerformStep()));
            })));

            tasks.Add(new Task(new Action(() => {
                Thread.Sleep(1500);
                progress.Invoke(new Action(() => progress.PerformStep()));
            })));

            tasks.Add(new Task(new Action(() => {
                Thread.Sleep(5000);
                progress.Invoke(new Action(() => progress.PerformStep()));
            })));

            progress.Maximum = tasks.Count;
            progress.Step = 1;

            for (int i = 0; i < tasks.Count; i++) {
                tasks[i].Start();

            }
        }
    }
}
