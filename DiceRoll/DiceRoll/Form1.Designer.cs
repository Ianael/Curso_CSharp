
namespace DiceRoll {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictDice = new System.Windows.Forms.PictureBox();
            this.btnD4 = new System.Windows.Forms.Button();
            this.btnD8 = new System.Windows.Forms.Button();
            this.btnD6 = new System.Windows.Forms.Button();
            this.btnD10 = new System.Windows.Forms.Button();
            this.btnD12 = new System.Windows.Forms.Button();
            this.btnD20 = new System.Windows.Forms.Button();
            this.lblRoll = new System.Windows.Forms.Label();
            this.lblCrit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictDice)).BeginInit();
            this.SuspendLayout();
            // 
            // pictDice
            // 
            this.pictDice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictDice.BackColor = System.Drawing.SystemColors.Window;
            this.pictDice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictDice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictDice.Location = new System.Drawing.Point(324, 81);
            this.pictDice.Name = "pictDice";
            this.pictDice.Size = new System.Drawing.Size(200, 200);
            this.pictDice.TabIndex = 0;
            this.pictDice.TabStop = false;
            // 
            // btnD4
            // 
            this.btnD4.BackColor = System.Drawing.Color.DarkRed;
            this.btnD4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnD4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnD4.Location = new System.Drawing.Point(140, 408);
            this.btnD4.Name = "btnD4";
            this.btnD4.Size = new System.Drawing.Size(79, 39);
            this.btnD4.TabIndex = 1;
            this.btnD4.Text = "d4";
            this.btnD4.UseVisualStyleBackColor = false;
            this.btnD4.Click += new System.EventHandler(this.btnD4_Click);
            // 
            // btnD8
            // 
            this.btnD8.BackColor = System.Drawing.Color.DarkRed;
            this.btnD8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnD8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnD8.Location = new System.Drawing.Point(336, 408);
            this.btnD8.Name = "btnD8";
            this.btnD8.Size = new System.Drawing.Size(79, 39);
            this.btnD8.TabIndex = 2;
            this.btnD8.Text = "d8";
            this.btnD8.UseVisualStyleBackColor = false;
            this.btnD8.Click += new System.EventHandler(this.btnD8_Click);
            // 
            // btnD6
            // 
            this.btnD6.BackColor = System.Drawing.Color.DarkRed;
            this.btnD6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnD6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnD6.Location = new System.Drawing.Point(238, 408);
            this.btnD6.Name = "btnD6";
            this.btnD6.Size = new System.Drawing.Size(79, 39);
            this.btnD6.TabIndex = 3;
            this.btnD6.Text = "d6";
            this.btnD6.UseVisualStyleBackColor = false;
            this.btnD6.Click += new System.EventHandler(this.btnD6_Click);
            // 
            // btnD10
            // 
            this.btnD10.BackColor = System.Drawing.Color.DarkRed;
            this.btnD10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnD10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnD10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnD10.Location = new System.Drawing.Point(434, 408);
            this.btnD10.Name = "btnD10";
            this.btnD10.Size = new System.Drawing.Size(79, 39);
            this.btnD10.TabIndex = 4;
            this.btnD10.Text = "d10";
            this.btnD10.UseVisualStyleBackColor = false;
            this.btnD10.Click += new System.EventHandler(this.btnD10_Click);
            // 
            // btnD12
            // 
            this.btnD12.BackColor = System.Drawing.Color.DarkRed;
            this.btnD12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnD12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnD12.Location = new System.Drawing.Point(532, 408);
            this.btnD12.Name = "btnD12";
            this.btnD12.Size = new System.Drawing.Size(79, 39);
            this.btnD12.TabIndex = 5;
            this.btnD12.Text = "d12";
            this.btnD12.UseVisualStyleBackColor = false;
            this.btnD12.Click += new System.EventHandler(this.btnD12_Click);
            // 
            // btnD20
            // 
            this.btnD20.BackColor = System.Drawing.Color.DarkRed;
            this.btnD20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnD20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnD20.Location = new System.Drawing.Point(630, 408);
            this.btnD20.Name = "btnD20";
            this.btnD20.Size = new System.Drawing.Size(79, 39);
            this.btnD20.TabIndex = 6;
            this.btnD20.Text = "d20";
            this.btnD20.UseVisualStyleBackColor = false;
            this.btnD20.Click += new System.EventHandler(this.btnD20_Click);
            // 
            // lblRoll
            // 
            this.lblRoll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRoll.BackColor = System.Drawing.Color.White;
            this.lblRoll.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRoll.Location = new System.Drawing.Point(336, 165);
            this.lblRoll.Name = "lblRoll";
            this.lblRoll.Size = new System.Drawing.Size(177, 37);
            this.lblRoll.TabIndex = 7;
            this.lblRoll.Text = "0";
            this.lblRoll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCrit
            // 
            this.lblCrit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCrit.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCrit.Location = new System.Drawing.Point(299, 309);
            this.lblCrit.Name = "lblCrit";
            this.lblCrit.Size = new System.Drawing.Size(250, 32);
            this.lblCrit.TabIndex = 8;
            this.lblCrit.Text = "Crítico";
            this.lblCrit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(849, 539);
            this.Controls.Add(this.lblCrit);
            this.Controls.Add(this.lblRoll);
            this.Controls.Add(this.btnD20);
            this.Controls.Add(this.btnD12);
            this.Controls.Add(this.btnD10);
            this.Controls.Add(this.btnD6);
            this.Controls.Add(this.btnD8);
            this.Controls.Add(this.btnD4);
            this.Controls.Add(this.pictDice);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DiceRoll";
            ((System.ComponentModel.ISupportInitialize)(this.pictDice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictDice;
        private System.Windows.Forms.Button btnD4;
        private System.Windows.Forms.Button btnD8;
        private System.Windows.Forms.Button btnD6;
        private System.Windows.Forms.Button btnD10;
        private System.Windows.Forms.Button btnD12;
        private System.Windows.Forms.Button btnD20;
        private System.Windows.Forms.Label lblRoll;
        private System.Windows.Forms.Label lblCrit;
    }
}

