using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act1_Video_game
{
    public class Personaje
    {
        String anexo;
        private String mensaje2 = "Esta es otra persona. ";
        public void mensaje(){Console.WriteLine("!Esta es una persona.");}
        ///----------
        public string Mensaje2
        {
            set{mensaje2 = value;}
            get{return mensaje2;}
        }
        public string Anexo{
            set{anexo = value;}
            get{return anexo;}
        }
        public void ambos()
        {
            Console.WriteLine(Mensaje2 + " " + Anexo);
        }
    }
}
 