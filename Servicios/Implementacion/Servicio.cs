using InicioSesion.Datos.Implementacion;
using InicioSesion.Datos.Interfaz;
using InicioSesion.Entidades;
using InicioSesion.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicioSesion.Servicios.Implementacion
{
    internal class Servicio : IServicio
    {
        private IFuncionesDao dao;
        public Servicio()
        {
            dao = new FuncionesDao();
        }
        public bool CrearFuncion(Funciones oFuncion)
        {
            return dao.Crear(oFuncion);
        }
    }
}
