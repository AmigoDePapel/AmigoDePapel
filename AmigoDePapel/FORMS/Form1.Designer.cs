namespace AmigoDePapel
{
    partial class Index
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_book = new System.Windows.Forms.TabPage();
            this.tp_user = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ts_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(884, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::AmigoDePapel.Properties.Resources.arrow_refresh;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::AmigoDePapel.Properties.Resources.book_add;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::AmigoDePapel.Properties.Resources.user_add;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_book);
            this.tabControl1.Controls.Add(this.tp_user);
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(884, 508);
            this.tabControl1.TabIndex = 2;
            // 
            // tp_book
            // 
            this.tp_book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tp_book.Location = new System.Drawing.Point(4, 22);
            this.tp_book.Name = "tp_book";
            this.tp_book.Padding = new System.Windows.Forms.Padding(3);
            this.tp_book.Size = new System.Drawing.Size(876, 482);
            this.tp_book.TabIndex = 0;
            this.tp_book.Text = "Livros";
            // 
            // tp_user
            // 
            this.tp_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tp_user.Location = new System.Drawing.Point(4, 22);
            this.tp_user.Name = "tp_user";
            this.tp_user.Padding = new System.Windows.Forms.Padding(3);
            this.tp_user.Size = new System.Drawing.Size(876, 482);
            this.tp_user.TabIndex = 1;
            this.tp_user.Text = "Usúarios";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_status,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(884, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ts_status
            // 
            this.ts_status.Name = "ts_status";
            this.ts_status.Size = new System.Drawing.Size(91, 17);
            this.ts_status.Text = "Status da Base:  ";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Image = global::AmigoDePapel.Properties.Resources.tick;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amigo de Papel - Controle";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_book;
        private System.Windows.Forms.TabPage tp_user;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ts_status;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

