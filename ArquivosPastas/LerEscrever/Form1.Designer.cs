
namespace LerEscrever {
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
            this.btnEscrever = new System.Windows.Forms.Button();
            this.btnLer = new System.Windows.Forms.Button();
            this.txtConteudo = new System.Windows.Forms.RichTextBox();
            this.btnLerBin = new System.Windows.Forms.Button();
            this.btnEscreverBin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEscrever
            // 
            this.btnEscrever.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEscrever.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscrever.Location = new System.Drawing.Point(202, 375);
            this.btnEscrever.Name = "btnEscrever";
            this.btnEscrever.Size = new System.Drawing.Size(184, 63);
            this.btnEscrever.TabIndex = 8;
            this.btnEscrever.Text = "Escrever";
            this.btnEscrever.UseVisualStyleBackColor = true;
            this.btnEscrever.Click += new System.EventHandler(this.btnEscrever_Click);
            // 
            // btnLer
            // 
            this.btnLer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLer.Location = new System.Drawing.Point(12, 375);
            this.btnLer.Name = "btnLer";
            this.btnLer.Size = new System.Drawing.Size(184, 63);
            this.btnLer.TabIndex = 11;
            this.btnLer.Text = "Ler";
            this.btnLer.UseVisualStyleBackColor = true;
            this.btnLer.Click += new System.EventHandler(this.btnLer_Click);
            // 
            // txtConteudo
            // 
            this.txtConteudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConteudo.Location = new System.Drawing.Point(12, 12);
            this.txtConteudo.Name = "txtConteudo";
            this.txtConteudo.Size = new System.Drawing.Size(776, 348);
            this.txtConteudo.TabIndex = 12;
            this.txtConteudo.Text = "";
            // 
            // btnLerBin
            // 
            this.btnLerBin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLerBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLerBin.Location = new System.Drawing.Point(414, 375);
            this.btnLerBin.Name = "btnLerBin";
            this.btnLerBin.Size = new System.Drawing.Size(184, 63);
            this.btnLerBin.TabIndex = 13;
            this.btnLerBin.Text = "Ler Binário";
            this.btnLerBin.UseVisualStyleBackColor = true;
            this.btnLerBin.Click += new System.EventHandler(this.btnLerBin_Click);
            // 
            // btnEscreverBin
            // 
            this.btnEscreverBin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEscreverBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscreverBin.Location = new System.Drawing.Point(604, 375);
            this.btnEscreverBin.Name = "btnEscreverBin";
            this.btnEscreverBin.Size = new System.Drawing.Size(184, 63);
            this.btnEscreverBin.TabIndex = 14;
            this.btnEscreverBin.Text = "Escrever Binário";
            this.btnEscreverBin.UseVisualStyleBackColor = true;
            this.btnEscreverBin.Click += new System.EventHandler(this.btnEscreverBin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEscreverBin);
            this.Controls.Add(this.btnLerBin);
            this.Controls.Add(this.txtConteudo);
            this.Controls.Add(this.btnLer);
            this.Controls.Add(this.btnEscrever);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEscrever;
        private System.Windows.Forms.Button btnLer;
        private System.Windows.Forms.RichTextBox txtConteudo;
        private System.Windows.Forms.Button btnLerBin;
        private System.Windows.Forms.Button btnEscreverBin;
    }
}

