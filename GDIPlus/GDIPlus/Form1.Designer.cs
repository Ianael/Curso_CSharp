
namespace GDIPlus {
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
            this.btnDesenhar = new System.Windows.Forms.Button();
            this.pict = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pict)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDesenhar
            // 
            this.btnDesenhar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesenhar.Location = new System.Drawing.Point(329, 479);
            this.btnDesenhar.Name = "btnDesenhar";
            this.btnDesenhar.Size = new System.Drawing.Size(141, 43);
            this.btnDesenhar.TabIndex = 0;
            this.btnDesenhar.Text = "Desenhar";
            this.btnDesenhar.UseVisualStyleBackColor = true;
            this.btnDesenhar.Click += new System.EventHandler(this.btnDesenhar_Click);
            // 
            // pict
            // 
            this.pict.Location = new System.Drawing.Point(13, 13);
            this.pict.Name = "pict";
            this.pict.Size = new System.Drawing.Size(775, 450);
            this.pict.TabIndex = 1;
            this.pict.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 531);
            this.Controls.Add(this.pict);
            this.Controls.Add(this.btnDesenhar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pict)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDesenhar;
        private System.Windows.Forms.PictureBox pict;
    }
}

