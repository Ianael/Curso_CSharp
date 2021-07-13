
namespace CriptoFile {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblTexto = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.btnEncryptFile = new System.Windows.Forms.Button();
            this.btnExportPublicKeys = new System.Windows.Forms.Button();
            this.btnImportPublicKey = new System.Windows.Forms.Button();
            this.btnDecryptFile = new System.Windows.Forms.Button();
            this.btnGetPrivateKey = new System.Windows.Forms.Button();
            this.btnCreateAsmKeys = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTexto
            // 
            this.lblTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(12, 9);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(776, 120);
            this.lblTexto.TabIndex = 0;
            this.lblTexto.Text = "Chave não definida";
            this.lblTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtKey
            // 
            this.txtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKey.Location = new System.Drawing.Point(200, 157);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(400, 35);
            this.txtKey.TabIndex = 1;
            // 
            // btnEncryptFile
            // 
            this.btnEncryptFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncryptFile.Location = new System.Drawing.Point(17, 239);
            this.btnEncryptFile.Name = "btnEncryptFile";
            this.btnEncryptFile.Size = new System.Drawing.Size(240, 85);
            this.btnEncryptFile.TabIndex = 2;
            this.btnEncryptFile.Text = "Criptografar Arquivo";
            this.btnEncryptFile.UseVisualStyleBackColor = true;
            this.btnEncryptFile.Click += new System.EventHandler(this.btnEncryptFile_Click);
            // 
            // btnExportPublicKeys
            // 
            this.btnExportPublicKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportPublicKeys.Location = new System.Drawing.Point(17, 332);
            this.btnExportPublicKeys.Name = "btnExportPublicKeys";
            this.btnExportPublicKeys.Size = new System.Drawing.Size(240, 85);
            this.btnExportPublicKeys.TabIndex = 3;
            this.btnExportPublicKeys.Text = "Exportar Chave Pública";
            this.btnExportPublicKeys.UseVisualStyleBackColor = true;
            this.btnExportPublicKeys.Click += new System.EventHandler(this.btnExportPublicKeys_Click);
            // 
            // btnImportPublicKey
            // 
            this.btnImportPublicKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportPublicKey.Location = new System.Drawing.Point(283, 332);
            this.btnImportPublicKey.Name = "btnImportPublicKey";
            this.btnImportPublicKey.Size = new System.Drawing.Size(240, 85);
            this.btnImportPublicKey.TabIndex = 5;
            this.btnImportPublicKey.Text = "Importar Chave Pública";
            this.btnImportPublicKey.UseVisualStyleBackColor = true;
            this.btnImportPublicKey.Click += new System.EventHandler(this.btnImportPublicKey_Click);
            // 
            // btnDecryptFile
            // 
            this.btnDecryptFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecryptFile.Location = new System.Drawing.Point(283, 239);
            this.btnDecryptFile.Name = "btnDecryptFile";
            this.btnDecryptFile.Size = new System.Drawing.Size(240, 85);
            this.btnDecryptFile.TabIndex = 4;
            this.btnDecryptFile.Text = "Descriptografar Arquivo";
            this.btnDecryptFile.UseVisualStyleBackColor = true;
            this.btnDecryptFile.Click += new System.EventHandler(this.btnDecryptFile_Click);
            // 
            // btnGetPrivateKey
            // 
            this.btnGetPrivateKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetPrivateKey.Location = new System.Drawing.Point(548, 332);
            this.btnGetPrivateKey.Name = "btnGetPrivateKey";
            this.btnGetPrivateKey.Size = new System.Drawing.Size(240, 85);
            this.btnGetPrivateKey.TabIndex = 7;
            this.btnGetPrivateKey.Text = "Obter Chave Privada";
            this.btnGetPrivateKey.UseVisualStyleBackColor = true;
            this.btnGetPrivateKey.Click += new System.EventHandler(this.btnGetPrivateKey_Click);
            // 
            // btnCreateAsmKeys
            // 
            this.btnCreateAsmKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAsmKeys.Location = new System.Drawing.Point(548, 239);
            this.btnCreateAsmKeys.Name = "btnCreateAsmKeys";
            this.btnCreateAsmKeys.Size = new System.Drawing.Size(240, 85);
            this.btnCreateAsmKeys.TabIndex = 6;
            this.btnCreateAsmKeys.Text = "Criar Chaves";
            this.btnCreateAsmKeys.UseVisualStyleBackColor = true;
            this.btnCreateAsmKeys.Click += new System.EventHandler(this.btnCreateAsmKeys_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGetPrivateKey);
            this.Controls.Add(this.btnCreateAsmKeys);
            this.Controls.Add(this.btnImportPublicKey);
            this.Controls.Add(this.btnDecryptFile);
            this.Controls.Add(this.btnExportPublicKeys);
            this.Controls.Add(this.btnEncryptFile);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.lblTexto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Button btnEncryptFile;
        private System.Windows.Forms.Button btnExportPublicKeys;
        private System.Windows.Forms.Button btnImportPublicKey;
        private System.Windows.Forms.Button btnDecryptFile;
        private System.Windows.Forms.Button btnGetPrivateKey;
        private System.Windows.Forms.Button btnCreateAsmKeys;
    }
}

