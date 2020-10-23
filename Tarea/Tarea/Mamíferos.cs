using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    public class Mamíferos : SerVivo
    {
        //variable
        protected string tipo;
        //propiedad
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        //Constructor
        public Mamíferos(): base ()
        {
            tipo = " ";
        }

        //Método
        public override string ToString()
        {
            return base.ToString() + " " + tipo;
        }
    }
}
