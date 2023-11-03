using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InicioSesion
{
    public partial class MenuRegistro : Form
    {
        public MenuRegistro()
        {
            InitializeComponent();
        }

        private void MenuRegistro_Load(object sender, EventArgs e)
        {
            Limpieza();
            txtUsuario.Focus();
        }

        private void Limpieza()
        {
            txtUsuario.Text = string.Empty;
            txtContraseña.Text = string.Empty;
            
        }

        private void btnIngresarUsu_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario1" && txtContraseña.Text == "12345")
                IniciarSesion();
            else
                MessageBox.Show("No se puede iniciar sesion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                
        }

        private void IniciarSesion()
        {
            this.Close();
            MenuRegistrado menu = new MenuRegistrado();
            menu.Show();
        }
    }
}
