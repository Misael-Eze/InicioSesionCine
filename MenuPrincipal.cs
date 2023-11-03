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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrarALaApp_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuNormal menu = new MenuNormal();
            menu.Show();
        }

        private void lklInicioSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            MenuRegistro menu = new MenuRegistro();
            menu.Show();
        }
    }
}
