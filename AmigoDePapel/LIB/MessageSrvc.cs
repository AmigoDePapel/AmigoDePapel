using System;
using System.IO;
using System.Windows.Forms;

namespace AmigoDePapel.LIB
{
    class MessageSrvc
    {
        private bool CreateLog()
        {
            if (!File.Exists(Application.StartupPath + ConstantADP.fileLog))
            {
                try
                {
                    File.Create(Application.StartupPath + ConstantADP.fileLog).Close();
                    return true;
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                    return false;
                }
            }
            else
                return true;
        }

        public void InsertLog(string text)
        {
            if (CreateLog())
            {
                File.AppendAllText(Application.StartupPath + ConstantADP.fileLog,
                                   Environment.NewLine + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss") + "-> " + text + ".");
            }
        }

        public void Alerta(string text, string title)
        {
            if (string.IsNullOrEmpty(title))
            {
                title = "Atenção";
            }
            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            InsertLog(text);
        }

        public void Sucesso(string text)
        {
            MessageBox.Show(text, "Sucesso.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            InsertLog(text);
        }

        public void Erro(string text, string title, Exception err)
        {
            if (string.IsNullOrEmpty(title))
            {
                title = "Erro.";
            }
            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            InsertLog("ERRO: "+text);
            InsertLog(err.Message);
            InsertLog(err.ToString());
        }
    }
}
