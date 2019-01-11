using System;
using AmigoDePapel.CLASS.conSql;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace AmigoDePapel.FORMS
{
    public partial class CadastraUser : Form
    {
        SqlQuery querys = new SqlQuery();

        public CadastraUser()
        {
            InitializeComponent();
        }

        public CadastraUser(string id)
        {
            InitializeComponent();

            try
            {

                Connection sqlExecut = new Connection();
                SqlCeDataReader dr = sqlExecut.ReturnQuery(querys.sql_selectCadastro_user+id);

                if (dr.Read())
                {
                    lb_codigo.Text = String.Concat(dr.GetInt32(0), "");
                    tb_nome.Text = dr.GetString(1);
                    dt_nascimento.Text = String.Concat(dr.GetString(2),"");
                    tb_endereco.Text = dr.GetString(3);
                    tb_telefone.Text = dr.GetString(4);
                    tb_email.Text = dr.GetString(5);
                    cb_documento.Text = dr.GetString(6);
                    tb_documento.Text = dr.GetString(7);
                    tb_obs.Text = dr.GetString(8);
                }
                dr.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "PUTS!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private string ValidacoesBasicas()
        {
            string erroMsg = null;
            if (String.IsNullOrEmpty(tb_nome.Text))
            {
                erroMsg = "* O campo 'NOME' é obrigatório. \n";
            }
            if (String.IsNullOrEmpty(tb_endereco.Text))
            {
                erroMsg += " * O campo 'ENDEREÇO' é obrigatório.\n";
            }
            if (String.IsNullOrEmpty(tb_documento.Text))
            {
                erroMsg += " * O campo 'DOCUMENTO' é obrigatório.\n";
            }
            return erroMsg;
        }

        private void tsb_save_Click_1(object sender, EventArgs e)
        {

            string erroMsg = ValidacoesBasicas();
            if (!String.IsNullOrEmpty(erroMsg))
            {
                MessageBox.Show(erroMsg, "Opa!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
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
            else if (cb_documento.Text == "CNPJ")
            {
                tb_documento.Mask = "##.###.###/####-##";
            }
            else
            {
                tb_documento.Mask = null;
            }
        }

        private void cb_documento_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_documento.Text = String.Empty;
        }

        private void tsb_retirar_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Deseja realmente excluir esse cadastro?", "Olha la!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dr == DialogResult.Yes)
            {
                Connection con = new Connection();
                con.LoadQuery(querys.sql_deleteLogico_crm_cliente + lb_codigo.Text);
                this.Close();
            }
        }

        private void dt_nascimento_ValueChanged(object sender, EventArgs e)
        {
            //Preciso voltar aqui e melhorar, ficou horrivel essa abordagem. - Lucas Vinicius
            DateTime atual = DateTime.Now;
            lb_anos.Text = (Int32.Parse(atual.Year.ToString()) - Int32.Parse(dt_nascimento.Value.Year.ToString())) + " Anos";
        }
    }
}
