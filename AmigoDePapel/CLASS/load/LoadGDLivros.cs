using System;
using System.Data;

namespace AmigoDePapel.CLASS.load
{
    class LoadGDLivros
    {
        public DataTable CarregaGridUser()
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
                return null;
            }

        }

        public DataTable CarregaGridLivro()
        {
            try
            {
                DataTable dt = new DataTable();

                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("TITULO", typeof(string));
                dt.Columns.Add("SUBTITULO", typeof(string));
                dt.Columns.Add("AUTOR", typeof(string));
                dt.Columns.Add("EAN", typeof(string));
                dt.Columns.Add("ISBN", typeof(string));
                dt.Columns.Add("EDITORA", typeof(string));
                dt.Columns.Add("EDIÇÃO", typeof(string));
                dt.Columns.Add("ANO", typeof(DateTime));
                dt.Columns.Add("PAGINAS", typeof(int));
                dt.Columns.Add("GENERO", typeof(string));
                dt.Columns.Add("SUBGENERO", typeof(string));

                /*
                DataRow dr = dt.NewRow();
                dr["Codigo"] = 1;
                dr["Nome"] = "Macoratti";
                dr["Admissao"] = DateTime.Now;
                dr["Setor"] = 20;
                dr["Salario"] = 15000;
                dt.Rows.Add(dr);
                dr = dt.NewRow();
                dr["Codigo"] = 2;
                dr["Nome"] = "Miriam";
                dr["Admissao"] = DateTime.Now;
                dr["Setor"] = 30;
                dr["Salario"] = 25000;
                dt.Rows.Add(dr);
                dr = dt.NewRow();
                dr["Codigo"] = 3;
                dr["Nome"] = "Jefferson";
                dr["Admissao"] = DateTime.Now;
                dr["Setor"] = 40;
                dr["Salario"] = 18000;
                dt.Rows.Add(dr);*/
                return dt; 
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
