using System;
using System.Data;
using System.Windows.Forms;

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
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        public DataTable CarregaGridLivro()
        {
            try
            {
                DataTable dt = new DataTable();

                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("ISBN ou EAN", typeof(string));
                dt.Columns.Add("TITULO", typeof(string));
                dt.Columns.Add("SUBTITULO", typeof(string));
                dt.Columns.Add("GENERO", typeof(string));
                dt.Columns.Add("SUBGENERO", typeof(string));
                dt.Columns.Add("AUTOR", typeof(string));
                dt.Columns.Add("EDITORA", typeof(string));
                dt.Columns.Add("EDIÇÃO", typeof(string));
                dt.Columns.Add("PAGINAS", typeof(int));
                dt.Columns.Add("ANO", typeof(string));

                return dt; 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        
    }
}
