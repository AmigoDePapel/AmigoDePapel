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
                    MessageBox.Show("Nova base de dados criada com sucesso.", "OBA!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void CreateTables()
        {
            try
            {
                SqlQuery query = new SqlQuery();
                SqlCeConnection con = new SqlCeConnection(urlCon);
                con.Open();

                //create stk_item_livro
                SqlCeCommand sql = new SqlCeCommand(query.sql_create_stk_item_livro, con);
                sql.ExecuteNonQuery();
                sql = new SqlCeCommand(query.sql_create_unique_stk_item_livro, con);
                sql.ExecuteNonQuery();

                con.Close();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
