using System;
using System.IO;
using System.Windows.Forms;

namespace AmigoDePapel.CLASS
{
    class ValidaInicializacao
    {
        public string url = System.Environment.CurrentDirectory.ToString();
        public string txt = "\\config.adpc";

        private void CriaPastas()
        {
            System.IO.Directory.CreateDirectory(url + @"\img");
            System.IO.Directory.CreateDirectory(url + @"\img\capa");
            System.IO.Directory.CreateDirectory(url + @"\img\user");
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
             if(
                DialogResult.Yes ==
                MessageBox.Show("Não encontramos a base de dados, deseja selecionar uma existente? ", 
                                "Encontre a base!", 
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Asterisk)
               )
                {
                    // pegar o caminho da base
                    // salvar no arquivo, utilizando a msm função do confg
                    // reinicia o programa
                    // caso não encontre a base gerar alertar que é preciso gerar uma nova base nas configurações do programa 
                    // abrir as configurações do programa 
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
                MessageBox.Show(err.Message);
            }
        }

        public void AtualizaTXT(string db, string date)
        {
            if (date == null)
                date = "05";
            string[] lines = { "DB="+db, "DATE="+date };
            System.IO.File.WriteAllLines(url+txt, lines);
        }

        public string[] GetConteudoTXT()
        {
            string[] conteudoBruto = System.IO.File.ReadAllLines(url+txt), 
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
