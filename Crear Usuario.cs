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
    public partial class Crear_Usuario : Form
    {
        public Crear_Usuario()
        {
            InitializeComponent();
        }

        private void Guardar(object sender, EventArgs e)
        {
            Inicio_Sesión inicio_Sesión = new Inicio_Sesión();
            this.Hide();
            inicio_Sesión.Show();
        }
 
    }
}
