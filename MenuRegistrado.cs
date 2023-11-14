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
    public partial class MenuRegistrado : Form
    {
        public MenuRegistrado()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void peliculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertPelicula menu = new InsertPelicula();
            menu.ShowDialog();
        }
    }
}
