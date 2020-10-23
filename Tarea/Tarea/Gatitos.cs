using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    public class Gatitos : Mamíferos
    {
        //variable
        protected string comunicación;
        //propiedad
        public string Comunicación
        {
            get { return comunicación; }
            set { comunicación = value; }
        }
        //Constructor
        public Gatitos(): base ()
        {
            comunicación = " ";
        }

        //Método
        public override string ToString()
        {
            return base.ToString() + " " + comunicación; 
        }
    }
}
