using AmigoDePapel.LIB;
using System;
using System.Data.SqlServerCe;
using System.IO;
using System.Windows.Forms;

namespace AmigoDePapel.CLASS.conSql
{
    class Connection
    {
        //variaveis globais 
        public static string urlCon = "Data Source=" +
                            Application.StartupPath +
                            ConstantADP.fileBase;

        //instanciamentos globais 
        ValidaInicializacao valid = new ValidaInicializacao();
        MessageSrvc msg = new MessageSrvc();

        public void CreateDB()
        {
            try
            {
                if (!File.Exists(Application.StartupPath + ConstantADP.fileBase))
                {
                    SqlCeEngine eng = new SqlCeEngine(urlCon);
                    eng.CreateDatabase();
                    CreateTables();

                    MessageBox.Show("Nova base de dados foi criada e selecionada com sucesso. Seu aplicativo irá reinicializar. "+
                                    "\n LOCAL DA BASE: "+ Application.StartupPath, 
                                    "Oba!", 
                                    MessageBoxButtons.OK, 
                                    MessageBoxIcon.Information);

                    valid.AtualizaTXT(Application.StartupPath + ConstantADP.fileBase, "05");
                    System.Diagnostics.Process.Start(Application.StartupPath+ @"\AmigoDePapel.exe");
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Já existe uma base criada na pasta raiz. \n LOCAL:" + Application.StartupPath,
                                    "Calma!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, 
                                "Puts!", 
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
        public SqlCeConnection OpenCon()
        {
            SqlCeConnection con = new SqlCeConnection(urlCon);
            con.Open();
            return con;
        }
        private void CreateTables()
        {
            try
            {
                SqlQuery query = new SqlQuery();
                SqlCeConnection con = OpenCon();

                //create stk_item_livro
                SqlCeCommand sql = new SqlCeCommand(query.sql_create_stk_item_livro, con);
                sql.ExecuteNonQuery();
                sql = new SqlCeCommand(query.sql_create_unique_stk_item_livro, con);
                sql.ExecuteNonQuery();

                //create crm_cliente
                sql = new SqlCeCommand(query.sql_create_crm_cliente, con);
                sql.ExecuteNonQuery();
                sql = new SqlCeCommand(query.sql_create_unique_crm_cliente, con);
                sql.ExecuteNonQuery();

                //create pvd_emprestimos
                sql = new SqlCeCommand(query.sql_create_pvd_emprestimos, con);
                sql.ExecuteNonQuery();

                con.Close();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LoadQuery(string sqlExecut)
        {
            try
            {
                SqlCeConnection con = OpenCon();
                SqlCeCommand sql = new SqlCeCommand(sqlExecut, con);
                sql.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception err)
            {
                msg.Erro("Não foi possivel realizar a operação no banco de dados.", "Erro", err);
            }
        }
        public string FormatQuery(string sql)
        {
            /* verifica se está vazio, em caso de retorno null faça a tratativa na chamada. 
             verifica se tem aspas simples.
             remove os espaços no começo e fim. */

            if (String.IsNullOrEmpty(sql))
                return null;

            sql = sql.Replace("'", "");
            sql = sql.Trim();

            return sql;
        }
        public SqlCeDataReader ReturnQuery(string sqlExecut)
        {
            try
            {
                SqlCeConnection con = OpenCon();
                SqlCeCommand sql = new SqlCeCommand(sqlExecut, con);
                SqlCeDataReader dr = sql.ExecuteReader();

                return dr;
            }
            catch(Exception err)
            {
                SqlCeDataReader dr = null;
                MessageBox.Show(err.Message,
                                "Erro!", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);

                return dr;
            }
        }
    }
}