namespace AmigoDePapel.FORMS
{
    partial class CadastraUser
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
            this.gb_observacao = new System.Windows.Forms.GroupBox();
            this.lb_oservacao = new System.Windows.Forms.Label();
            this.tb_obs = new System.Windows.Forms.TextBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.lb_endereco = new System.Windows.Forms.Label();
            this.lb_codigo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_save = new System.Windows.Forms.ToolStripButton();
            this.tsb_retirar = new System.Windows.Forms.ToolStripButton();
            this.tsb_ajuda = new System.Windows.Forms.ToolStripButton();
            this.tb_telefone = new System.Windows.Forms.TextBox();
            this.lb_telefone = new System.Windows.Forms.Label();
            this.lb_nascimento = new System.Windows.Forms.Label();
            this.lb_editora = new System.Windows.Forms.Label();
            this.lb_documento = new System.Windows.Forms.Label();
            this.tb_endereco = new System.Windows.Forms.TextBox();
            this.lb_nome_completo = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.gb_cadastraUser = new System.Windows.Forms.GroupBox();
            this.dt_nascimento = new System.Windows.Forms.DateTimePicker();
            this.tb_documento = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_documento = new System.Windows.Forms.ComboBox();
            this.lb_anos = new System.Windows.Forms.Label();
            this.gb_observacao.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.gb_cadastraUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_observacao
            // 
            this.gb_observacao.BackColor = System.Drawing.Color.Transparent;
            this.gb_observacao.Controls.Add(this.lb_oservacao);
            this.gb_observacao.Controls.Add(this.tb_obs);
            this.gb_observacao.Location = new System.Drawing.Point(13, 264);
            this.gb_observacao.Name = "gb_observacao";
            this.gb_observacao.Size = new System.Drawing.Size(801, 131);
            this.gb_observacao.TabIndex = 4;
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
            this.tb_obs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_obs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_obs.Location = new System.Drawing.Point(8, 32);
            this.tb_obs.Multiline = true;
            this.tb_obs.Name = "tb_obs";
            this.tb_obs.Size = new System.Drawing.Size(783, 82);
            this.tb_obs.TabIndex = 8;
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_email.Location = new System.Drawing.Point(477, 128);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(48, 13);
            this.lb_email.TabIndex = 24;
            this.lb_email.Text = "E-MAIL";
            // 
            // tb_email
            // 
            this.tb_email.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(480, 144);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(307, 21);
            this.tb_email.TabIndex = 6;
            // 
            // lb_endereco
            // 
            this.lb_endereco.AutoSize = true;
            this.lb_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_endereco.Location = new System.Drawing.Point(8, 76);
            this.lb_endereco.Name = "lb_endereco";
            this.lb_endereco.Size = new System.Drawing.Size(75, 13);
            this.lb_endereco.TabIndex = 22;
            this.lb_endereco.Text = "ENDEREÇO";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(617, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 17;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_save,
            this.tsb_retirar,
            this.tsb_ajuda});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(826, 25);
            this.toolStrip1.TabIndex = 5;
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
            this.tsb_save.Click += new System.EventHandler(this.tsb_save_Click_1);
            // 
            // tsb_retirar
            // 
            this.tsb_retirar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_retirar.Image = global::AmigoDePapel.Properties.Resources.book_delete;
            this.tsb_retirar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_retirar.Name = "tsb_retirar";
            this.tsb_retirar.Size = new System.Drawing.Size(23, 22);
            this.tsb_retirar.Text = "Descarta Livro";
            this.tsb_retirar.Click += new System.EventHandler(this.tsb_retirar_Click);
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
            // tb_telefone
            // 
            this.tb_telefone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_telefone.Location = new System.Drawing.Point(8, 192);
            this.tb_telefone.Name = "tb_telefone";
            this.tb_telefone.Size = new System.Drawing.Size(193, 21);
            this.tb_telefone.TabIndex = 7;
            // 
            // lb_telefone
            // 
            this.lb_telefone.AutoSize = true;
            this.lb_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_telefone.Location = new System.Drawing.Point(8, 176);
            this.lb_telefone.Name = "lb_telefone";
            this.lb_telefone.Size = new System.Drawing.Size(71, 13);
            this.lb_telefone.TabIndex = 11;
            this.lb_telefone.Text = "TELEFONE";
            // 
            // lb_nascimento
            // 
            this.lb_nascimento.AutoSize = true;
            this.lb_nascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nascimento.Location = new System.Drawing.Point(354, 128);
            this.lb_nascimento.Name = "lb_nascimento";
            this.lb_nascimento.Size = new System.Drawing.Size(44, 13);
            this.lb_nascimento.TabIndex = 9;
            this.lb_nascimento.Text = "NASC.";
            // 
            // lb_editora
            // 
            this.lb_editora.AutoSize = true;
            this.lb_editora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_editora.Location = new System.Drawing.Point(210, 128);
            this.lb_editora.Name = "lb_editora";
            this.lb_editora.Size = new System.Drawing.Size(0, 13);
            this.lb_editora.TabIndex = 7;
            // 
            // lb_documento
            // 
            this.lb_documento.AutoSize = true;
            this.lb_documento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_documento.Location = new System.Drawing.Point(8, 128);
            this.lb_documento.Name = "lb_documento";
            this.lb_documento.Size = new System.Drawing.Size(86, 13);
            this.lb_documento.TabIndex = 5;
            this.lb_documento.Text = "DOCUMENTO";
            // 
            // tb_endereco
            // 
            this.tb_endereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_endereco.Location = new System.Drawing.Point(8, 92);
            this.tb_endereco.Name = "tb_endereco";
            this.tb_endereco.Size = new System.Drawing.Size(779, 21);
            this.tb_endereco.TabIndex = 2;
            // 
            // lb_nome_completo
            // 
            this.lb_nome_completo.AutoSize = true;
            this.lb_nome_completo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome_completo.Location = new System.Drawing.Point(8, 37);
            this.lb_nome_completo.Name = "lb_nome_completo";
            this.lb_nome_completo.Size = new System.Drawing.Size(114, 13);
            this.lb_nome_completo.TabIndex = 1;
            this.lb_nome_completo.Text = "NOME COMPLETO";
            // 
            // tb_nome
            // 
            this.tb_nome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nome.Location = new System.Drawing.Point(8, 53);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(780, 21);
            this.tb_nome.TabIndex = 0;
            // 
            // gb_cadastraUser
            // 
            this.gb_cadastraUser.BackColor = System.Drawing.Color.Transparent;
            this.gb_cadastraUser.Controls.Add(this.lb_anos);
            this.gb_cadastraUser.Controls.Add(this.dt_nascimento);
            this.gb_cadastraUser.Controls.Add(this.tb_documento);
            this.gb_cadastraUser.Controls.Add(this.label1);
            this.gb_cadastraUser.Controls.Add(this.cb_documento);
            this.gb_cadastraUser.Controls.Add(this.lb_email);
            this.gb_cadastraUser.Controls.Add(this.tb_email);
            this.gb_cadastraUser.Controls.Add(this.lb_endereco);
            this.gb_cadastraUser.Controls.Add(this.lb_codigo);
            this.gb_cadastraUser.Controls.Add(this.label6);
            this.gb_cadastraUser.Controls.Add(this.lb_telefone);
            this.gb_cadastraUser.Controls.Add(this.tb_telefone);
            this.gb_cadastraUser.Controls.Add(this.lb_nascimento);
            this.gb_cadastraUser.Controls.Add(this.lb_editora);
            this.gb_cadastraUser.Controls.Add(this.lb_documento);
            this.gb_cadastraUser.Controls.Add(this.tb_endereco);
            this.gb_cadastraUser.Controls.Add(this.lb_nome_completo);
            this.gb_cadastraUser.Controls.Add(this.tb_nome);
            this.gb_cadastraUser.Location = new System.Drawing.Point(13, 28);
            this.gb_cadastraUser.Name = "gb_cadastraUser";
            this.gb_cadastraUser.Size = new System.Drawing.Size(801, 230);
            this.gb_cadastraUser.TabIndex = 3;
            this.gb_cadastraUser.TabStop = false;
            // 
            // dt_nascimento
            // 
            this.dt_nascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_nascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_nascimento.Location = new System.Drawing.Point(354, 144);
            this.dt_nascimento.MaxDate = new System.DateTime(2150, 12, 31, 0, 0, 0, 0);
            this.dt_nascimento.MinDate = new System.DateTime(1935, 1, 1, 0, 0, 0, 0);
            this.dt_nascimento.Name = "dt_nascimento";
            this.dt_nascimento.Size = new System.Drawing.Size(120, 21);
            this.dt_nascimento.TabIndex = 5;
            this.dt_nascimento.ValueChanged += new System.EventHandler(this.dt_nascimento_ValueChanged);
            // 
            // tb_documento
            // 
            this.tb_documento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_documento.Location = new System.Drawing.Point(153, 144);
            this.tb_documento.Name = "tb_documento";
            this.tb_documento.Size = new System.Drawing.Size(195, 21);
            this.tb_documento.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "-";
            // 
            // cb_documento
            // 
            this.cb_documento.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cb_documento.AutoCompleteCustomSource.AddRange(new string[] {
            "CPF",
            "RG",
            "CNH",
            "CNPJ",
            "PASSAPORTE"});
            this.cb_documento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cb_documento.BackColor = System.Drawing.Color.White;
            this.cb_documento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_documento.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_documento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_documento.FormattingEnabled = true;
            this.cb_documento.Items.AddRange(new object[] {
            "CPF",
            "RG",
            "CNH",
            "CNPJ",
            "PASSAPORTE"});
            this.cb_documento.Location = new System.Drawing.Point(8, 143);
            this.cb_documento.Name = "cb_documento";
            this.cb_documento.Size = new System.Drawing.Size(121, 23);
            this.cb_documento.TabIndex = 3;
            this.cb_documento.SelectedIndexChanged += new System.EventHandler(this.cb_documento_SelectedIndexChanged);
            this.cb_documento.TextChanged += new System.EventHandler(this.cb_documento_TextChanged);
            // 
            // lb_anos
            // 
            this.lb_anos.AccessibleDescription = "Apenas considera o ANO de nascimento.";
            this.lb_anos.AutoSize = true;
            this.lb_anos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_anos.Location = new System.Drawing.Point(421, 128);
            this.lb_anos.Name = "lb_anos";
            this.lb_anos.Size = new System.Drawing.Size(53, 13);
            this.lb_anos.TabIndex = 27;
            this.lb_anos.Text = "00 Anos";
            this.lb_anos.Click += new System.EventHandler(this.lb_anos_Click);
            // 
            // CadastraUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::AmigoDePapel.Properties.Resources.wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(826, 420);
            this.Controls.Add(this.gb_observacao);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gb_cadastraUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "CadastraUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de usuario";
            this.gb_observacao.ResumeLayout(false);
            this.gb_observacao.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gb_cadastraUser.ResumeLayout(false);
            this.gb_cadastraUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_observacao;
        private System.Windows.Forms.Label lb_oservacao;
        private System.Windows.Forms.TextBox tb_obs;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label lb_endereco;
        private System.Windows.Forms.Label lb_codigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_save;
        private System.Windows.Forms.ToolStripButton tsb_retirar;
        private System.Windows.Forms.ToolStripButton tsb_ajuda;
        private System.Windows.Forms.TextBox tb_telefone;
        private System.Windows.Forms.Label lb_telefone;
        private System.Windows.Forms.Label lb_nascimento;
        private System.Windows.Forms.Label lb_editora;
        private System.Windows.Forms.Label lb_documento;
        private System.Windows.Forms.TextBox tb_endereco;
        private System.Windows.Forms.Label lb_nome_completo;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.GroupBox gb_cadastraUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_documento;
        private System.Windows.Forms.MaskedTextBox tb_documento;
        private System.Windows.Forms.DateTimePicker dt_nascimento;
        private System.Windows.Forms.Label lb_anos;
    }
}