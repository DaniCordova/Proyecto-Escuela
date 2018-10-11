using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEscuela
{
    class Aula
    {
        public string clave;
        public string nombreEdificio;
        public string descripcion;

        public Aula(string Clave, string NombreEdificio, string Descripcion)
        {
            clave = Clave;
            nombreEdificio = NombreEdificio;
            descripcion = Descripcion;
        }

        public string pClave
        {
            get
            {
                return clave;
            }
            set
            {
                clave = value;
            }
        }

        public string pNombreEdificio
        {
            get
            {
                return nombreEdificio;
            }
            set
            {
                nombreEdificio = value;
            }
        }

        public string pDescripcion
        {
            get
            {
                return descripcion;
            }
            set
            {
                descripcion = value;
            }
        }
    }
}
