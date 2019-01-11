using System.IO;


namespace AmigoDePapel.CLASS
{
    class ControleArquivo
    {

        public bool ImgExist(string nome)
        {
            if (File.Exists(GetUrl(nome)))
                return true;
            else
                return false;
        }

        public bool SalvaImagem(string url, string nome)
        {
            string urlNovo = GetUrl(nome);
            try
            {
                if (File.Exists(urlNovo))
                {
                    if (DeletaArquivo(nome)) {
                        File.Copy(url, urlNovo);
                        return true;
                    }
                    else return false;
                }
                else return false;
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
                if(File.Exists(GetUrl(nome)))
                {
                    File.Delete(GetUrl(nome));
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

        public string GetUrl(string nome)
        {
            return System.Environment.CurrentDirectory.ToString() + @"\img\capa\" + nome + ".jpg";
        }
    }
}
