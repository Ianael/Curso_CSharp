using System;
using System.Windows.Forms;
using System.IO;

namespace DirInfo {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e) {
            listBox.Items.Clear();

            DirectoryInfo info = new DirectoryInfo(@"E:\MoveTest\DirTest");

            listBox.Items.Add(info.Exists);
            listBox.Items.Add(info.Root);
            listBox.Items.Add(info.FullName);
            listBox.Items.Add(info.Parent);
            listBox.Items.Add(info.Name);
            listBox.Items.Add(info.CreationTime);
            listBox.Items.Add("----------------------------------------");

            DirectoryInfo[] dirs = info.GetDirectories();
            foreach (DirectoryInfo d in dirs) {
                listBox.Items.Add(d.FullName);
            }
            listBox.Items.Add("----------------------------------------");

            FileInfo[] files = info.GetFiles();
            foreach (FileInfo f in files) {
                listBox.Items.Add(f.FullName);
            }
        }
    }
}
