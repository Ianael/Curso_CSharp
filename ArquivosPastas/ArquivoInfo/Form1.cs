using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace ArquivoInfo {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e) {
            string path = @"E:\teste.txt";
            FileInfo info = new FileInfo(path);

            listBox.Items.Clear();
            if (info.Exists) {
                listBox.Items.Add(info.Name);
                listBox.Items.Add(info.FullName);
                listBox.Items.Add(info.Extension);
                listBox.Items.Add(info.Directory);
                listBox.Items.Add(info.DirectoryName);
                listBox.Items.Add(info.Directory.FullName);
                listBox.Items.Add(info.CreationTime);
                listBox.Items.Add(info.LastAccessTime);
                listBox.Items.Add(info.LastWriteTime);
            } else {
                listBox.Items.Add("Arquivo não existe!");
            }
        }
    }
}
