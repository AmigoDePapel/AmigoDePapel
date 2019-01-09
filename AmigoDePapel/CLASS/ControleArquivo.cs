using System.IO;


namespace AmigoDePapel.CLASS
{
    class ControleArquivo
    {

        public bool ImgExist(string nome)
        {
            if (File.Exists(getUrl(nome)))
                return true;
            else
                return false;
        }

        public bool SalvaImagem(string url, string nome)
        {
            string urlNovo = getUrl(nome);
            try
            {
            if (File.Exists(urlNovo))
            {
                DeletaArquivo(nome);
                File.Copy(url, urlNovo);
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

        public bool DeletaArquivo(string nome)
        {
            try
            { 
                if(File.Exists(getUrl(nome)))
                {
                    File.Delete(getUrl(nome));
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

        public string getUrl(string nome)
        {
            return System.Environment.CurrentDirectory.ToString() + @"\img\capa\" + nome + ".jpg";
        }
    }
}
