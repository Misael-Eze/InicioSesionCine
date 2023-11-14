using InicioSesion.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InicioSesion.Entidades
{
    internal class Funciones
    {
        public int Id_Funcion { get; set; }
        public Pelicula Pelicula { get; set; }
        public int Sala { get; set; }
        public DateTime Dia { get; set; }
        public DateTime Hora { get; set; }
        public Funciones()
        {
            Pelicula = new Pelicula();
            Sala = 0;
            Dia = DateTime.Now;
            Hora = DateTime.Now;
        }
        public Funciones(Pelicula oPelicula, int sala, DateTime dia, DateTime hora)
        {
            Pelicula = oPelicula;
            Sala = sala;
            Dia = dia;
            Hora = hora;            
        }
    }
}
