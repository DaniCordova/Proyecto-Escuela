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
        public int claveMaestro;
        public string claveAula;
        public int hora;

        public Materia(string NombreMateria, int ClaveMaestro, string ClaveAula, int Hora)
        {
            nombreMateria = NombreMateria;
            claveMaestro = ClaveMaestro;
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

        public int pClaveMaestro
        {
            get
            {
                return claveMaestro;
            }
            set
            {
                claveMaestro = value;
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
