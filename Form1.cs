using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Iniciar(object sender, EventArgs e)
        {
            Inicio_Sesión inicio_Sesión = new Inicio_Sesión();
            this.Hide();
            inicio_Sesión.Show();
        }
    }
}
