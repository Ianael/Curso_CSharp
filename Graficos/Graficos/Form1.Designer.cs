
namespace Graficos {
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.btnInserirValores = new System.Windows.Forms.Button();
            this.btnInserirAleatorio = new System.Windows.Forms.Button();
            this.chkGrafico3D = new System.Windows.Forms.CheckBox();
            this.cmbTipoGrafico = new System.Windows.Forms.ComboBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dataValores = new System.Windows.Forms.DataGridView();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbPalletCor = new System.Windows.Forms.ComboBox();
            this.grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataValores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(118, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(76, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gráfico";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(39, 55);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(93, 20);
            this.lblX.TabIndex = 1;
            this.lblX.Text = "Valor de X";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY.Location = new System.Drawing.Point(185, 55);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(93, 20);
            this.lblY.TabIndex = 2;
            this.lblY.Text = "Valor de Y";
            // 
            // txtX
            // 
            this.txtX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX.Location = new System.Drawing.Point(12, 87);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(141, 26);
            this.txtX.TabIndex = 3;
            this.txtX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtX_KeyPress);
            // 
            // txtY
            // 
            this.txtY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtY.Location = new System.Drawing.Point(161, 87);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(141, 26);
            this.txtY.TabIndex = 4;
            this.txtY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtY_KeyPress);
            // 
            // btnInserirValores
            // 
            this.btnInserirValores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirValores.Location = new System.Drawing.Point(12, 120);
            this.btnInserirValores.Name = "btnInserirValores";
            this.btnInserirValores.Size = new System.Drawing.Size(291, 40);
            this.btnInserirValores.TabIndex = 5;
            this.btnInserirValores.Text = "Inserir Valores no Gráfico";
            this.btnInserirValores.UseVisualStyleBackColor = true;
            this.btnInserirValores.Click += new System.EventHandler(this.btnInserirValores_Click);
            // 
            // btnInserirAleatorio
            // 
            this.btnInserirAleatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirAleatorio.Location = new System.Drawing.Point(702, 410);
            this.btnInserirAleatorio.Name = "btnInserirAleatorio";
            this.btnInserirAleatorio.Size = new System.Drawing.Size(148, 42);
            this.btnInserirAleatorio.TabIndex = 6;
            this.btnInserirAleatorio.Text = "Inserir Valores Aleatórios";
            this.btnInserirAleatorio.UseVisualStyleBackColor = true;
            this.btnInserirAleatorio.Click += new System.EventHandler(this.btnInserirAleatorio_Click);
            // 
            // chkGrafico3D
            // 
            this.chkGrafico3D.AutoSize = true;
            this.chkGrafico3D.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGrafico3D.Location = new System.Drawing.Point(603, 427);
            this.chkGrafico3D.Name = "chkGrafico3D";
            this.chkGrafico3D.Size = new System.Drawing.Size(90, 20);
            this.chkGrafico3D.TabIndex = 7;
            this.chkGrafico3D.Text = "Gráfico 3D";
            this.chkGrafico3D.UseVisualStyleBackColor = true;
            this.chkGrafico3D.CheckedChanged += new System.EventHandler(this.chkGrafico3D_CheckedChanged);
            // 
            // cmbTipoGrafico
            // 
            this.cmbTipoGrafico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoGrafico.FormattingEnabled = true;
            this.cmbTipoGrafico.Location = new System.Drawing.Point(12, 425);
            this.cmbTipoGrafico.Name = "cmbTipoGrafico";
            this.cmbTipoGrafico.Size = new System.Drawing.Size(291, 24);
            this.cmbTipoGrafico.TabIndex = 8;
            this.cmbTipoGrafico.SelectedIndexChanged += new System.EventHandler(this.cmbTipoGrafico_SelectedIndexChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(12, 370);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(291, 40);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar Gráfico";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // dataValores
            // 
            this.dataValores.AllowUserToAddRows = false;
            this.dataValores.AllowUserToDeleteRows = false;
            this.dataValores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataValores.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataValores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataValores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.x,
            this.y});
            this.dataValores.Location = new System.Drawing.Point(12, 167);
            this.dataValores.MultiSelect = false;
            this.dataValores.Name = "dataValores";
            this.dataValores.ReadOnly = true;
            this.dataValores.RowHeadersVisible = false;
            this.dataValores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataValores.Size = new System.Drawing.Size(291, 197);
            this.dataValores.TabIndex = 10;
            this.dataValores.SelectionChanged += new System.EventHandler(this.dataValores_SelectionChanged);
            // 
            // x
            // 
            this.x.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.x.HeaderText = "Eixo X";
            this.x.Name = "x";
            this.x.ReadOnly = true;
            // 
            // y
            // 
            this.y.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.y.HeaderText = "Eixo Y";
            this.y.Name = "y";
            this.y.ReadOnly = true;
            // 
            // cmbPalletCor
            // 
            this.cmbPalletCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPalletCor.FormattingEnabled = true;
            this.cmbPalletCor.Location = new System.Drawing.Point(306, 425);
            this.cmbPalletCor.Name = "cmbPalletCor";
            this.cmbPalletCor.Size = new System.Drawing.Size(291, 24);
            this.cmbPalletCor.TabIndex = 11;
            this.cmbPalletCor.SelectedIndexChanged += new System.EventHandler(this.cmbPalletCor_SelectedIndexChanged);
            // 
            // grafico
            // 
            chartArea7.Name = "ChartArea1";
            this.grafico.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.grafico.Legends.Add(legend7);
            this.grafico.Location = new System.Drawing.Point(309, -1);
            this.grafico.Name = "grafico";
            this.grafico.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series7.BorderWidth = 5;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Legend = "Legend1";
            series7.Name = "X vs Y";
            series7.YValuesPerPoint = 6;
            this.grafico.Series.Add(series7);
            this.grafico.Size = new System.Drawing.Size(550, 405);
            this.grafico.TabIndex = 12;
            this.grafico.Text = "grafico";
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 461);
            this.Controls.Add(this.grafico);
            this.Controls.Add(this.cmbPalletCor);
            this.Controls.Add(this.dataValores);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.cmbTipoGrafico);
            this.Controls.Add(this.chkGrafico3D);
            this.Controls.Add(this.btnInserirAleatorio);
            this.Controls.Add(this.btnInserirValores);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataValores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Button btnInserirValores;
        private System.Windows.Forms.Button btnInserirAleatorio;
        private System.Windows.Forms.CheckBox chkGrafico3D;
        private System.Windows.Forms.ComboBox cmbTipoGrafico;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridView dataValores;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn y;
        private System.Windows.Forms.ComboBox cmbPalletCor;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico;
        private System.Windows.Forms.Timer timer;
    }
}

