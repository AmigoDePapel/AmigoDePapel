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
            this.gb_manutencao = new System.Windows.Forms.GroupBox();
            this.gb_confg = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_lupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_help)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_fechar)).BeginInit();
            this.gb_manutencao.SuspendLayout();
            this.gb_confg.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "DIAS DE EMPRESTIMO PADRÃO";
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
            this.cb_dias.Location = new System.Drawing.Point(6, 32);
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
            this.pb_save.Location = new System.Drawing.Point(439, 12);
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
            this.pb_help.Location = new System.Drawing.Point(671, 12);
            this.pb_help.Name = "pb_help";
            this.pb_help.Size = new System.Drawing.Size(16, 16);
            this.pb_help.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_help.TabIndex = 9;
            this.pb_help.TabStop = false;
            // 
            // pb_fechar
            // 
            this.pb_fechar.Image = global::AmigoDePapel.Properties.Resources.cancel;
            this.pb_fechar.Location = new System.Drawing.Point(693, 12);
            this.pb_fechar.Name = "pb_fechar";
            this.pb_fechar.Size = new System.Drawing.Size(16, 16);
            this.pb_fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_fechar.TabIndex = 10;
            this.pb_fechar.TabStop = false;
            this.pb_fechar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bt_newDB
            // 
            this.bt_newDB.Location = new System.Drawing.Point(6, 71);
            this.bt_newDB.Name = "bt_newDB";
            this.bt_newDB.Size = new System.Drawing.Size(129, 23);
            this.bt_newDB.TabIndex = 11;
            this.bt_newDB.Text = "Criar uma nova base";
            this.bt_newDB.UseVisualStyleBackColor = true;
            this.bt_newDB.Click += new System.EventHandler(this.bt_newDB_Click);
            // 
            // bt_validate
            // 
            this.bt_validate.Location = new System.Drawing.Point(6, 60);
            this.bt_validate.Name = "bt_validate";
            this.bt_validate.Size = new System.Drawing.Size(258, 23);
            this.bt_validate.TabIndex = 12;
            this.bt_validate.Text = "Validar configurações atuais";
            this.bt_validate.UseVisualStyleBackColor = true;
            this.bt_validate.Click += new System.EventHandler(this.bt_validate_Click);
            // 
            // gb_manutencao
            // 
            this.gb_manutencao.Controls.Add(this.button6);
            this.gb_manutencao.Controls.Add(this.bt_validate);
            this.gb_manutencao.Location = new System.Drawing.Point(439, 34);
            this.gb_manutencao.Name = "gb_manutencao";
            this.gb_manutencao.Size = new System.Drawing.Size(270, 105);
            this.gb_manutencao.TabIndex = 14;
            this.gb_manutencao.TabStop = false;
            this.gb_manutencao.Text = "Manutenção";
            // 
            // gb_confg
            // 
            this.gb_confg.Controls.Add(this.button7);
            this.gb_confg.Controls.Add(this.tx_urlDB);
            this.gb_confg.Controls.Add(this.bt_newDB);
            this.gb_confg.Controls.Add(this.lb_titulo);
            this.gb_confg.Controls.Add(this.pb_lupa);
            this.gb_confg.Location = new System.Drawing.Point(15, 12);
            this.gb_confg.Name = "gb_confg";
            this.gb_confg.Size = new System.Drawing.Size(416, 105);
            this.gb_confg.TabIndex = 15;
            this.gb_confg.TabStop = false;
            this.gb_confg.Text = "Banco de dados";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.cb_dias);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 92);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Emprestimos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(15, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 113);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Livros";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
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
            this.comboBox1.Location = new System.Drawing.Point(15, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(258, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "GERAÇÃO DE IDS";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cadastro de SubTemas";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(305, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cadastro de tipos";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(305, 48);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Cadastro de temas";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 77);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Restaurar exclusões";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 63);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "Restaurar exclusões";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 33);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(258, 23);
            this.button6.TabIndex = 13;
            this.button6.Text = "Excluir Logs";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(141, 71);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(129, 23);
            this.button7.TabIndex = 12;
            this.button7.Text = "Trocar senha mestre";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(129, 63);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(161, 23);
            this.button8.TabIndex = 15;
            this.button8.Text = "Definir campos obrigatorios";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(138, 77);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(152, 23);
            this.button9.TabIndex = 16;
            this.button9.Text = "Definir campos obrigatorios";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button10);
            this.groupBox3.Controls.Add(this.button11);
            this.groupBox3.Location = new System.Drawing.Point(439, 145);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(270, 189);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Usuarios";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(6, 19);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(161, 23);
            this.button10.TabIndex = 15;
            this.button10.Text = "Definir campos obrigatorios";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(6, 47);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(161, 23);
            this.button11.TabIndex = 14;
            this.button11.Text = "Restaurar exclusões";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // Configuracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(721, 341);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox gb_manutencao;
        private System.Windows.Forms.GroupBox gb_confg;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
    }
}