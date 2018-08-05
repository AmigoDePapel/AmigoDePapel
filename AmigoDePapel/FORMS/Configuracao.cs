using System;
using System.Windows.Forms;
using AmigoDePapel.CLASS;
using AmigoDePapel.CLASS.conSql;

namespace AmigoDePapel.FORMS
{
    public partial class Configuracao : Form
    {
        ValidaInicializacao valid = new ValidaInicializacao();
        public Configuracao()
        {
            InitializeComponent();

            string[] conteudoTxt = valid.GetConteudoTXT();
            tx_urlDB.Text = conteudoTxt[0];
            cb_dias.Text = conteudoTxt[1];
        }

        private void pb_lupa_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            ofd_openDB.InitialDirectory = System.Environment.CurrentDirectory.ToString(); 
            dr = ofd_openDB.ShowDialog();
            if(DialogResult.OK == dr)
            {
                tx_urlDB.Text = ofd_openDB.FileName;
            }
        }

        private void pb_save_Click(object sender, EventArgs e)
        {
            if(tx_urlDB.Text == null)
            {
                MessageBox.Show("CUIDADO", "É obrigatorio selecionar uma base,");
            }
            else
            {
                valid.AtualizaTXT(tx_urlDB.Text, cb_dias.Text);
                MessageBox.Show("SUCESSO!!", "Configurações salvas com sucesso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_newDB_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Você está prestes a criar uma nova base \n deseja continuar?","ATENÇÃO.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(dr == DialogResult.Yes)
            {
                Connection con = new Connection();
                con.CreateDB();
                
            }
            this.Focus();
        }
    }
}
