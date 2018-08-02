using System;
using AmigoDePapel.CLASS.conSql;
using System.Windows.Forms;


namespace AmigoDePapel.FORMS
{
    public partial class CadastraLivro : Form
    {
        public CadastraLivro()
        {
            InitializeComponent();
        }

        public CadastraLivro(string[] livro)
        {

            InitializeComponent();
        }

        private void tsb_retirar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deseja remover do sistema esse livro?","ATENÇÃO",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
        }

        private void CadastraLivro_Load(object sender, EventArgs e)
        {
            ValidacoesBasicas();
        }

        private void ValidacoesBasicas()
        {
            //VALIDAÇÕES BÁSICAS
            //se o código do itemm for 00 (cadastro novo) - desativar botão de retirada do sistema. 
            if (!lb_codigo.Text.Equals("00"))
                tsb_retirar.Enabled = true;
        }

        private void tsb_save_Click(object sender, EventArgs e)
        {
            //INICIA O SALVAMENTO DAS INFORMAÇÕES
            //SE O ID FOR 00 É UM NOVO REGISTRO, SE NÃO, É UMA ALTERAÇÃO
            string sql;
            if(lb_codigo.Text == "00")
            {
                sql = @"INSERT INTO STK_ITEM_LIVRO (ISDELETED,TITULO,SUBTITULO,ISBN,EDITORA,VERSAO,ANO,AUTOR,TEMA,SUBTEMA,PAGINAS,OBSERVACAO)
                                   VALUES (0,'" + tb_titulo.Text + "','" + tb_subtitulo.Text + "','" + tb_isbn.Text + "','" + tb_editora.Text + "','" + tb_versao.Text + "'," + tb_ano.Text + ",'" + tb_autor.Text + "','" + cb_tema.Text + "','" + cb_subtema.Text + "'," + tb_pagina.Text + ",'" + tb_obs.Text + "')";
            }
            else
            {
                //ID EXISTE, ENTÃO... UPDATE.
                sql = @"UPDATE STK_ITEM_LIVRO SET TITULO = '" + tb_titulo.Text + "', SUBTITULO = '"+tb_subtitulo.Text+ "', ISBN = '"+tb_isbn.Text+ "', EDITORA = '"+tb_editora.Text+ "', VERSAO = '"+tb_versao.Text+ "', ANO = '"+tb_ano.Text+ "', AUTOR = '"+tb_autor.Text+ "', TEMA = '"+cb_tema.Text+ "', SUBTEMA = '"+cb_subtema.Text+ "', PAGINAS = '"+tb_ano.Text+ "', OBSERVACAO = '"+tb_obs.Text+"' WHERE ID = '" + lb_codigo.Text + "' and isdeleted = 0";

            }
            try
            {


            Connection sqlExecut = new Connection();
            sqlExecut.LoadQuery(sql);
                this.Close();
            }

            catch(Exception err)
            {
                MessageBox.Show(err.Message,"PUTS!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
