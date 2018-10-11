using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEscuela
{
    class Maestro
    {
        int clave;
        string nombre;
        string formacionAcademica;
        string horario;

        public Maestro(int Clave, string Nombre, string FormacionAcademica)
        {
            clave = Clave;
            nombre = Nombre;
            formacionAcademica = FormacionAcademica;
        }

        public int pClave
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

        public string pNombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public string pFormacionAcademica
        {
            get
            {
                return formacionAcademica;
            }
            set
            {
                formacionAcademica = value;
            }
        }

        public string pHorario
        {
            get
            {
                return horario;
            }
            set
            {
                horario = value;
            }
        }


    }
}
