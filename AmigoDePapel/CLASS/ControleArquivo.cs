using System.IO;


namespace AmigoDePapel.CLASS
{
    class ControleArquivo
    {

        public bool ImgExist(string nome, string tipo)
        {
            if (File.Exists(GetUrl(nome, tipo)))
                return true;
            else
                return false;
        }

        public bool SalvaImagem(string url, string nome, string tipo)
        {
            string urlNovo = GetUrl(nome,tipo);
            try
            {
                DeletaArquivo(nome, tipo);
                File.Copy(url, urlNovo);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeletaArquivo(string nome, string tipo)
        {
            try
            { 
                if(File.Exists(GetUrl(nome,tipo)))
                {
                    File.Delete(GetUrl(nome,tipo));
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public string GetUrl(string nome, string tipo)
        {
            return System.Environment.CurrentDirectory.ToString() + @"\img\"+tipo+@"\" + nome + ".jpg";
        }
    }
}
