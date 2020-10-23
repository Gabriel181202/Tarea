using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnServivo_Click(object sender, EventArgs e)
        {
            SerVivo s;
            s = new SerVivo();
            s.Genero = "Macho";
            MessageBox.Show(s.ToString());
        }

        private void btnMamíferos_Click(object sender, EventArgs e)
        {
            Mamíferos m;
            m = new Mamíferos();
            m.Genero = "Macho";
            m.Tipo = "Placentario";
            MessageBox.Show(m.ToString());
        }

        private void btnGatitos_Click(object sender, EventArgs e)
        {
            Gatitos g;
            g = new Gatitos();
            g.Genero = "Macho";
            g.Tipo = "Placentario";
            g.Comunicación = "Maullido";
            MessageBox.Show(g.ToString());
        }
    }
}
