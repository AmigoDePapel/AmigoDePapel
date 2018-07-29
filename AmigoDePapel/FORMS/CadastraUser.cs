using System;
using AmigoDePapel.CLASS.conSql;
using System.Windows.Forms;

namespace AmigoDePapel.FORMS
{
    public partial class CadastraUser : Form
    {
        public CadastraUser()
        {
            InitializeComponent();
        }

        private void tsb_save_Click_1(object sender, EventArgs e)
        {
            //INICIA O SALVAMENTO DAS INFORMAÇÕES
            //SE O ID FOR 00 É UM NOVO REGISTRO, SE NÃO, É UMA ALTERAÇÃO
            string sql;
            if (lb_codigo.Text == "00")
            {

                sql = @"INSERT INTO CRM_CLIENTE (ISDELETED,NOME,NASCIMENTO,ENDERECO,TELEFONE, EMAIL, DOCUMENTO_TIPO,DOCUMENTO,OBSERVACAO)
                                   VALUES (0,'" + tb_nome.Text + "', '" + dt_nascimento.Text + "','" + tb_endereco.Text + "', '" + tb_telefone.Text + "', '"+tb_email.Text+"', '" + cb_documento.Text + "', '" + tb_documento.Text + "', '" + tb_obs.Text + "')";
            }
            else
            {
                //ID EXISTE, ENTÃO... UPDATE.
                sql = @"UPDATE CRM_CLIENTE SET NOME = '" + tb_nome.Text + "', NASCIMENTO = '" + dt_nascimento.Text + "', ENDERECO = '" + tb_endereco.Text + "', TELEFONE = '" + tb_telefone.Text + "', DOCUMENTO_TIPO = '" + cb_documento.Text + "', DOCUMENTO = '" + tb_documento.Text + "', OBSERVACAO = '" + tb_obs.Text + "' WHERE ID = '" + lb_codigo.Text + "' and isdeleted = 0";

            }
            try
            {
                Connection sqlExecut = new Connection();
                sqlExecut.LoadQuery(sql);
                this.Close();
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, "PUTS!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cb_documento_TextChanged(object sender, EventArgs e)
        {
            if(cb_documento.Text == "CPF")
            {
                tb_documento.Mask = "###.###.###-##";
            }
            else if(cb_documento.Text == "RG")
            {
                tb_documento.Mask = "##.###.###-#";
            }
            else if(cb_documento.Text == "CNH")
            {
                tb_documento.Mask = null;
            }
            else if (cb_documento.Text == "CNPJ")
            {
                tb_documento.Mask = "##.###.###/####-##";
            }
            else
            {
                tb_documento.Mask = null;
            }
        }
    }
}
