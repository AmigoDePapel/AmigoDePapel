namespace AmigoDePapel.FORMS
{
    partial class Configuracao
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
            this.lb_titulo = new System.Windows.Forms.Label();
            this.tx_urlDB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_dias = new System.Windows.Forms.ComboBox();
            this.pb_lupa = new System.Windows.Forms.PictureBox();
            this.ofd_openDB = new System.Windows.Forms.OpenFileDialog();
            this.pb_save = new System.Windows.Forms.PictureBox();
            this.pb_help = new System.Windows.Forms.PictureBox();
            this.pb_fechar = new System.Windows.Forms.PictureBox();
            this.bt_newDB = new System.Windows.Forms.Button();
            this.bt_validate = new System.Windows.Forms.Button();
            this.bt_exclusoes = new System.Windows.Forms.Button();
            this.gb_manutencao = new System.Windows.Forms.GroupBox();
            this.gb_confg = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_lupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_help)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_fechar)).BeginInit();
            this.gb_manutencao.SuspendLayout();
            this.gb_confg.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.Location = new System.Drawing.Point(3, 29);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(121, 13);
            this.lb_titulo.TabIndex = 3;
            this.lb_titulo.Text = "CAMINHO DA BASE";
            // 
            // tx_urlDB
            // 
            this.tx_urlDB.Location = new System.Drawing.Point(6, 45);
            this.tx_urlDB.Name = "tx_urlDB";
            this.tx_urlDB.Size = new System.Drawing.Size(384, 20);
            this.tx_urlDB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "DIAS DE EMPRESTIMO";
            // 
            // cb_dias
            // 
            this.cb_dias.FormattingEnabled = true;
            this.cb_dias.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cb_dias.Location = new System.Drawing.Point(6, 97);
            this.cb_dias.Name = "cb_dias";
            this.cb_dias.Size = new System.Drawing.Size(86, 21);
            this.cb_dias.TabIndex = 6;
            // 
            // pb_lupa
            // 
            this.pb_lupa.Image = global::AmigoDePapel.Properties.Resources.zoom;
            this.pb_lupa.Location = new System.Drawing.Point(396, 47);
            this.pb_lupa.Name = "pb_lupa";
            this.pb_lupa.Size = new System.Drawing.Size(16, 16);
            this.pb_lupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_lupa.TabIndex = 7;
            this.pb_lupa.TabStop = false;
            this.pb_lupa.Click += new System.EventHandler(this.pb_lupa_Click);
            // 
            // ofd_openDB
            // 
            this.ofd_openDB.DefaultExt = "sdf";
            this.ofd_openDB.Filter = "DB_AMIGODEPAPEL.sdf |*.sdf";
            this.ofd_openDB.InitialDirectory = "C:\\";
            // 
            // pb_save
            // 
            this.pb_save.Image = global::AmigoDePapel.Properties.Resources.disk;
            this.pb_save.Location = new System.Drawing.Point(374, 241);
            this.pb_save.Name = "pb_save";
            this.pb_save.Size = new System.Drawing.Size(16, 16);
            this.pb_save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_save.TabIndex = 8;
            this.pb_save.TabStop = false;
            this.pb_save.Click += new System.EventHandler(this.pb_save_Click);
            // 
            // pb_help
            // 
            this.pb_help.Image = global::AmigoDePapel.Properties.Resources.help;
            this.pb_help.Location = new System.Drawing.Point(395, 241);
            this.pb_help.Name = "pb_help";
            this.pb_help.Size = new System.Drawing.Size(16, 16);
            this.pb_help.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_help.TabIndex = 9;
            this.pb_help.TabStop = false;
            // 
            // pb_fechar
            // 
            this.pb_fechar.Image = global::AmigoDePapel.Properties.Resources.cancel;
            this.pb_fechar.Location = new System.Drawing.Point(415, 241);
            this.pb_fechar.Name = "pb_fechar";
            this.pb_fechar.Size = new System.Drawing.Size(16, 16);
            this.pb_fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_fechar.TabIndex = 10;
            this.pb_fechar.TabStop = false;
            this.pb_fechar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bt_newDB
            // 
            this.bt_newDB.Location = new System.Drawing.Point(6, 20);
            this.bt_newDB.Name = "bt_newDB";
            this.bt_newDB.Size = new System.Drawing.Size(129, 23);
            this.bt_newDB.TabIndex = 11;
            this.bt_newDB.Text = "Criar uma nova base";
            this.bt_newDB.UseVisualStyleBackColor = true;
            this.bt_newDB.Click += new System.EventHandler(this.bt_newDB_Click);
            // 
            // bt_validate
            // 
            this.bt_validate.Location = new System.Drawing.Point(6, 49);
            this.bt_validate.Name = "bt_validate";
            this.bt_validate.Size = new System.Drawing.Size(252, 23);
            this.bt_validate.TabIndex = 12;
            this.bt_validate.Text = "Validar configurações atuais";
            this.bt_validate.UseVisualStyleBackColor = true;
            // 
            // bt_exclusoes
            // 
            this.bt_exclusoes.Location = new System.Drawing.Point(141, 20);
            this.bt_exclusoes.Name = "bt_exclusoes";
            this.bt_exclusoes.Size = new System.Drawing.Size(117, 23);
            this.bt_exclusoes.TabIndex = 13;
            this.bt_exclusoes.Text = "Restaurar exclusões";
            this.bt_exclusoes.UseVisualStyleBackColor = true;
            // 
            // gb_manutencao
            // 
            this.gb_manutencao.Controls.Add(this.bt_exclusoes);
            this.gb_manutencao.Controls.Add(this.bt_newDB);
            this.gb_manutencao.Controls.Add(this.bt_validate);
            this.gb_manutencao.Location = new System.Drawing.Point(15, 151);
            this.gb_manutencao.Name = "gb_manutencao";
            this.gb_manutencao.Size = new System.Drawing.Size(273, 84);
            this.gb_manutencao.TabIndex = 14;
            this.gb_manutencao.TabStop = false;
            this.gb_manutencao.Text = "Manutenção";
            // 
            // gb_confg
            // 
            this.gb_confg.Controls.Add(this.cb_dias);
            this.gb_confg.Controls.Add(this.tx_urlDB);
            this.gb_confg.Controls.Add(this.lb_titulo);
            this.gb_confg.Controls.Add(this.label1);
            this.gb_confg.Controls.Add(this.pb_lupa);
            this.gb_confg.Location = new System.Drawing.Point(15, 12);
            this.gb_confg.Name = "gb_confg";
            this.gb_confg.Size = new System.Drawing.Size(416, 133);
            this.gb_confg.TabIndex = 15;
            this.gb_confg.TabStop = false;
            this.gb_confg.Text = "Configurações";
            // 
            // Configuracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(443, 264);
            this.ControlBox = false;
            this.Controls.Add(this.gb_confg);
            this.Controls.Add(this.gb_manutencao);
            this.Controls.Add(this.pb_fechar);
            this.Controls.Add(this.pb_help);
            this.Controls.Add(this.pb_save);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Configuracao";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "configuracao";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pb_lupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_help)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_fechar)).EndInit();
            this.gb_manutencao.ResumeLayout(false);
            this.gb_confg.ResumeLayout(false);
            this.gb_confg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.TextBox tx_urlDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_dias;
        private System.Windows.Forms.PictureBox pb_lupa;
        private System.Windows.Forms.OpenFileDialog ofd_openDB;
        private System.Windows.Forms.PictureBox pb_save;
        private System.Windows.Forms.PictureBox pb_help;
        private System.Windows.Forms.PictureBox pb_fechar;
        private System.Windows.Forms.Button bt_newDB;
        private System.Windows.Forms.Button bt_validate;
        private System.Windows.Forms.Button bt_exclusoes;
        private System.Windows.Forms.GroupBox gb_manutencao;
        private System.Windows.Forms.GroupBox gb_confg;
    }
}