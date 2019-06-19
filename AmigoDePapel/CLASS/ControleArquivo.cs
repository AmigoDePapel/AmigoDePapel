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
        public bool ImgSave(string url, string nome, string tipo)
        {
            string urlNovo = GetUrl(nome,tipo);
            try
            {
                if(FileDel(nome, tipo))
                    File.Copy(url, urlNovo);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool FileDel(string nome, string tipo)
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
                    return true;
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
