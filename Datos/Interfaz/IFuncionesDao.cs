using InicioSesion.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicioSesion.Datos.Interfaz
{
    internal interface IFuncionesDao
    {
        bool Crear(Funciones oFunciones);

    }
}
