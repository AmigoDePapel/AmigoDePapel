using System.IO;

namespace AmigoDePapel.CLASS
{
    class ValidaInicializacao
    {
        public string[] VerifinicaInicializacao()
        {
            //verifica se o arquivo esta apontando para a planilha correta;
            //variaveis que serão utitilizadas na validação;
            string url = System.Environment.CurrentDirectory.ToString();
            string txt = url + "\\config.adpc";
            string[] conteudoTXT; 

            ValidaTXT(url, txt);
            conteudoTXT = getConteudoTXT(txt);
            ValidaDB(conteudoTXT[0]);

            return conteudoTXT;
        }
        //manipula o arquivo de configuração
        private void CriaAruivoTXT(string url)
        {
            string arquivo = "config.adpc";
            StreamWriter writer = new StreamWriter(url + "/" + arquivo);

            writer.WriteLine("DB=" + url+ "\\amigoDePapel.xls");
            writer.WriteLine("PASS=");
            writer.WriteLine("LOG=FALSE");
            writer.Close();
        }

        public void AtualizaTXT(string db, string pass, bool log)
        {

        }

        private string[] getConteudoTXT(string txt)
        {
            string[] conteudoBruto = System.IO.File.ReadAllLines(txt);
            string[] conteudo = new string[3];
            int i = 0;
            foreach (string line in conteudoBruto)
            {
                conteudo[i] = line.Replace("DB=", "").Replace("PASS=", "").Replace("LOG=", "");
                i++;
            }
            return conteudo;
        }

        private void ValidaTXT(string url, string txt)
        {
            if (!File.Exists(txt))
                CriaAruivoTXT(url);
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
