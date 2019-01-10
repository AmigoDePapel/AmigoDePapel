namespace AmigoDePapel.FORMS
{
    partial class CadastraLivro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb_cadastroLivro = new System.Windows.Forms.GroupBox();
            this.tb_isbn = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ano = new System.Windows.Forms.TextBox();
            this.lb_subtitulo = new System.Windows.Forms.Label();
            this.lb_codigo = new System.Windows.Forms.Label();
            this.lb_paginas = new System.Windows.Forms.Label();
            this.cb_subtema = new System.Windows.Forms.ComboBox();
            this.cb_tema = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_pagina = new System.Windows.Forms.TextBox();
            this.llb_subtema = new System.Windows.Forms.Label();
            this.lb_tema = new System.Windows.Forms.Label();
            this.lb_autor = new System.Windows.Forms.Label();
            this.tb_autor = new System.Windows.Forms.TextBox();
            this.lb_versao = new System.Windows.Forms.Label();
            this.tb_versao = new System.Windows.Forms.TextBox();
            this.lb_editora = new System.Windows.Forms.Label();
            this.tb_editora = new System.Windows.Forms.TextBox();
            this.lb_ISBN = new System.Windows.Forms.Label();
            this.tb_subtitulo = new System.Windows.Forms.TextBox();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.tb_titulo = new System.Windows.Forms.TextBox();
            this.gb_observacao = new System.Windows.Forms.GroupBox();
            this.lb_oservacao = new System.Windows.Forms.Label();
            this.tb_obs = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_save = new System.Windows.Forms.ToolStripButton();
            this.tsb_retirar = new System.Windows.Forms.ToolStripButton();
            this.tsb_addimg = new System.Windows.Forms.ToolStripButton();
            this.tsb_deleteimg = new System.Windows.Forms.ToolStripButton();
            this.tsb_ajuda = new System.Windows.Forms.ToolStripButton();
            this.ofd_capa = new System.Windows.Forms.OpenFileDialog();
            this.tsb_historico = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.gb_cadastroLivro.SuspendLayout();
            this.gb_observacao.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_cadastroLivro
            // 
            this.gb_cadastroLivro.BackColor = System.Drawing.Color.Transparent;
            this.gb_cadastroLivro.Controls.Add(this.tb_isbn);
            this.gb_cadastroLivro.Controls.Add(this.label2);
            this.gb_cadastroLivro.Controls.Add(this.tb_ano);
            this.gb_cadastroLivro.Controls.Add(this.lb_subtitulo);
            this.gb_cadastroLivro.Controls.Add(this.lb_codigo);
            this.gb_cadastroLivro.Controls.Add(this.lb_paginas);
            this.gb_cadastroLivro.Controls.Add(this.cb_subtema);
            this.gb_cadastroLivro.Controls.Add(this.cb_tema);
            this.gb_cadastroLivro.Controls.Add(this.label6);
            this.gb_cadastroLivro.Controls.Add(this.tb_pagina);
            this.gb_cadastroLivro.Controls.Add(this.llb_subtema);
            this.gb_cadastroLivro.Controls.Add(this.lb_tema);
            this.gb_cadastroLivro.Controls.Add(this.lb_autor);
            this.gb_cadastroLivro.Controls.Add(this.tb_autor);
            this.gb_cadastroLivro.Controls.Add(this.lb_versao);
            this.gb_cadastroLivro.Controls.Add(this.tb_versao);
            this.gb_cadastroLivro.Controls.Add(this.lb_editora);
            this.gb_cadastroLivro.Controls.Add(this.tb_editora);
            this.gb_cadastroLivro.Controls.Add(this.lb_ISBN);
            this.gb_cadastroLivro.Controls.Add(this.tb_subtitulo);
            this.gb_cadastroLivro.Controls.Add(this.lb_titulo);
            this.gb_cadastroLivro.Controls.Add(this.tb_titulo);
            this.gb_cadastroLivro.Location = new System.Drawing.Point(13, 28);
            this.gb_cadastroLivro.Name = "gb_cadastroLivro";
            this.gb_cadastroLivro.Size = new System.Drawing.Size(801, 230);
            this.gb_cadastroLivro.TabIndex = 0;
            this.gb_cadastroLivro.TabStop = false;
            // 
            // tb_isbn
            // 
            this.tb_isbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_isbn.Location = new System.Drawing.Point(8, 144);
            this.tb_isbn.Mask = "000-00-000-0000-0";
            this.tb_isbn.Name = "tb_isbn";
            this.tb_isbn.Size = new System.Drawing.Size(134, 21);
            this.tb_isbn.TabIndex = 25;
            this.tb_isbn.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(620, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "ANO";
            // 
            // tb_ano
            // 
            this.tb_ano.AllowDrop = true;
            this.tb_ano.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_ano.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ano.Location = new System.Drawing.Point(620, 144);
            this.tb_ano.Name = "tb_ano";
            this.tb_ano.Size = new System.Drawing.Size(67, 21);
            this.tb_ano.TabIndex = 5;
            this.tb_ano.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lb_subtitulo
            // 
            this.lb_subtitulo.AutoSize = true;
            this.lb_subtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_subtitulo.Location = new System.Drawing.Point(8, 76);
            this.lb_subtitulo.Name = "lb_subtitulo";
            this.lb_subtitulo.Size = new System.Drawing.Size(77, 13);
            this.lb_subtitulo.TabIndex = 22;
            this.lb_subtitulo.Text = "SUBTÍTULO";
            // 
            // lb_codigo
            // 
            this.lb_codigo.AutoSize = true;
            this.lb_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_codigo.Location = new System.Drawing.Point(8, 16);
            this.lb_codigo.Name = "lb_codigo";
            this.lb_codigo.Size = new System.Drawing.Size(21, 13);
            this.lb_codigo.TabIndex = 21;
            this.lb_codigo.Text = "00";
            // 
            // lb_paginas
            // 
            this.lb_paginas.AutoSize = true;
            this.lb_paginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_paginas.Location = new System.Drawing.Point(702, 128);
            this.lb_paginas.Name = "lb_paginas";
            this.lb_paginas.Size = new System.Drawing.Size(66, 13);
            this.lb_paginas.TabIndex = 20;
            this.lb_paginas.Text = "QTD PÁG.";
            // 
            // cb_subtema
            // 
            this.cb_subtema.AllowDrop = true;
            this.cb_subtema.AutoCompleteCustomSource.AddRange(new string[] {
            "AGENDAS",
            "ARTE",
            "ATUALIDADES",
            "AUTOAJUDA",
            "BIOGRAFIA",
            "BIOLOGIA",
            "CALENDÁRIOS",
            "CIÊNCIA",
            "CIÊNCIAS HUMANAS E SOCIAIS",
            "COLORIR",
            "CONTOS",
            "DESENVOLVIMENTO PESSOAL",
            "DICIONÁRIOS E REFERÊNCIA",
            "ECONOMIA",
            "EDUCAÇÃO",
            "ESOTERISMO",
            "ESTILO DE VIDA",
            "FANTASIA",
            "FEMININO",
            "FICÇÃO",
            "FÍSICA",
            "FILOSOFIA",
            "GASTRONOMIA",
            "HISTÓRIA",
            "HUMOR",
            "INFANTIL",
            "JUVENIL",
            "MATEMÁTICA",
            "LITERATURA NACIONAL",
            "LITERATURA ESTRANGEIRA",
            "NEGÓCIOS",
            "POESIA",
            "POLITICA",
            "PSICOLOGIA",
            "QUADRINHOS",
            "RELIGIÃO",
            "ESPIRITUALIDADE",
            "ROMANCE",
            "SAUDE",
            "TEATRO",
            "TERROR",
            "OUTROS"});
            this.cb_subtema.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_subtema.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cb_subtema.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_subtema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_subtema.Items.AddRange(new object[] {
            "AGENDAS",
            "ARTE",
            "ATUALIDADES",
            "AUTOAJUDA",
            "BIOGRAFIA",
            "BIOLOGIA",
            "CALENDÁRIOS",
            "CIÊNCIA",
            "CIÊNCIAS HUMANAS E SOCIAIS",
            "COLORIR",
            "CONTOS",
            "DESENVOLVIMENTO PESSOAL",
            "DICIONÁRIOS E REFERÊNCIA",
            "ECONOMIA",
            "EDUCAÇÃO",
            "ESOTERISMO",
            "ESTILO DE VIDA",
            "FANTASIA",
            "FEMININO",
            "FICÇÃO",
            "FÍSICA",
            "FILOSOFIA",
            "GASTRONOMIA",
            "HISTÓRIA",
            "HUMOR",
            "INFANTIL",
            "JUVENIL",
            "MATEMÁTICA",
            "LITERATURA NACIONAL",
            "LITERATURA ESTRANGEIRA",
            "NEGÓCIOS",
            "POESIA",
            "POLITICA",
            "PSICOLOGIA",
            "QUADRINHOS",
            "RELIGIÃO",
            "ESPIRITUALIDADE",
            "ROMANCE",
            "SAUDE",
            "TEATRO",
            "TERROR",
            "OUTROS"});
            this.cb_subtema.Location = new System.Drawing.Point(556, 191);
            this.cb_subtema.Name = "cb_subtema";
            this.cb_subtema.Size = new System.Drawing.Size(222, 23);
            this.cb_subtema.TabIndex = 8;
            // 
            // cb_tema
            // 
            this.cb_tema.AllowDrop = true;
            this.cb_tema.AutoCompleteCustomSource.AddRange(new string[] {
            "AGENDAS",
            "ARTE",
            "ATUALIDADES",
            "AUTOAJUDA",
            "BIOGRAFIA",
            "BIOLOGIA",
            "CALENDÁRIOS",
            "CIÊNCIA",
            "CIÊNCIAS HUMANAS E SOCIAIS",
            "COLORIR",
            "CONTOS",
            "DESENVOLVIMENTO PESSOAL",
            "DICIONÁRIOS E REFERÊNCIA",
            "ECONOMIA",
            "EDUCAÇÃO",
            "ESOTERISMO",
            "ESTILO DE VIDA",
            "FANTASIA",
            "FEMININO",
            "FICÇÃO",
            "FÍSICA",
            "FILOSOFIA",
            "GASTRONOMIA",
            "HISTÓRIA",
            "HUMOR",
            "INFANTIL",
            "JUVENIL",
            "MATEMÁTICA",
            "LITERATURA NACIONAL",
            "LITERATURA ESTRANGEIRA",
            "NEGÓCIOS",
            "POESIA",
            "POLITICA",
            "PSICOLOGIA",
            "QUADRINHOS",
            "RELIGIÃO",
            "ESPIRITUALIDADE",
            "ROMANCE",
            "SAUDE",
            "TEATRO",
            "TERROR",
            "OUTROS"});
            this.cb_tema.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_tema.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cb_tema.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_tema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tema.Items.AddRange(new object[] {
            "AGENDAS",
            "ARTE",
            "ATUALIDADES",
            "AUTOAJUDA",
            "BIOGRAFIA",
            "BIOLOGIA",
            "CALENDÁRIOS",
            "CIÊNCIA",
            "CIÊNCIAS HUMANAS E SOCIAIS",
            "COLORIR",
            "CONTOS",
            "DESENVOLVIMENTO PESSOAL",
            "DICIONÁRIOS E REFERÊNCIA",
            "ECONOMIA",
            "EDUCAÇÃO",
            "ESOTERISMO",
            "ESTILO DE VIDA",
            "FANTASIA",
            "FEMININO",
            "FICÇÃO",
            "FÍSICA",
            "FILOSOFIA",
            "GASTRONOMIA",
            "HISTÓRIA",
            "HUMOR",
            "INFANTIL",
            "JUVENIL",
            "MATEMÁTICA",
            "LITERATURA NACIONAL",
            "LITERATURA ESTRANGEIRA",
            "NEGÓCIOS",
            "POESIA",
            "POLITICA",
            "PSICOLOGIA",
            "QUADRINHOS",
            "RELIGIÃO",
            "ESPIRITUALIDADE",
            "ROMANCE",
            "SAUDE",
            "TEATRO",
            "TERROR",
            "OUTROS"});
            this.cb_tema.Location = new System.Drawing.Point(320, 191);
            this.cb_tema.Name = "cb_tema";
            this.cb_tema.Size = new System.Drawing.Size(228, 23);
            this.cb_tema.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(617, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 17;
            // 
            // tb_pagina
            // 
            this.tb_pagina.AllowDrop = true;
            this.tb_pagina.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_pagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pagina.Location = new System.Drawing.Point(702, 144);
            this.tb_pagina.Name = "tb_pagina";
            this.tb_pagina.Size = new System.Drawing.Size(76, 21);
            this.tb_pagina.TabIndex = 9;
            this.tb_pagina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // llb_subtema
            // 
            this.llb_subtema.AutoSize = true;
            this.llb_subtema.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llb_subtema.Location = new System.Drawing.Point(553, 176);
            this.llb_subtema.Name = "llb_subtema";
            this.llb_subtema.Size = new System.Drawing.Size(70, 13);
            this.llb_subtema.TabIndex = 15;
            this.llb_subtema.Text = "SUB-TEMA";
            // 
            // lb_tema
            // 
            this.lb_tema.AutoSize = true;
            this.lb_tema.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tema.Location = new System.Drawing.Point(320, 176);
            this.lb_tema.Name = "lb_tema";
            this.lb_tema.Size = new System.Drawing.Size(41, 13);
            this.lb_tema.TabIndex = 13;
            this.lb_tema.Text = "TEMA";
            // 
            // lb_autor
            // 
            this.lb_autor.AutoSize = true;
            this.lb_autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_autor.Location = new System.Drawing.Point(8, 176);
            this.lb_autor.Name = "lb_autor";
            this.lb_autor.Size = new System.Drawing.Size(50, 13);
            this.lb_autor.TabIndex = 11;
            this.lb_autor.Text = "AUTOR";
            // 
            // tb_autor
            // 
            this.tb_autor.AllowDrop = true;
            this.tb_autor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_autor.Location = new System.Drawing.Point(8, 192);
            this.tb_autor.Name = "tb_autor";
            this.tb_autor.Size = new System.Drawing.Size(306, 21);
            this.tb_autor.TabIndex = 6;
            // 
            // lb_versao
            // 
            this.lb_versao.AutoSize = true;
            this.lb_versao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_versao.Location = new System.Drawing.Point(412, 128);
            this.lb_versao.Name = "lb_versao";
            this.lb_versao.Size = new System.Drawing.Size(125, 13);
            this.lb_versao.TabIndex = 9;
            this.lb_versao.Text = "VERSÃO ou EDIÇÃO";
            // 
            // tb_versao
            // 
            this.tb_versao.AllowDrop = true;
            this.tb_versao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_versao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_versao.Location = new System.Drawing.Point(412, 144);
            this.tb_versao.Name = "tb_versao";
            this.tb_versao.Size = new System.Drawing.Size(200, 21);
            this.tb_versao.TabIndex = 4;
            // 
            // lb_editora
            // 
            this.lb_editora.AutoSize = true;
            this.lb_editora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_editora.Location = new System.Drawing.Point(148, 128);
            this.lb_editora.Name = "lb_editora";
            this.lb_editora.Size = new System.Drawing.Size(62, 13);
            this.lb_editora.TabIndex = 7;
            this.lb_editora.Text = "EDITORA";
            // 
            // tb_editora
            // 
            this.tb_editora.AllowDrop = true;
            this.tb_editora.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_editora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_editora.Location = new System.Drawing.Point(148, 144);
            this.tb_editora.Name = "tb_editora";
            this.tb_editora.Size = new System.Drawing.Size(258, 21);
            this.tb_editora.TabIndex = 3;
            // 
            // lb_ISBN
            // 
            this.lb_ISBN.AutoSize = true;
            this.lb_ISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ISBN.Location = new System.Drawing.Point(8, 128);
            this.lb_ISBN.Name = "lb_ISBN";
            this.lb_ISBN.Size = new System.Drawing.Size(83, 13);
            this.lb_ISBN.TabIndex = 5;
            this.lb_ISBN.Text = "ISBN ou EAN";
            // 
            // tb_subtitulo
            // 
            this.tb_subtitulo.AllowDrop = true;
            this.tb_subtitulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_subtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_subtitulo.Location = new System.Drawing.Point(8, 92);
            this.tb_subtitulo.Name = "tb_subtitulo";
            this.tb_subtitulo.Size = new System.Drawing.Size(782, 21);
            this.tb_subtitulo.TabIndex = 1;
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.Location = new System.Drawing.Point(8, 37);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(52, 13);
            this.lb_titulo.TabIndex = 1;
            this.lb_titulo.Text = "TÍTULO";
            // 
            // tb_titulo
            // 
            this.tb_titulo.AllowDrop = true;
            this.tb_titulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_titulo.Location = new System.Drawing.Point(8, 53);
            this.tb_titulo.Name = "tb_titulo";
            this.tb_titulo.Size = new System.Drawing.Size(783, 21);
            this.tb_titulo.TabIndex = 0;
            // 
            // gb_observacao
            // 
            this.gb_observacao.BackColor = System.Drawing.Color.Transparent;
            this.gb_observacao.Controls.Add(this.lb_oservacao);
            this.gb_observacao.Controls.Add(this.tb_obs);
            this.gb_observacao.Location = new System.Drawing.Point(13, 264);
            this.gb_observacao.Name = "gb_observacao";
            this.gb_observacao.Size = new System.Drawing.Size(801, 131);
            this.gb_observacao.TabIndex = 1;
            this.gb_observacao.TabStop = false;
            // 
            // lb_oservacao
            // 
            this.lb_oservacao.AutoSize = true;
            this.lb_oservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_oservacao.Location = new System.Drawing.Point(8, 16);
            this.lb_oservacao.Name = "lb_oservacao";
            this.lb_oservacao.Size = new System.Drawing.Size(90, 13);
            this.lb_oservacao.TabIndex = 1;
            this.lb_oservacao.Text = "OBSERVAÇÃO";
            // 
            // tb_obs
            // 
            this.tb_obs.AllowDrop = true;
            this.tb_obs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_obs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_obs.Location = new System.Drawing.Point(8, 32);
            this.tb_obs.Multiline = true;
            this.tb_obs.Name = "tb_obs";
            this.tb_obs.Size = new System.Drawing.Size(782, 82);
            this.tb_obs.TabIndex = 10;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_save,
            this.tsb_retirar,
            this.tsb_addimg,
            this.tsb_deleteimg,
            this.tsb_historico,
            this.tsb_ajuda});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(826, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_save
            // 
            this.tsb_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_save.Image = global::AmigoDePapel.Properties.Resources.disk;
            this.tsb_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_save.Name = "tsb_save";
            this.tsb_save.Size = new System.Drawing.Size(23, 22);
            this.tsb_save.Text = "Salva";
            this.tsb_save.Click += new System.EventHandler(this.tsb_save_Click);
            // 
            // tsb_retirar
            // 
            this.tsb_retirar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_retirar.Enabled = false;
            this.tsb_retirar.Image = global::AmigoDePapel.Properties.Resources.book_delete;
            this.tsb_retirar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_retirar.Name = "tsb_retirar";
            this.tsb_retirar.Size = new System.Drawing.Size(23, 22);
            this.tsb_retirar.Text = "Descarta Livro";
            this.tsb_retirar.Click += new System.EventHandler(this.tsb_retirar_Click);
            // 
            // tsb_addimg
            // 
            this.tsb_addimg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_addimg.Image = global::AmigoDePapel.Properties.Resources.image_add;
            this.tsb_addimg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_addimg.Name = "tsb_addimg";
            this.tsb_addimg.Size = new System.Drawing.Size(23, 22);
            this.tsb_addimg.Text = "Adiciona Capa";
            this.tsb_addimg.Click += new System.EventHandler(this.tsb_addimg_Click);
            // 
            // tsb_deleteimg
            // 
            this.tsb_deleteimg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_deleteimg.Enabled = false;
            this.tsb_deleteimg.Image = global::AmigoDePapel.Properties.Resources.image_delete;
            this.tsb_deleteimg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_deleteimg.Name = "tsb_deleteimg";
            this.tsb_deleteimg.Size = new System.Drawing.Size(23, 22);
            this.tsb_deleteimg.Text = "Remove Capa";
            this.tsb_deleteimg.ToolTipText = "Remova Capa";
            this.tsb_deleteimg.Click += new System.EventHandler(this.tsb_deleteimg_Click);
            // 
            // tsb_ajuda
            // 
            this.tsb_ajuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_ajuda.Image = global::AmigoDePapel.Properties.Resources.help;
            this.tsb_ajuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_ajuda.Name = "tsb_ajuda";
            this.tsb_ajuda.Size = new System.Drawing.Size(23, 22);
            this.tsb_ajuda.Text = "Ajuda";
            // 
            // tsb_historico
            // 
            this.tsb_historico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_historico.Image = global::AmigoDePapel.Properties.Resources.chart_bar;
            this.tsb_historico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_historico.Name = "tsb_historico";
            this.tsb_historico.Size = new System.Drawing.Size(23, 22);
            this.tsb_historico.Text = "Histórico";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(13, 401);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 58);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "EMPRESTADO PARA";
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(8, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(306, 21);
            this.textBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(347, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "ATÉ ";
            // 
            // textBox2
            // 
            this.textBox2.AllowDrop = true;
            this.textBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(347, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(123, 21);
            this.textBox2.TabIndex = 9;
            // 
            // CadastraLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::AmigoDePapel.Properties.Resources.wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(826, 471);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gb_observacao);
            this.Controls.Add(this.gb_cadastroLivro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CadastraLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Cadastramento de Livro";
            this.Load += new System.EventHandler(this.CadastraLivro_Load);
            this.gb_cadastroLivro.ResumeLayout(false);
            this.gb_cadastroLivro.PerformLayout();
            this.gb_observacao.ResumeLayout(false);
            this.gb_observacao.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_cadastroLivro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_pagina;
        private System.Windows.Forms.Label llb_subtema;
        private System.Windows.Forms.Label lb_tema;
        private System.Windows.Forms.Label lb_autor;
        private System.Windows.Forms.TextBox tb_autor;
        private System.Windows.Forms.Label lb_versao;
        private System.Windows.Forms.TextBox tb_versao;
        private System.Windows.Forms.Label lb_editora;
        private System.Windows.Forms.TextBox tb_editora;
        private System.Windows.Forms.Label lb_ISBN;
        private System.Windows.Forms.TextBox tb_subtitulo;
        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.TextBox tb_titulo;
        private System.Windows.Forms.GroupBox gb_observacao;
        private System.Windows.Forms.Label lb_oservacao;
        private System.Windows.Forms.TextBox tb_obs;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_save;
        private System.Windows.Forms.ToolStripButton tsb_ajuda;
        private System.Windows.Forms.Label lb_paginas;
        private System.Windows.Forms.ComboBox cb_subtema;
        private System.Windows.Forms.ComboBox cb_tema;
        private System.Windows.Forms.Label lb_codigo;
        private System.Windows.Forms.Label lb_subtitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_ano;
        private System.Windows.Forms.ToolStripButton tsb_retirar;
        private System.Windows.Forms.ToolStripButton tsb_addimg;
        private System.Windows.Forms.ToolStripButton tsb_deleteimg;
        private System.Windows.Forms.OpenFileDialog ofd_capa;
        private System.Windows.Forms.MaskedTextBox tb_isbn;
        private System.Windows.Forms.ToolStripButton tsb_historico;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}