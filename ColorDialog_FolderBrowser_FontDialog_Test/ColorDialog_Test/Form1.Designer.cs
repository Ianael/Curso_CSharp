
namespace ColorDialog_Test {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblCor = new System.Windows.Forms.Label();
            this.btnCor = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.btnDir = new System.Windows.Forms.Button();
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.btnFonte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCor
            // 
            this.lblCor.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCor.Location = new System.Drawing.Point(180, 43);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(440, 208);
            this.lblCor.TabIndex = 0;
            this.lblCor.Text = "Selecione a Cor e a Pasta";
            this.lblCor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCor
            // 
            this.btnCor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCor.Location = new System.Drawing.Point(219, 322);
            this.btnCor.Name = "btnCor";
            this.btnCor.Size = new System.Drawing.Size(164, 41);
            this.btnCor.TabIndex = 1;
            this.btnCor.Text = "Select Color";
            this.btnCor.UseVisualStyleBackColor = true;
            this.btnCor.Click += new System.EventHandler(this.btnCor_Click);
            // 
            // btnDir
            // 
            this.btnDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDir.Location = new System.Drawing.Point(426, 322);
            this.btnDir.Name = "btnDir";
            this.btnDir.Size = new System.Drawing.Size(164, 41);
            this.btnDir.TabIndex = 2;
            this.btnDir.Text = "Select Directory";
            this.btnDir.UseVisualStyleBackColor = true;
            this.btnDir.Click += new System.EventHandler(this.btnDir_Click);
            // 
            // btnFonte
            // 
            this.btnFonte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFonte.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFonte.Location = new System.Drawing.Point(318, 397);
            this.btnFonte.Name = "btnFonte";
            this.btnFonte.Size = new System.Drawing.Size(164, 41);
            this.btnFonte.TabIndex = 3;
            this.btnFonte.Text = "Select Font";
            this.btnFonte.UseVisualStyleBackColor = true;
            this.btnFonte.Click += new System.EventHandler(this.btnFonte_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFonte);
            this.Controls.Add(this.btnDir);
            this.Controls.Add(this.btnCor);
            this.Controls.Add(this.lblCor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.Button btnCor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button btnDir;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.Button btnFonte;
    }
}

