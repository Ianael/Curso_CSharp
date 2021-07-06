
namespace Colecoes {
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
            this.components = new System.ComponentModel.Container();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.btnSortedSet = new System.Windows.Forms.Button();
            this.btnSortedDictionary = new System.Windows.Forms.Button();
            this.btnSortedList = new System.Windows.Forms.Button();
            this.btnStack = new System.Windows.Forms.Button();
            this.btnQueue = new System.Windows.Forms.Button();
            this.btnDictionary = new System.Windows.Forms.Button();
            this.btnHashSet = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLista = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.pnChoice = new System.Windows.Forms.Panel();
            this.timerFade = new System.Windows.Forms.Timer(this.components);
            this.pnMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.pnMenu.Controls.Add(this.btnSortedSet);
            this.pnMenu.Controls.Add(this.btnSortedDictionary);
            this.pnMenu.Controls.Add(this.btnSortedList);
            this.pnMenu.Controls.Add(this.btnStack);
            this.pnMenu.Controls.Add(this.btnQueue);
            this.pnMenu.Controls.Add(this.btnDictionary);
            this.pnMenu.Controls.Add(this.btnHashSet);
            this.pnMenu.Controls.Add(this.btnClose);
            this.pnMenu.Controls.Add(this.btnLista);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(144, 450);
            this.pnMenu.TabIndex = 0;
            // 
            // btnSortedSet
            // 
            this.btnSortedSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(140)))), ((int)(((byte)(6)))));
            this.btnSortedSet.BackgroundImage = global::Colecoes.Properties.Resources.outline_play_arrow_black_24dp;
            this.btnSortedSet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSortedSet.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSortedSet.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSortedSet.FlatAppearance.BorderSize = 0;
            this.btnSortedSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortedSet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSortedSet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSortedSet.Location = new System.Drawing.Point(0, 350);
            this.btnSortedSet.Name = "btnSortedSet";
            this.btnSortedSet.Size = new System.Drawing.Size(144, 50);
            this.btnSortedSet.TabIndex = 9;
            this.btnSortedSet.Text = "SortedSet";
            this.btnSortedSet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSortedSet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSortedSet.UseVisualStyleBackColor = false;
            this.btnSortedSet.Click += new System.EventHandler(this.btnSortedSet_Click);
            // 
            // btnSortedDictionary
            // 
            this.btnSortedDictionary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(47)))), ((int)(((byte)(2)))));
            this.btnSortedDictionary.BackgroundImage = global::Colecoes.Properties.Resources.outline_play_arrow_black_24dp;
            this.btnSortedDictionary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSortedDictionary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSortedDictionary.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSortedDictionary.FlatAppearance.BorderSize = 0;
            this.btnSortedDictionary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortedDictionary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSortedDictionary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSortedDictionary.Location = new System.Drawing.Point(0, 300);
            this.btnSortedDictionary.Name = "btnSortedDictionary";
            this.btnSortedDictionary.Size = new System.Drawing.Size(144, 50);
            this.btnSortedDictionary.TabIndex = 8;
            this.btnSortedDictionary.Text = "SortedDictionary";
            this.btnSortedDictionary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSortedDictionary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSortedDictionary.UseVisualStyleBackColor = false;
            this.btnSortedDictionary.Click += new System.EventHandler(this.btnSortedDictionary_Click);
            // 
            // btnSortedList
            // 
            this.btnSortedList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(83)))), ((int)(((byte)(98)))));
            this.btnSortedList.BackgroundImage = global::Colecoes.Properties.Resources.outline_play_arrow_black_24dp;
            this.btnSortedList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSortedList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSortedList.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSortedList.FlatAppearance.BorderSize = 0;
            this.btnSortedList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortedList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSortedList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSortedList.Location = new System.Drawing.Point(0, 250);
            this.btnSortedList.Name = "btnSortedList";
            this.btnSortedList.Size = new System.Drawing.Size(144, 50);
            this.btnSortedList.TabIndex = 7;
            this.btnSortedList.Text = "SortedList";
            this.btnSortedList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSortedList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSortedList.UseVisualStyleBackColor = false;
            this.btnSortedList.Click += new System.EventHandler(this.btnSortedList_Click);
            // 
            // btnStack
            // 
            this.btnStack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(157)))), ((int)(((byte)(143)))));
            this.btnStack.BackgroundImage = global::Colecoes.Properties.Resources.outline_play_arrow_black_24dp;
            this.btnStack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStack.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStack.FlatAppearance.BorderSize = 0;
            this.btnStack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStack.Location = new System.Drawing.Point(0, 200);
            this.btnStack.Name = "btnStack";
            this.btnStack.Size = new System.Drawing.Size(144, 50);
            this.btnStack.TabIndex = 6;
            this.btnStack.Text = "Stack";
            this.btnStack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStack.UseVisualStyleBackColor = false;
            this.btnStack.Click += new System.EventHandler(this.btnStack_Click);
            // 
            // btnQueue
            // 
            this.btnQueue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(196)))), ((int)(((byte)(106)))));
            this.btnQueue.BackgroundImage = global::Colecoes.Properties.Resources.outline_play_arrow_black_24dp;
            this.btnQueue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnQueue.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQueue.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnQueue.FlatAppearance.BorderSize = 0;
            this.btnQueue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQueue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQueue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQueue.Location = new System.Drawing.Point(0, 150);
            this.btnQueue.Name = "btnQueue";
            this.btnQueue.Size = new System.Drawing.Size(144, 50);
            this.btnQueue.TabIndex = 5;
            this.btnQueue.Text = "Queue";
            this.btnQueue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQueue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQueue.UseVisualStyleBackColor = false;
            this.btnQueue.Click += new System.EventHandler(this.btnQueue_Click);
            // 
            // btnDictionary
            // 
            this.btnDictionary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(162)))), ((int)(((byte)(97)))));
            this.btnDictionary.BackgroundImage = global::Colecoes.Properties.Resources.outline_play_arrow_black_24dp;
            this.btnDictionary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDictionary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDictionary.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDictionary.FlatAppearance.BorderSize = 0;
            this.btnDictionary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDictionary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDictionary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDictionary.Location = new System.Drawing.Point(0, 100);
            this.btnDictionary.Name = "btnDictionary";
            this.btnDictionary.Size = new System.Drawing.Size(144, 50);
            this.btnDictionary.TabIndex = 4;
            this.btnDictionary.Text = "Dictionary";
            this.btnDictionary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDictionary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDictionary.UseVisualStyleBackColor = false;
            this.btnDictionary.Click += new System.EventHandler(this.btnDictionary_Click);
            // 
            // btnHashSet
            // 
            this.btnHashSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(111)))), ((int)(((byte)(81)))));
            this.btnHashSet.BackgroundImage = global::Colecoes.Properties.Resources.outline_play_arrow_black_24dp;
            this.btnHashSet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHashSet.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHashSet.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHashSet.FlatAppearance.BorderSize = 0;
            this.btnHashSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHashSet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHashSet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHashSet.Location = new System.Drawing.Point(0, 50);
            this.btnHashSet.Name = "btnHashSet";
            this.btnHashSet.Size = new System.Drawing.Size(144, 50);
            this.btnHashSet.TabIndex = 3;
            this.btnHashSet.Text = "HashSet";
            this.btnHashSet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHashSet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHashSet.UseVisualStyleBackColor = false;
            this.btnHashSet.Click += new System.EventHandler(this.btnHashSet_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(2)))), ((int)(((byte)(8)))));
            this.btnClose.BackgroundImage = global::Colecoes.Properties.Resources.outline_cancel_black_24dp;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(0, 400);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(144, 50);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Fechar";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLista
            // 
            this.btnLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.btnLista.BackgroundImage = global::Colecoes.Properties.Resources.outline_play_arrow_black_24dp;
            this.btnLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLista.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLista.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLista.FlatAppearance.BorderSize = 0;
            this.btnLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLista.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLista.Location = new System.Drawing.Point(0, 0);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(144, 50);
            this.btnLista.TabIndex = 0;
            this.btnLista.Text = "Lista";
            this.btnLista.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLista.UseVisualStyleBackColor = false;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // listBox
            // 
            this.listBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 30;
            this.listBox.Location = new System.Drawing.Point(173, 12);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(615, 422);
            this.listBox.TabIndex = 1;
            // 
            // pnChoice
            // 
            this.pnChoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.pnChoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnChoice.Location = new System.Drawing.Point(144, 0);
            this.pnChoice.Name = "pnChoice";
            this.pnChoice.Size = new System.Drawing.Size(5, 50);
            this.pnChoice.TabIndex = 2;
            // 
            // timerFade
            // 
            this.timerFade.Enabled = true;
            this.timerFade.Interval = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnChoice);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.pnMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Panel pnChoice;
        private System.Windows.Forms.Timer timerFade;
        private System.Windows.Forms.Button btnHashSet;
        private System.Windows.Forms.Button btnStack;
        private System.Windows.Forms.Button btnQueue;
        private System.Windows.Forms.Button btnDictionary;
        private System.Windows.Forms.Button btnSortedSet;
        private System.Windows.Forms.Button btnSortedDictionary;
        private System.Windows.Forms.Button btnSortedList;
    }
}

