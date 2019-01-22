using System;
using System.IO;
using System.Windows.Forms;
using AmigoDePapel.CLASS.conSql;

namespace AmigoDePapel.CLASS
{
    class ValidaInicializacao
    {
        //Variaveis_globais
        public static string url = Environment.CurrentDirectory.ToString();
        public const string txt = "\\config.adpc";

        //Metodos
        private void CriaPastas()
        {
            try
            {
                Directory.CreateDirectory(url + @"\img");
                Directory.CreateDirectory(url + @"\img\capa");
                Directory.CreateDirectory(url + @"\img\user");
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string[] VerifinicaInicializacao()
        {
            //verifica se o arquivo esta apontando para uma base correta;
            //variaveis que serão utitilizadas na validação;
            ValidaTXT();
            CriaPastas();
            
            string[] conteudoTXT = GetConteudoTXT();

            //verifica se a base existe, caso contrario pede o local
            if (ValidaDB(conteudoTXT[0]))
            {
             if(DialogResult.Yes ==
                MessageBox.Show("Não encontramos a base de dados, deseja selecionar uma existente? ", 
                                "Encontre a base!", 
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Asterisk))
                {
                    Connection con = new Connection();
                    con.CreateDB();
                }
            }
            return conteudoTXT;
        }

        //manipula o arquivo de configuração
        private void CriaAruivoTXT()
        {
            try
            {
                StreamWriter writer = new StreamWriter(url + txt);

                writer.WriteLine("DB=");
                writer.WriteLine("DATE=05");
                writer.Close();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AtualizaTXT(string db, string date)
        {
            string[] lines = { "DB="+db, "DATE="+ date != null? date: "05" };
            File.WriteAllLines(url+txt, lines);
        }

        public string[] GetConteudoTXT()
        {
            string[] conteudoBruto = System.IO.File.ReadAllLines(url + txt), 
                     conteudo = new string[3];
            int i = 0;
            foreach (string line in conteudoBruto)
            {
                conteudo[i] = line.Replace("DB=", "").Replace("DATE=", "");
                i++;
            }
            return conteudo;
        }

        //validações
        private void ValidaTXT()
        {
            if (!File.Exists(url+txt))
                CriaAruivoTXT();
        }

        private bool ValidaDB(string db)
        {
            if (!File.Exists(db))
                return true;
            else
                return false;
        }
    }
}
