
namespace LINQ_1 {
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
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.lista = new System.Windows.Forms.ListBox();
            this.btnWhere = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnGroupBy = new System.Windows.Forms.Button();
            this.btnAgregacao = new System.Windows.Forms.Button();
            this.btnElemento = new System.Windows.Forms.Button();
            this.btnLambda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtConsulta
            // 
            this.txtConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsulta.Location = new System.Drawing.Point(600, 13);
            this.txtConsulta.Multiline = true;
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(188, 53);
            this.txtConsulta.TabIndex = 0;
            // 
            // btnExecutar
            // 
            this.btnExecutar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(9)))), ((int)(((byte)(76)))));
            this.btnExecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecutar.Location = new System.Drawing.Point(600, 72);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(188, 50);
            this.btnExecutar.TabIndex = 1;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = false;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // lista
            // 
            this.lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 29;
            this.lista.Location = new System.Drawing.Point(2, 2);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(582, 468);
            this.lista.TabIndex = 2;
            // 
            // btnWhere
            // 
            this.btnWhere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(26)))), ((int)(((byte)(88)))));
            this.btnWhere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWhere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWhere.Location = new System.Drawing.Point(600, 129);
            this.btnWhere.Name = "btnWhere";
            this.btnWhere.Size = new System.Drawing.Size(188, 50);
            this.btnWhere.TabIndex = 3;
            this.btnWhere.Text = "Where";
            this.btnWhere.UseVisualStyleBackColor = false;
            this.btnWhere.Click += new System.EventHandler(this.btnWhere_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(43)))), ((int)(((byte)(100)))));
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(600, 184);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(188, 50);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "Order By";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnGroupBy
            // 
            this.btnGroupBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(60)))), ((int)(((byte)(112)))));
            this.btnGroupBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroupBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGroupBy.Location = new System.Drawing.Point(600, 240);
            this.btnGroupBy.Name = "btnGroupBy";
            this.btnGroupBy.Size = new System.Drawing.Size(188, 50);
            this.btnGroupBy.TabIndex = 5;
            this.btnGroupBy.Text = "Group By";
            this.btnGroupBy.UseVisualStyleBackColor = false;
            this.btnGroupBy.Click += new System.EventHandler(this.btnGroupBy_Click);
            // 
            // btnAgregacao
            // 
            this.btnAgregacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(77)))), ((int)(((byte)(125)))));
            this.btnAgregacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregacao.Location = new System.Drawing.Point(600, 296);
            this.btnAgregacao.Name = "btnAgregacao";
            this.btnAgregacao.Size = new System.Drawing.Size(188, 50);
            this.btnAgregacao.TabIndex = 6;
            this.btnAgregacao.Text = "Agregação";
            this.btnAgregacao.UseVisualStyleBackColor = false;
            this.btnAgregacao.Click += new System.EventHandler(this.btnAgregacao_Click);
            // 
            // btnElemento
            // 
            this.btnElemento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.btnElemento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElemento.Location = new System.Drawing.Point(600, 352);
            this.btnElemento.Name = "btnElemento";
            this.btnElemento.Size = new System.Drawing.Size(188, 50);
            this.btnElemento.TabIndex = 7;
            this.btnElemento.Text = "Elemento";
            this.btnElemento.UseVisualStyleBackColor = false;
            this.btnElemento.Click += new System.EventHandler(this.btnElemento_Click);
            // 
            // btnLambda
            // 
            this.btnLambda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(111)))), ((int)(((byte)(149)))));
            this.btnLambda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLambda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLambda.Location = new System.Drawing.Point(600, 408);
            this.btnLambda.Name = "btnLambda";
            this.btnLambda.Size = new System.Drawing.Size(188, 50);
            this.btnLambda.TabIndex = 8;
            this.btnLambda.Text = "Lambda";
            this.btnLambda.UseVisualStyleBackColor = false;
            this.btnLambda.Click += new System.EventHandler(this.btnLambda_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(793, 472);
            this.Controls.Add(this.btnLambda);
            this.Controls.Add(this.btnElemento);
            this.Controls.Add(this.btnAgregacao);
            this.Controls.Add(this.btnGroupBy);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnWhere);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.txtConsulta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Button btnWhere;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnGroupBy;
        private System.Windows.Forms.Button btnAgregacao;
        private System.Windows.Forms.Button btnElemento;
        private System.Windows.Forms.Button btnLambda;
    }
}

