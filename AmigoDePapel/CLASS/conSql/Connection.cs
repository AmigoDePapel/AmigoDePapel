using System;
using System.Data.SqlServerCe;
using System.IO;
using System.Windows.Forms;

namespace AmigoDePapel.CLASS.conSql
{
    class Connection
    {
        public string urlCon = "Data Source=" +
                            Application.StartupPath +
                            @"\DB_AMIGODEPAPEL.sdf";

        public void CreateDB()
        {
            try
            {
                if (!File.Exists(Application.StartupPath + @"\DB_AMIGODEPAPEL.sdf"))
                {
                    SqlCeEngine eng = new SqlCeEngine(urlCon);
                    eng.CreateDatabase();
                    CreateTables();
                    MessageBox.Show("Nova base de dados criada com sucesso.  Seu aplicativo irá reinicializar. \n LOCAL:"+ Application.StartupPath, "OBA!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    System.Diagnostics.Process.Start(Application.StartupPath+ @"\AmigoDePapel.exe");
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Já existe uma base criada na pasta raiz. \n LOCAL:" + Application.StartupPath, "CALMA!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
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
                MessageBox.Show(err.Message);
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
                MessageBox.Show(err.Message);
            }
        }

        public SqlCeDataReader ReturnQuery(string sqlExecut)
        {
                SqlCeConnection con = OpenCon();
                SqlCeCommand sql = new SqlCeCommand(sqlExecut, con);
                SqlCeDataReader dr = sql.ExecuteReader();
            return dr; 
        }
    }
}
