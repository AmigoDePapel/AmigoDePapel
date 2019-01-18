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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_reflesh = new System.Windows.Forms.ToolStripButton();
            this.tsb_add_livro = new System.Windows.Forms.ToolStripButton();
            this.tsb_add_userr = new System.Windows.Forms.ToolStripButton();
            this.tsb_report = new System.Windows.Forms.ToolStripButton();
            this.tsb_help = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tc_main = new System.Windows.Forms.TabControl();
            this.tp_book = new System.Windows.Forms.TabPage();
            this.pb_cancelaPesquisa = new System.Windows.Forms.PictureBox();
            this.capa = new System.Windows.Forms.PictureBox();
            this.pb_pesquisa_livro = new System.Windows.Forms.PictureBox();
            this.tb_pesquisaLivro = new System.Windows.Forms.TextBox();
            this.dg_livro = new System.Windows.Forms.DataGridView();
            this.tp_user = new System.Windows.Forms.TabPage();
            this.dg_user = new System.Windows.Forms.DataGridView();
            this.tb_pesquisaUser = new System.Windows.Forms.PictureBox();
            this.tb_pesquisa_user = new System.Windows.Forms.TextBox();
            this.pc_pesquisa_user = new System.Windows.Forms.PictureBox();
            this.tb_loan = new System.Windows.Forms.TabPage();
            this.pb_pesquisa_emprestimo = new System.Windows.Forms.PictureBox();
            this.tb_emprestimo = new System.Windows.Forms.TextBox();
            this.dg_emprestimo = new System.Windows.Forms.DataGridView();
            this.cb_emdia = new System.Windows.Forms.CheckBox();
            this.cb_atrasados = new System.Windows.Forms.CheckBox();
            this.cb_encerrados = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tss_adp = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss_img = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolStrip1.SuspendLayout();
            this.tc_main.SuspendLayout();
            this.tp_book.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cancelaPesquisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pesquisa_livro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_livro)).BeginInit();
            this.tp_user.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_pesquisaUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_pesquisa_user)).BeginInit();
            this.tb_loan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pesquisa_emprestimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_emprestimo)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_reflesh,
            this.tsb_add_livro,
            this.tsb_add_userr,
            this.tsb_report,
            this.tsb_help,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(887, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_reflesh
            // 
            this.tsb_reflesh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_reflesh.Image = global::AmigoDePapel.Properties.Resources.arrow_refresh;
            this.tsb_reflesh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_reflesh.Name = "tsb_reflesh";
            this.tsb_reflesh.Size = new System.Drawing.Size(23, 22);
            this.tsb_reflesh.Text = "Recarrega as informações";
            this.tsb_reflesh.Click += new System.EventHandler(this.tsb_reflesh_Click);
            // 
            // tsb_add_livro
            // 
            this.tsb_add_livro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_add_livro.Image = global::AmigoDePapel.Properties.Resources.book_add;
            this.tsb_add_livro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_add_livro.Name = "tsb_add_livro";
            this.tsb_add_livro.Size = new System.Drawing.Size(23, 22);
            this.tsb_add_livro.Text = "Cadastra novo livro";
            this.tsb_add_livro.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // tsb_add_userr
            // 
            this.tsb_add_userr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_add_userr.Image = global::AmigoDePapel.Properties.Resources.user_add;
            this.tsb_add_userr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_add_userr.Name = "tsb_add_userr";
            this.tsb_add_userr.Size = new System.Drawing.Size(23, 22);
            this.tsb_add_userr.Text = "Cadastra novo usuário";
            this.tsb_add_userr.Click += new System.EventHandler(this.tsb_add_userr_Click);
            // 
            // tsb_report
            // 
            this.tsb_report.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_report.Image = global::AmigoDePapel.Properties.Resources.chart_bar;
            this.tsb_report.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_report.Name = "tsb_report";
            this.tsb_report.Size = new System.Drawing.Size(23, 22);
            this.tsb_report.Text = "Relátorios";
            // 
            // tsb_help
            // 
            this.tsb_help.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_help.Image = global::AmigoDePapel.Properties.Resources.help;
            this.tsb_help.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_help.Name = "tsb_help";
            this.tsb_help.Size = new System.Drawing.Size(23, 22);
            this.tsb_help.Text = "Ajuda";
            this.tsb_help.Click += new System.EventHandler(this.tsb_help_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::AmigoDePapel.Properties.Resources.cog;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Configurações";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tc_main
            // 
            this.tc_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tc_main.Controls.Add(this.tp_book);
            this.tc_main.Controls.Add(this.tp_user);
            this.tc_main.Controls.Add(this.tb_loan);
            this.tc_main.Location = new System.Drawing.Point(0, 28);
            this.tc_main.Name = "tc_main";
            this.tc_main.SelectedIndex = 0;
            this.tc_main.Size = new System.Drawing.Size(887, 510);
            this.tc_main.TabIndex = 2;
            // 
            // tp_book
            // 
            this.tp_book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tp_book.Controls.Add(this.pb_cancelaPesquisa);
            this.tp_book.Controls.Add(this.capa);
            this.tp_book.Controls.Add(this.pb_pesquisa_livro);
            this.tp_book.Controls.Add(this.tb_pesquisaLivro);
            this.tp_book.Controls.Add(this.dg_livro);
            this.tp_book.Location = new System.Drawing.Point(4, 22);
            this.tp_book.Name = "tp_book";
            this.tp_book.Padding = new System.Windows.Forms.Padding(3);
            this.tp_book.Size = new System.Drawing.Size(879, 484);
            this.tp_book.TabIndex = 0;
            this.tp_book.Text = "Livros";
            // 
            // pb_cancelaPesquisa
            // 
            this.pb_cancelaPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_cancelaPesquisa.BackColor = System.Drawing.Color.White;
            this.pb_cancelaPesquisa.Image = global::AmigoDePapel.Properties.Resources.cancel;
            this.pb_cancelaPesquisa.Location = new System.Drawing.Point(831, 8);
            this.pb_cancelaPesquisa.Name = "pb_cancelaPesquisa";
            this.pb_cancelaPesquisa.Size = new System.Drawing.Size(16, 16);
            this.pb_cancelaPesquisa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_cancelaPesquisa.TabIndex = 7;
            this.pb_cancelaPesquisa.TabStop = false;
            this.pb_cancelaPesquisa.Visible = false;
            this.pb_cancelaPesquisa.Click += new System.EventHandler(this.pb_cancelaPesquisa_Click);
            // 
            // capa
            // 
            this.capa.Location = new System.Drawing.Point(848, 462);
            this.capa.Name = "capa";
            this.capa.Size = new System.Drawing.Size(23, 16);
            this.capa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.capa.TabIndex = 6;
            this.capa.TabStop = false;
            this.capa.Visible = false;
            this.capa.Click += new System.EventHandler(this.capa_Click);
            // 
            // pb_pesquisa_livro
            // 
            this.pb_pesquisa_livro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_pesquisa_livro.BackColor = System.Drawing.Color.White;
            this.pb_pesquisa_livro.Image = global::AmigoDePapel.Properties.Resources.zoom;
            this.pb_pesquisa_livro.Location = new System.Drawing.Point(853, 8);
            this.pb_pesquisa_livro.Name = "pb_pesquisa_livro";
            this.pb_pesquisa_livro.Size = new System.Drawing.Size(16, 16);
            this.pb_pesquisa_livro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_pesquisa_livro.TabIndex = 5;
            this.pb_pesquisa_livro.TabStop = false;
            this.pb_pesquisa_livro.Click += new System.EventHandler(this.pb_pesquisa_livro_Click);
            // 
            // tb_pesquisaLivro
            // 
            this.tb_pesquisaLivro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_pesquisaLivro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_pesquisaLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pesquisaLivro.Location = new System.Drawing.Point(8, 6);
            this.tb_pesquisaLivro.MaxLength = 99;
            this.tb_pesquisaLivro.Name = "tb_pesquisaLivro";
            this.tb_pesquisaLivro.Size = new System.Drawing.Size(863, 20);
            this.tb_pesquisaLivro.TabIndex = 4;
            this.tb_pesquisaLivro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_pesquisaLivro_KeyUp);
            // 
            // dg_livro
            // 
            this.dg_livro.AllowUserToAddRows = false;
            this.dg_livro.AllowUserToDeleteRows = false;
            this.dg_livro.AllowUserToResizeRows = false;
            this.dg_livro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_livro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dg_livro.BackgroundColor = System.Drawing.Color.White;
            this.dg_livro.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dg_livro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_livro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_livro.GridColor = System.Drawing.Color.DarkGray;
            this.dg_livro.Location = new System.Drawing.Point(6, 32);
            this.dg_livro.MultiSelect = false;
            this.dg_livro.Name = "dg_livro";
            this.dg_livro.ReadOnly = true;
            this.dg_livro.RowHeadersVisible = false;
            this.dg_livro.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Maroon;
            this.dg_livro.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_livro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_livro.ShowCellErrors = false;
            this.dg_livro.ShowCellToolTips = false;
            this.dg_livro.ShowEditingIcon = false;
            this.dg_livro.Size = new System.Drawing.Size(865, 446);
            this.dg_livro.TabIndex = 3;
            this.dg_livro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_livro_CellClick);
            this.dg_livro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_livro_CellContentClick);
            this.dg_livro.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_livro_CellDoubleClick);
            // 
            // tp_user
            // 
            this.tp_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tp_user.Controls.Add(this.dg_user);
            this.tp_user.Controls.Add(this.tb_pesquisaUser);
            this.tp_user.Controls.Add(this.tb_pesquisa_user);
            this.tp_user.Controls.Add(this.pc_pesquisa_user);
            this.tp_user.Location = new System.Drawing.Point(4, 22);
            this.tp_user.Name = "tp_user";
            this.tp_user.Padding = new System.Windows.Forms.Padding(3);
            this.tp_user.Size = new System.Drawing.Size(879, 484);
            this.tp_user.TabIndex = 1;
            this.tp_user.Text = "Usúarios";
            // 
            // dg_user
            // 
            this.dg_user.AllowUserToAddRows = false;
            this.dg_user.AllowUserToDeleteRows = false;
            this.dg_user.AllowUserToResizeRows = false;
            this.dg_user.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_user.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dg_user.BackgroundColor = System.Drawing.Color.White;
            this.dg_user.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dg_user.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_user.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dg_user.GridColor = System.Drawing.Color.DarkGray;
            this.dg_user.Location = new System.Drawing.Point(6, 32);
            this.dg_user.MultiSelect = false;
            this.dg_user.Name = "dg_user";
            this.dg_user.ReadOnly = true;
            this.dg_user.RowHeadersVisible = false;
            this.dg_user.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Maroon;
            this.dg_user.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dg_user.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_user.ShowCellErrors = false;
            this.dg_user.ShowCellToolTips = false;
            this.dg_user.ShowEditingIcon = false;
            this.dg_user.Size = new System.Drawing.Size(865, 446);
            this.dg_user.TabIndex = 11;
            this.dg_user.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_user_CellClick);
            this.dg_user.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_user_CellDoubleClick);
            // 
            // tb_pesquisaUser
            // 
            this.tb_pesquisaUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_pesquisaUser.BackColor = System.Drawing.Color.White;
            this.tb_pesquisaUser.Image = global::AmigoDePapel.Properties.Resources.zoom;
            this.tb_pesquisaUser.Location = new System.Drawing.Point(853, 8);
            this.tb_pesquisaUser.Name = "tb_pesquisaUser";
            this.tb_pesquisaUser.Size = new System.Drawing.Size(16, 16);
            this.tb_pesquisaUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.tb_pesquisaUser.TabIndex = 10;
            this.tb_pesquisaUser.TabStop = false;
            this.tb_pesquisaUser.Click += new System.EventHandler(this.tb_pesquisaUser_Click);
            // 
            // tb_pesquisa_user
            // 
            this.tb_pesquisa_user.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_pesquisa_user.Location = new System.Drawing.Point(8, 6);
            this.tb_pesquisa_user.Name = "tb_pesquisa_user";
            this.tb_pesquisa_user.Size = new System.Drawing.Size(863, 20);
            this.tb_pesquisa_user.TabIndex = 7;
            // 
            // pc_pesquisa_user
            // 
            this.pc_pesquisa_user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pc_pesquisa_user.BackColor = System.Drawing.Color.White;
            this.pc_pesquisa_user.Image = global::AmigoDePapel.Properties.Resources.zoom;
            this.pc_pesquisa_user.Location = new System.Drawing.Point(850, 8);
            this.pc_pesquisa_user.Name = "pc_pesquisa_user";
            this.pc_pesquisa_user.Size = new System.Drawing.Size(16, 16);
            this.pc_pesquisa_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pc_pesquisa_user.TabIndex = 8;
            this.pc_pesquisa_user.TabStop = false;
            // 
            // tb_loan
            // 
            this.tb_loan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tb_loan.Controls.Add(this.pb_pesquisa_emprestimo);
            this.tb_loan.Controls.Add(this.tb_emprestimo);
            this.tb_loan.Controls.Add(this.dg_emprestimo);
            this.tb_loan.Controls.Add(this.cb_emdia);
            this.tb_loan.Controls.Add(this.cb_atrasados);
            this.tb_loan.Controls.Add(this.cb_encerrados);
            this.tb_loan.Location = new System.Drawing.Point(4, 22);
            this.tb_loan.Name = "tb_loan";
            this.tb_loan.Size = new System.Drawing.Size(879, 484);
            this.tb_loan.TabIndex = 2;
            this.tb_loan.Text = "Empréstimos";
            // 
            // pb_pesquisa_emprestimo
            // 
            this.pb_pesquisa_emprestimo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_pesquisa_emprestimo.BackColor = System.Drawing.Color.White;
            this.pb_pesquisa_emprestimo.Image = global::AmigoDePapel.Properties.Resources.zoom;
            this.pb_pesquisa_emprestimo.Location = new System.Drawing.Point(853, 8);
            this.pb_pesquisa_emprestimo.Name = "pb_pesquisa_emprestimo";
            this.pb_pesquisa_emprestimo.Size = new System.Drawing.Size(16, 16);
            this.pb_pesquisa_emprestimo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_pesquisa_emprestimo.TabIndex = 11;
            this.pb_pesquisa_emprestimo.TabStop = false;
            // 
            // tb_emprestimo
            // 
            this.tb_emprestimo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_emprestimo.Location = new System.Drawing.Point(233, 6);
            this.tb_emprestimo.Name = "tb_emprestimo";
            this.tb_emprestimo.Size = new System.Drawing.Size(638, 20);
            this.tb_emprestimo.TabIndex = 8;
            // 
            // dg_emprestimo
            // 
            this.dg_emprestimo.AllowUserToAddRows = false;
            this.dg_emprestimo.AllowUserToDeleteRows = false;
            this.dg_emprestimo.AllowUserToResizeRows = false;
            this.dg_emprestimo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_emprestimo.BackgroundColor = System.Drawing.Color.White;
            this.dg_emprestimo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dg_emprestimo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_emprestimo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dg_emprestimo.GridColor = System.Drawing.Color.DarkGray;
            this.dg_emprestimo.Location = new System.Drawing.Point(6, 32);
            this.dg_emprestimo.Name = "dg_emprestimo";
            this.dg_emprestimo.ReadOnly = true;
            this.dg_emprestimo.RowHeadersVisible = false;
            this.dg_emprestimo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Maroon;
            this.dg_emprestimo.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dg_emprestimo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_emprestimo.ShowCellErrors = false;
            this.dg_emprestimo.ShowCellToolTips = false;
            this.dg_emprestimo.ShowEditingIcon = false;
            this.dg_emprestimo.Size = new System.Drawing.Size(865, 446);
            this.dg_emprestimo.TabIndex = 4;
            // 
            // cb_emdia
            // 
            this.cb_emdia.AutoSize = true;
            this.cb_emdia.Location = new System.Drawing.Point(169, 8);
            this.cb_emdia.Name = "cb_emdia";
            this.cb_emdia.Size = new System.Drawing.Size(58, 17);
            this.cb_emdia.TabIndex = 2;
            this.cb_emdia.Text = "Em dia";
            this.cb_emdia.UseVisualStyleBackColor = true;
            // 
            // cb_atrasados
            // 
            this.cb_atrasados.AutoSize = true;
            this.cb_atrasados.Location = new System.Drawing.Point(90, 8);
            this.cb_atrasados.Name = "cb_atrasados";
            this.cb_atrasados.Size = new System.Drawing.Size(73, 17);
            this.cb_atrasados.TabIndex = 1;
            this.cb_atrasados.Text = "Atrasados";
            this.cb_atrasados.UseVisualStyleBackColor = true;
            // 
            // cb_encerrados
            // 
            this.cb_encerrados.AutoSize = true;
            this.cb_encerrados.Location = new System.Drawing.Point(4, 8);
            this.cb_encerrados.Name = "cb_encerrados";
            this.cb_encerrados.Size = new System.Drawing.Size(80, 17);
            this.cb_encerrados.TabIndex = 0;
            this.cb_encerrados.Text = "Encerrados";
            this.cb_encerrados.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tss_adp,
            this.tss_status,
            this.tss_img,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 541);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(887, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tss_adp
            // 
            this.tss_adp.Name = "tss_adp";
            this.tss_adp.Size = new System.Drawing.Size(227, 17);
            this.tss_adp.Text = "Amigo de papel - 0.09.2v ALPHA RELEASE";
            // 
            // tss_status
            // 
            this.tss_status.Name = "tss_status";
            this.tss_status.Size = new System.Drawing.Size(91, 17);
            this.tss_status.Text = "Status da Base:  ";
            // 
            // tss_img
            // 
            this.tss_img.Image = global::AmigoDePapel.Properties.Resources.tick;
            this.tss_img.Name = "tss_img";
            this.tss_img.Size = new System.Drawing.Size(16, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(887, 563);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tc_main);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amigo de Papel - Controle";
            this.Load += new System.EventHandler(this.Index_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tc_main.ResumeLayout(false);
            this.tp_book.ResumeLayout(false);
            this.tp_book.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cancelaPesquisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pesquisa_livro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_livro)).EndInit();
            this.tp_user.ResumeLayout(false);
            this.tp_user.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_pesquisaUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_pesquisa_user)).EndInit();
            this.tb_loan.ResumeLayout(false);
            this.tb_loan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pesquisa_emprestimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_emprestimo)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_reflesh;
        private System.Windows.Forms.ToolStripButton tsb_add_livro;
        private System.Windows.Forms.ToolStripButton tsb_add_userr;
        private System.Windows.Forms.TabControl tc_main;
        private System.Windows.Forms.TabPage tp_book;
        private System.Windows.Forms.TabPage tp_user;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tss_status;
        private System.Windows.Forms.ToolStripStatusLabel tss_img;
        private System.Windows.Forms.DataGridView dg_livro;
        private System.Windows.Forms.TextBox tb_pesquisaLivro;
        private System.Windows.Forms.PictureBox pb_pesquisa_livro;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripButton tsb_report;
        private System.Windows.Forms.ToolStripButton tsb_help;
        private System.Windows.Forms.ToolStripStatusLabel tss_adp;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pc_pesquisa_user;

        private System.Windows.Forms.TextBox tb_pesquisa_user;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.PictureBox capa;
        private System.Windows.Forms.TabPage tb_loan;
        private System.Windows.Forms.PictureBox tb_pesquisaUser;
        private System.Windows.Forms.CheckBox cb_emdia;
        private System.Windows.Forms.CheckBox cb_atrasados;
        private System.Windows.Forms.CheckBox cb_encerrados;
        private System.Windows.Forms.PictureBox pb_pesquisa_emprestimo;
        private System.Windows.Forms.TextBox tb_emprestimo;
        private System.Windows.Forms.DataGridView dg_emprestimo;
        private System.Windows.Forms.DataGridView dg_user;
        private System.Windows.Forms.PictureBox pb_cancelaPesquisa;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

