using System;
using System.IO;


namespace AmigoDePapel.CLASS
{
    class ControleArquivo
    {

        public bool SalvaImagem(string url, string nome)
        {
            string urlNovo = System.Environment.CurrentDirectory.ToString() + @"\img\capa\" + nome + ".jpg";
            try
            {
            if (File.Exists(urlNovo))
            {
                DeletaArquivo(url);
                File.Move(url, urlNovo);
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

        public bool DeletaArquivo(string url)
        {
            try
            { 
                if(File.Exists(url))
                {
                    File.Delete(url);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception err)
            {

                return false;
            }

        }
    }
}
