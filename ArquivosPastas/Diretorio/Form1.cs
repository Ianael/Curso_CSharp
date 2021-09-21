using System;
using System.Windows.Forms;
using System.IO;

namespace Diretorio {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e) {
            listBox.Items.Clear();

            string path = @"E:\MoveTest\";

            if (Directory.Exists(path + "DirTest")) {
                //Directory.Delete(path + "DirTest");
            } else {
                Directory.CreateDirectory(path + "DirTest");
            }

            /*string[] dirs = Directory.GetDirectories(path);
            foreach (string d in dirs) {
                listBox.Items.Add(d);
            }*/

            /*string[] files = Directory.GetFiles(path);
            foreach (string f in files) {
                listBox.Items.Add(f);
            }*/

            string raiz = Directory.GetDirectoryRoot(path);
            string[] drives = Directory.GetLogicalDrives();

            listBox.Items.AddRange(drives);
        }
    }
}
