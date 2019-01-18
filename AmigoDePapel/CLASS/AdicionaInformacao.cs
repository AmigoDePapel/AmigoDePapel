using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigoDePapel.CLASS
{
    class AdicionaInformacao
    {

        public string GeraCod(string tema, string subTema)
        {
            Random r = new Random();

            int valor = r.Next(1, 999);
            int sumTema = tema.GetHashCode().ToString().Sum(c => c - '0');
            int sumSubTema = subTema.GetHashCode().ToString().Sum(c => c - '1');

            string codigoGerado = "00-" + valor + "/"+ sumSubTema + sumTema;
            
            return codigoGerado; 
        }
    }
}
