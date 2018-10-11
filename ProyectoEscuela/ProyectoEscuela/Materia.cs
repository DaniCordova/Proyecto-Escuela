using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEscuela
{
    class Materia
    {
        public string nombreMateria;
        public string nombreMaestro;
        public string claveAula;
        public int hora;

        public Materia(string NombreMateria, string NombreMaestro, string ClaveAula, int Hora)
        {
            nombreMateria = NombreMateria;
            nombreMaestro = NombreMaestro;
            claveAula = ClaveAula;
            hora = Hora;
        }

        public string pNombreMateria
        {
            get
            {
                return nombreMateria;
            }
            set
            {
                nombreMateria = value;
            }
        }

        public string pNombreMaestro
        {
            get
            {
                return nombreMaestro;
            }
            set
            {
                nombreMaestro = value;
            }
        }

        public string pClaveAula
        {
            get
            {
                return claveAula;
            }
            set
            {
                claveAula = value;
            }
        }

        public int pHora
        {
            get
            {
                return hora;
            }
            set
            {
                hora = value;
            }
        }
    }
}
