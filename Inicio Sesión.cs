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
    public partial class Inicio_Sesión : Form
    {
        public Inicio_Sesión()
        {
            InitializeComponent();
        }

        private void Entrar(object sender, EventArgs e)
        {
            if (txt_user.Text == "Maria Guadalupe" && txt_password.Text == "password")
            {
                ListaProductos listaProductos = new ListaProductos();
                this.Hide();
                listaProductos.Show();
            }
            else
            MessageBox.Show("Los datos ingresados son incorrectos");
            txt_user.Clear();
            txt_password.Clear();
            }

        private void CrearCuenta(object sender, EventArgs e)
        {
            Crear_Usuario crear_Usuario = new Crear_Usuario();
            this.Hide();
            crear_Usuario.Show();
        }
    }
    }
