using System;
using System.Linq;

namespace AmigoDePapel.CLASS
{
    class AdicionaInformacao
    {
        public string getNewID(string tema, string subTema)
        {
            int randomID,
                sumHashTema,
                sumSubHashTema;

            Random r = new Random();

            randomID        = r.Next(1, 999);
            sumHashTema     = tema.GetHashCode().ToString().Sum(c => c - '0');
            sumSubHashTema  = subTema.GetHashCode().ToString().Sum(c => c - '1');
          
            return "00-" + randomID + "/" + sumSubHashTema + sumHashTema; 
        }
    }
}
