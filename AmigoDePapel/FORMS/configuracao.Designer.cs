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
            ((System.ComponentModel.ISupportInitialize)(this.pb_lupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_help)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_fechar)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.Location = new System.Drawing.Point(12, 9);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(121, 13);
            this.lb_titulo.TabIndex = 3;
            this.lb_titulo.Text = "CAMINHO DA BASE";
            // 
            // tx_urlDB
            // 
            this.tx_urlDB.Location = new System.Drawing.Point(15, 25);
            this.tx_urlDB.Name = "tx_urlDB";
            this.tx_urlDB.Size = new System.Drawing.Size(384, 20);
            this.tx_urlDB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 61);
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
            this.cb_dias.Location = new System.Drawing.Point(15, 77);
            this.cb_dias.Name = "cb_dias";
            this.cb_dias.Size = new System.Drawing.Size(86, 21);
            this.cb_dias.TabIndex = 6;
            // 
            // pb_lupa
            // 
            this.pb_lupa.Image = global::AmigoDePapel.Properties.Resources.zoom;
            this.pb_lupa.Location = new System.Drawing.Point(405, 29);
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
            this.pb_save.Location = new System.Drawing.Point(371, 126);
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
            this.pb_help.Location = new System.Drawing.Point(393, 126);
            this.pb_help.Name = "pb_help";
            this.pb_help.Size = new System.Drawing.Size(16, 16);
            this.pb_help.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_help.TabIndex = 9;
            this.pb_help.TabStop = false;
            // 
            // pb_fechar
            // 
            this.pb_fechar.Image = global::AmigoDePapel.Properties.Resources.cancel;
            this.pb_fechar.Location = new System.Drawing.Point(415, 126);
            this.pb_fechar.Name = "pb_fechar";
            this.pb_fechar.Size = new System.Drawing.Size(16, 16);
            this.pb_fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_fechar.TabIndex = 10;
            this.pb_fechar.TabStop = false;
            this.pb_fechar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bt_newDB
            // 
            this.bt_newDB.Location = new System.Drawing.Point(15, 119);
            this.bt_newDB.Name = "bt_newDB";
            this.bt_newDB.Size = new System.Drawing.Size(129, 23);
            this.bt_newDB.TabIndex = 11;
            this.bt_newDB.Text = "Criar uma nova base";
            this.bt_newDB.UseVisualStyleBackColor = true;
            this.bt_newDB.Click += new System.EventHandler(this.bt_newDB_Click);
            // 
            // bt_validate
            // 
            this.bt_validate.Location = new System.Drawing.Point(150, 119);
            this.bt_validate.Name = "bt_validate";
            this.bt_validate.Size = new System.Drawing.Size(155, 23);
            this.bt_validate.TabIndex = 12;
            this.bt_validate.Text = "Validar configurações atuais";
            this.bt_validate.UseVisualStyleBackColor = true;
            // 
            // Configuracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 154);
            this.ControlBox = false;
            this.Controls.Add(this.bt_validate);
            this.Controls.Add(this.bt_newDB);
            this.Controls.Add(this.pb_fechar);
            this.Controls.Add(this.pb_help);
            this.Controls.Add(this.pb_save);
            this.Controls.Add(this.pb_lupa);
            this.Controls.Add(this.cb_dias);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_titulo);
            this.Controls.Add(this.tx_urlDB);
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
    }
}