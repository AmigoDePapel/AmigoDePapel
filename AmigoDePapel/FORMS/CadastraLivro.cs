using System;
using AmigoDePapel.CLASS.conSql;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlServerCe;
using AmigoDePapel.CLASS;

namespace AmigoDePapel.FORMS
{
    public partial class CadastraLivro : Form
    {
        public string urlImg = null;
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
                SqlCeDataReader dr = sqlExecut.ReturnQuery(@"SELECT ID, TITULO, SUBTITULO,ISBN,EDITORA,VERSAO,ANO,AUTOR,TEMA,SUBTEMA,PAGINAS,OBSERVACAO FROM STK_ITEM_LIVRO WHERE ID = " + codigo + " AND ISDELETED = 0");

                if (dr.Read())
                {
                    lb_codigo.Text = String.Concat(dr.GetInt32(0),"");
                    tb_titulo.Text = dr.GetString(1);
                    tb_subtitulo.Text = dr.GetString(2);
                    tb_isbn.Text = dr.GetString(3);
                    tb_editora.Text = dr.GetString(4);
                    tb_versao.Text = dr.GetString(5); ;
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
                MessageBox.Show(err.Message, "PUTS!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                alerta += "* O campo 'QTD PÁGINAS' aceita apenas números. \n";
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
            if (ctrlImg.ImgExist(lb_codigo.Text))
                tsb_deleteimg.Enabled = true;

        }

        private void tsb_retirar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir esse livro?",
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
                    MessageBox.Show(err.Message, "PUTS!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsb_save_Click(object sender, EventArgs e)
        {
            string alerta = ValidaSalvamento();

            if(alerta != String.Empty)
            {
                MessageBox.Show(alerta, "Opa!!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            { 
                //INICIA O SALVAMENTO DAS INFORMAÇÕES
                //SE O ID FOR 00 É UM NOVO REGISTRO, SE NÃO, É UMA ALTERAÇÃO
                string sql = String.Empty;
                if(lb_codigo.Text == "00")
                {
                    sql = @"INSERT INTO STK_ITEM_LIVRO (ISDELETED,TITULO,SUBTITULO,ISBN,EDITORA,VERSAO,ANO,AUTOR,TEMA,SUBTEMA,PAGINAS,OBSERVACAO)
                                        VALUES (0,'" + tb_titulo.Text + "','" + tb_subtitulo.Text + "','" + tb_isbn.Text + "','" + tb_editora.Text + "','" + tb_versao.Text + "'," + tb_ano.Text + ",'" + tb_autor.Text + "','" + cb_tema.Text + "','" + cb_subtema.Text + "'," + tb_pagina.Text + ",'" + tb_obs.Text + "')";
                }
                else
                {
                    //ID EXISTE, ENTÃO... UPDATE.
                    sql = @"UPDATE STK_ITEM_LIVRO SET TITULO = '" + tb_titulo.Text + "', SUBTITULO = '"+tb_subtitulo.Text+ "', ISBN = '"+tb_isbn.Text+ "', EDITORA = '"+tb_editora.Text+ "', VERSAO = '"+tb_versao.Text+ "', ANO = '"+tb_ano.Text+ "', AUTOR = '"+tb_autor.Text+ "', TEMA = '"+cb_tema.Text+ "', SUBTEMA = '"+cb_subtema.Text+ "', PAGINAS = '"+tb_pagina.Text+ "', OBSERVACAO = '"+tb_obs.Text+"' WHERE ID = '" + lb_codigo.Text + "' AND ISDELETED = 0";

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
                            ctrlImg.SalvaImagem(urlImg, String.Concat(dr.GetInt32(0),""));
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
            DialogResult dr = new DialogResult();
            dr = ofd_capa.ShowDialog();

            if(dr == DialogResult.OK)
            {
                try
                {
                    //se o codigo for 00 é um cadastro novo, então vou apenas guardar a url;
                    //se o codigo não for 00 é um cadastro já registrado no sistema então apenas mova com o codigo do cadastro;
                    if(lb_codigo.Text == "00")
                    {
                        urlImg = ofd_capa.FileName.ToString();
                        MessageBox.Show("A foto foi selecionada, é preciso salvar o cadastro para efetivar.", 
                                        "Precisa salvar!!", 
                                        MessageBoxButtons.OK, 
                                        MessageBoxIcon.Question);
                    }
                    else
                    {                       

                        ctrlImg.SalvaImagem(ofd_capa.FileName.ToString(), lb_codigo.Text);

                        string url = System.Environment.CurrentDirectory.ToString() + @"\img\capa\" + lb_codigo.Text + ".jpg";
                        if (File.Exists(url))
                            File.Delete(url);
                        File.Move(ofd_capa.FileName.ToString(), url);

                        MessageBox.Show("Foto salva com sucesso.", "Uau!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch(Exception err)
                {
                    MessageBox.Show(err.Message, "Caramba!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                tsb_deleteimg.Enabled = true;
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
                        ctrlImg.DeletaArquivo(lb_codigo.Text);
                        tsb_deleteimg.Enabled = false;
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, "Caramba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }

        }
    }
}
