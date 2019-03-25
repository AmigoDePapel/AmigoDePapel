using System;
using AmigoDePapel.CLASS.conSql;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using AmigoDePapel.CLASS;
using System.Drawing;

namespace AmigoDePapel.FORMS
{
    public partial class CadastraLivro : Form
    {
        public string urlImg = string.Empty;

        ControleArquivo ctrlImg = new ControleArquivo();
        SqlQuery querys = new SqlQuery();

        public CadastraLivro()
        {
            InitializeComponent();
        }

        public CadastraLivro(string codigo)
        {
            InitializeComponent();

            try
            {
                Connection sqlExecut = new Connection();

                //colocar esse select na classe consql e utilizar interpolação pra adicionar o valor no codigo.
                SqlCeDataReader dr = sqlExecut.ReturnQuery(@"SELECT 
                                                                    ID,
                                                                    TITULO, 
                                                                    SUBTITULO,
                                                                    ISBN,
                                                                    EDITORA,
                                                                    VERSAO,
                                                                    ANO,
                                                                    AUTOR,
                                                                    TEMA,
                                                                    SUBTEMA,
                                                                    PAGINAS,
                                                                    OBSERVACAO 
                                                               FROM STK_ITEM_LIVRO 
                                                               WHERE ID = " + codigo +
                                                               "AND ISDELETED = 0");

                if (dr.Read())
                {
                    lb_codigo.Text = String.Concat(dr.GetInt32(0),"");
                    tb_titulo.Text = dr.GetString(1);
                    tb_subtitulo.Text = dr.GetString(2);
                    tb_isbn.Text = dr.GetString(3);
                    tb_editora.Text = dr.GetString(4);
                    tb_versao.Text = dr.GetString(5);
                    tb_ano.Text = String.Concat(dr.GetInt32(6), "");
                    tb_autor.Text = dr.GetString(7);
                    cb_tema.Text = dr.GetString(8);
                    cb_subtema.Text = dr.GetString(9);
                    tb_pagina.Text = String.Concat(dr.GetInt32(10), "");
                    tb_obs.Text = dr.GetString(11);
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, "Caraca!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            ValidacoesBasicas();
        }

        private string ValidaSalvamento()
        {
            string alerta = String.Empty;

            if (String.IsNullOrEmpty(tb_titulo.Text))
            {
                alerta = "* O campo 'TÍTULO' é obrigatório. \n";
            }
            if (String.IsNullOrEmpty(tb_autor.Text))
            {
                alerta += "* O campo 'AUTOR' é obrigatório. \n";
            }
            if (String.IsNullOrEmpty(cb_tema.Text))
            {
                alerta += "* O campo 'TEMA' é obrigatório. \n";
            }
            if (!int.TryParse(tb_ano.Text, out int m) && !String.IsNullOrEmpty(tb_ano.Text))
            {
                alerta += "* O campo 'ANO' aceita apenas números. \n";
            }
            if(!int.TryParse(tb_pagina.Text, out int n) && !String.IsNullOrEmpty(tb_pagina.Text))
            {
                alerta += "* O campo 'QTD PÁGINAS' aceita apenas números.";
            }
            return alerta;
        }

        private void ValidacoesBasicas()
        {
            //VALIDAÇÕES BÁSICAS
            //se o código do itemm for 00 (cadastro novo) - desativar botão de retirada do sistema. 
            if (lb_codigo.Text != "00")
                tsb_retirar.Enabled = true;

            //se tiver imagem - libera o botão de deletar img.
            if (ctrlImg.ImgExist(lb_codigo.Text, "capa"))
            {
                tsb_deleteimg.Enabled = true;
                pb_livro.Image = Image.FromFile(ctrlImg.GetUrl(lb_codigo.Text, "capa"));
            }
                
        }

        private void tsb_retirar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o livro: '"+tb_titulo.Text+"'?",
                                "Exclusão!",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Connection con = new Connection();
                    con.LoadQuery(querys.sql_deleteLogico_stk_item_livro + lb_codigo.Text);
                    this.Close();
                }

                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Puts!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsb_save_Click(object sender, EventArgs e)
        {
            string alerta = ValidaSalvamento();

            if(alerta != String.Empty)
            {
                MessageBox.Show(alerta, "Opa!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            { 
                //INICIA O SALVAMENTO DAS INFORMAÇÕES
                //SE O ID FOR 00 É UM NOVO REGISTRO, SE NÃO, É UMA ALTERAÇÃO
                string sql = String.Empty;
                if(lb_codigo.Text == "00")
                {
                    sql = @"INSERT INTO STK_ITEM_LIVRO (ISDELETED,
                                                        TITULO,
                                                        SUBTITULO,
                                                        ISBN,
                                                        EDITORA,
                                                        VERSAO,
                                                        ANO,
                                                        AUTOR,
                                                        TEMA,
                                                        SUBTEMA,
                                                        PAGINAS,
                                                        OBSERVACAO)
                                             VALUES   (0,'"
                                                        + tb_titulo.Text + "','" 
                                                        + tb_subtitulo.Text + "','"
                                                        + tb_isbn.Text + "','"
                                                        + tb_editora.Text + "','"
                                                        + tb_versao.Text + "',"
                                                        + tb_ano.Text + ",'"
                                                        + tb_autor.Text + "','"
                                                        + cb_tema.Text + "','"
                                                        + cb_subtema.Text + "',"
                                                        + tb_pagina.Text + ",'"
                                                        + tb_obs.Text + "')";
                }
                else
                {
                    //ID EXISTE, ENTÃO... UPDATE.
                    sql = @"UPDATE STK_ITEM_LIVRO SET TITULO = '" + tb_titulo.Text + 
                                                      "', SUBTITULO = '"+tb_subtitulo.Text+ 
                                                      "', ISBN = '"+tb_isbn.Text+ 
                                                      "', EDITORA = '"+tb_editora.Text+ 
                                                      "', VERSAO = '"+tb_versao.Text+ 
                                                      "', ANO = '"+tb_ano.Text+ 
                                                      "', AUTOR = '"+tb_autor.Text+ 
                                                      "', TEMA = '"+cb_tema.Text+ 
                                                      "', SUBTEMA = '"+cb_subtema.Text+ 
                                                      "', PAGINAS = '"+tb_pagina.Text+ 
                                                      "', OBSERVACAO = '"+tb_obs.Text+ 
                          "' WHERE ID = '" + lb_codigo.Text + 
                          "' AND ISDELETED = 0";

                }
                try
                {

                Connection sqlExecut = new Connection();
                sqlExecut.LoadQuery(sql);

                //SALVEI, AGORA FOI UM CADASTRO NOVO? E ELE SELECIONOU UMA IMG? 
                if (lb_codigo.Text == "00" && urlImg != null)
                {
                        SqlCeDataReader dr = sqlExecut.ReturnQuery("SELECT MAX(ID) FROM STK_ITEM_LIVRO");
                        if (dr.Read())
                        {
                            ctrlImg.SalvaImagem(urlImg, String.Concat(dr.GetInt32(0),""),"capa");
                        }
                }
                    this.Close();
                }

                catch(Exception err)
                {
                    MessageBox.Show(err.Message,"Erro!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void tsb_addimg_Click(object sender, EventArgs e)
        {
            if (lb_codigo.Text == "00")
            {
                MessageBox.Show("Salve o cadastro antes de selecionar uma imagem.", "Ops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (ofd_capa.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if (ctrlImg.SalvaImagem(ofd_capa.FileName.ToString(), lb_codigo.Text, "capa"))
                        {
                            tsb_deleteimg.Enabled = true;
                            MessageBox.Show("Foto salva com sucesso.", "Uau!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            pb_livro.Image = Image.FromFile(ctrlImg.GetUrl(lb_codigo.Text, "capa"));
                        }
                        else
                            MessageBox.Show("Algo deu errado em salvar sua foto.", "Ops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, "Caramba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void tsb_deleteimg_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja remover a capa selecionada para esse livro?", 
                                "Opa!",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                if(lb_codigo.Text == "00")
                {
                    urlImg = String.Empty;
                    tsb_deleteimg.Enabled = false;
                }
                else
                {
                    try
                    {
                        ctrlImg.DeletaArquivo(lb_codigo.Text,"capa");
                        tsb_deleteimg.Enabled = false;
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, "Caramba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void lb_oservacao_Click(object sender, EventArgs e)
        {
            AdicionaInformacao ai = new AdicionaInformacao();
            tb_titulo.Text = ai.GeraCod(cb_tema.Text, cb_subtema.Text);
        }
    }
}
