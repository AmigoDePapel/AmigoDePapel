using AmigoDePapel.CLASS.conSql;
using System;
using System.Data;
using System.Data.SqlServerCe;
using System.Windows.Forms;

namespace AmigoDePapel.CLASS.load
{
    class LoadGDLivros
    {
        public DataTable DesenhaGridUser()
        {
            try
            {
                DataTable dt = new DataTable();

                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("NOME", typeof(string));
                dt.Columns.Add("ENDEREÇO", typeof(string));
                dt.Columns.Add("DOCUMENTO", typeof(string));
                dt.Columns.Add("NASCIMENTO", typeof(string));
                dt.Columns.Add("EMAIL", typeof(string));
                dt.Columns.Add("TELEFONE", typeof(string));

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

        public DataTable DesenhaGridLivro()
        {
            try
            {
                DataTable dt = new DataTable();

                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("ISBN ou EAN", typeof(string));
                dt.Columns.Add("TITULO", typeof(string));
                dt.Columns.Add("SUBTITULO", typeof(string));
                dt.Columns.Add("TEMA", typeof(string));
                dt.Columns.Add("SUBTEMA", typeof(string));
                dt.Columns.Add("AUTOR", typeof(string));
                dt.Columns.Add("EDITORA", typeof(string));
                dt.Columns.Add("VERSÃO", typeof(string));
                dt.Columns.Add("PÁGINAS", typeof(int));
                dt.Columns.Add("ANO", typeof(string));

                return dt; 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public DataTable PreencheGridLivro(DataTable dtLivros)
        {
            try
            {
                //CARREGA OS GRID
                Connection con = new Connection();
                SqlQuery query = new SqlQuery();
                SqlCeDataReader dr = con.ReturnQuery(query.sql_select_stk_item_livro);

                while (dr.Read())
                {
                    DataRow newLine = dtLivros.NewRow();
                    newLine["ID"] = dr["ID"];
                    newLine["TITULO"] = dr["TITULO"];
                    newLine["SUBTITULO"] = dr["SUBTITULO"];
                    newLine["ISBN ou EAN"] = dr["ISBN"];
                    newLine["EDITORA"] = dr["EDITORA"];
                    newLine["VERSÃO"] = dr["VERSAO"];
                    newLine["ANO"] = dr["ANO"];
                    newLine["AUTOR"] = dr["AUTOR"];
                    newLine["TEMA"] = dr["TEMA"];
                    newLine["SUBTEMA"] = dr["SUBTEMA"];
                    newLine["PÁGINAS"] = dr["PAGINAS"];
                    dtLivros.Rows.Add(newLine);
                }
                dr.Close();
                return dtLivros;
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            
        }

        public DataTable PreencheGridLivro(DataTable dtLivros, string  pesquisa)
        {
            try
            {
                //CARREGA OS GRID
                Connection con = new Connection();
                SqlQuery query = new SqlQuery();
                //carrega a query de preenchimento de grid padrão
                string queryPesquisa = query.sql_select_stk_item_livro;
                //adiciona os where 
                queryPesquisa += " AND (ID LIKE '%" + pesquisa + "%'";
                queryPesquisa += " OR TITULO LIKE '%" + pesquisa + "%'";
                queryPesquisa += " OR SUBTITULO LIKE '%" + pesquisa + "%'";
                queryPesquisa += " OR ISBN LIKE '%" + pesquisa + "%'";
                queryPesquisa += " OR EDITORA LIKE '%" + pesquisa + "%'";
                queryPesquisa += " OR AUTOR LIKE '%" + pesquisa + "%'";
                queryPesquisa += " OR TEMA LIKE '%" + pesquisa + "%'";
                queryPesquisa += " OR SUBTEMA LIKE '%" + pesquisa + "%')";
                SqlCeDataReader dr = con.ReturnQuery(queryPesquisa);

                while (dr.Read())
                {
                    DataRow newLine = dtLivros.NewRow();
                    newLine["ID"] = dr["ID"];
                    newLine["TITULO"] = dr["TITULO"];
                    newLine["SUBTITULO"] = dr["SUBTITULO"];
                    newLine["ISBN ou EAN"] = dr["ISBN"];
                    newLine["EDITORA"] = dr["EDITORA"];
                    newLine["VERSÃO"] = dr["VERSAO"];
                    newLine["ANO"] = dr["ANO"];
                    newLine["AUTOR"] = dr["AUTOR"];
                    newLine["TEMA"] = dr["TEMA"];
                    newLine["SUBTEMA"] = dr["SUBTEMA"];
                    newLine["PÁGINAS"] = dr["PAGINAS"];
                    dtLivros.Rows.Add(newLine);
                }
                dr.Close();
                return dtLivros;
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

        public DataTable PreencheGridUser(DataTable dtUsers)
        {
            try
            {
                //CARREGA OS GRID
                Connection con = new Connection();
                SqlQuery query = new SqlQuery();
                SqlCeDataReader dr = con.ReturnQuery(query.sql_select_crm_cliente);

                while (dr.Read())
                {
                    DataRow newLine = dtUsers.NewRow();

                    newLine["ID"] = dr["ID"];
                    newLine["NOME"] = dr["NOME"];
                    newLine["ENDEREÇO"] = dr["ENDERECO"];
                    newLine["DOCUMENTO"] = dr["DOCUMENTO"];
                    newLine["NASCIMENTO"] = dr["NASCIMENTO"];
                    newLine["EMAIL"] = dr["EMAIL"];
                    newLine["TELEFONE"] = dr["TELEFONE"];
                    dtUsers.Rows.Add(newLine);
                }
                dr.Close();
                return dtUsers;
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; 
            }

        }
    }
}