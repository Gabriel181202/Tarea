using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    public class SerVivo
    {
        //variable
        protected string genero;
        //propiedad
        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }
        //Constructor
        public SerVivo()
        {
            genero = " "; 
        }

        //Método
        public override string ToString()
        {
            return genero + " ";
        }
    }
}
