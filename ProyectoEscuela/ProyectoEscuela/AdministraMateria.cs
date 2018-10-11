using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEscuela
{
    class AdministraMateria
    {
        public List<Materia> ListMateria = new List<Materia>();
        AdministraAula AA = new AdministraAula();
        Dictionary<int, Materia> dicMateria = new Dictionary<int, Materia>();

        /* ///////////////////////////////////////////////////////////////////// */

        public void MenuMateria(List<Materia> ListMat, List<Aula> ListAu)
        {
            Console.Clear();
            int opc = 0;

            do
            {
                try
                {
                    Console.WriteLine("    Instituto Tecnologico de Culiacan");
                    Console.WriteLine("__________________________________________");
                    Console.WriteLine("                Materia  ");
                    Console.WriteLine("__________________________________________");

                    Console.WriteLine(" (1) Agregar Materia ");
                    Console.WriteLine(" (2) Reporte Materia");
                    Console.WriteLine(" (3) Salir");
                    Console.WriteLine();
                    Console.WriteLine("SELECCIONE UNA OPCION");
                    opc = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Solo números\n");
                }

                switch (opc)
                {
                    case 1:
                        AgregarMaterias(ListMat, ListAu);
                        break;
                    case 2:
                        Reporte();
                        break;
                }
            } while (opc != 3);
        }

        /* ///////////////////////////////////////////////////////////////////// */

        public void AgregarMaterias(List<Materia> ListMat, List<Aula> ListAu)
        {

            string nombreMateria = "";
            string nombreMaestro = "";
            string clave = "";
            int hora = 0;

            Console.WriteLine("\n Agregar Materia\n");

            do
            {
                Console.WriteLine("Nombre de la materia");
                nombreMateria = Console.ReadLine();
                if (nombreMateria == "")
                {
                    Console.WriteLine("El campo está vacio");
                }
            } while (nombreMateria == "");

            do
            {
                Console.WriteLine("Nombre del maestro");
                nombreMaestro = Console.ReadLine();
                if (nombreMaestro == "")
                {
                    Console.WriteLine("El campo está vacio");
                }
            } while (nombreMaestro == "");

            do
            {
                Console.WriteLine("Clave del Aula");
                ReporteAula(ListAu);
                clave = Console.ReadLine();
            } while (BuscaClave(clave, ListAu) == false);


            do
            {
                try
                {
                    Console.WriteLine("Escriba la hora");
                    hora = Convert.ToInt32(Console.ReadLine());
                    if (hora < 7 || hora > 20)
                    {
                        Console.WriteLine("Horas no validas");
                    }
                }
                catch
                {
                    Console.WriteLine("Escriba solo números del 7 (7:00am) al 20 (8:00pm)");
                }

            } while (hora < 7 || hora > 20);

            if (ValidaHoraMate(clave, hora))
            {
                Console.WriteLine("EL Aula Esta Ocupada");
                MenuMateria(ListMat, ListAu);
            }
            else
            {
                Materia ma = new Materia(nombreMateria, nombreMaestro, clave, hora);
                ListMateria.Add(ma);
            }
        }

        /* ///////////////////////////////////////////////////////////////////// */

        public void Reporte()
        {
            foreach (Materia m in ListMateria)
            {
                Console.WriteLine("Nombre de la materia {0} | Nombre del maestro {1} | Aula {2} | hora {3}", m.pNombreMateria, m.pNombreMaestro, m.pClaveAula, m.pHora);
            }
        }

        /* ///////////////////////////////////////////////////////////////////// */

        public bool ValidaHoraMate(string aula, int hora)
        {
            bool bandera = false;

            foreach (Materia m in ListMateria)
            {
                if (m.pClaveAula == aula)
                {
                    if (m.pHora == hora)
                    {
                        bandera = true;
                    }
                }
            }
            return bandera;
        }

        /* ///////////////////////////////////////////////////////////////////// */

        public bool BuscaClave(string clave, List<Aula> ListAu)
        {
            bool bandera = false;

            foreach (Aula a in ListAu)
            {
                if (a.pClave == clave)
                {
                    bandera = true;
                }
            }
            return bandera;
        }


        public void ReporteAula(List<Aula> ListAu)
        {
            foreach (Aula a in ListAu)
            {
                Console.WriteLine("Clave: {0} | Edificio: {1} | Descripción: {2}", a.pClave, a.pNombreEdificio, a.pDescripcion);
            }
            Console.WriteLine();
        }

    }
}
