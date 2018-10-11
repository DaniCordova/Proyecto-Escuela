using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEscuela
{
    class AdministraAula
    {
        public List<Aula> ListAula = new List<Aula>();

        /* ///////////////////////////////////////////////////////////////////// */

        public void MenuAula(List<Aula> ListAu)
        {
            Console.Clear();
            int opc = 0;
            do
            {
                try
                {
                    Console.WriteLine("    Instituto Tecnológico de Culiacán");
                    Console.WriteLine("__________________________________________");
                    Console.WriteLine("                AULA  ");
                    Console.WriteLine("__________________________________________");
                    Console.WriteLine(" (1) Agregar Aula ");
                    Console.WriteLine(" (2) Reporte Aula");
                    Console.WriteLine(" (3) Salir\n");
                    Console.WriteLine("SELECCIONE UNA OPCIÓN");

                    opc = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Solo números\n");
                }

                switch (opc)
                {
                    case 1:
                        AgregarAulas(ListAu);
                        break;
                    case 2:
                        Reporte();
                        break;
                    case 3:
                        break;
                }
            } while (opc != 3);
        }

        /* ///////////////////////////////////////////////////////////////////// */

        public void AgregarAulas(List<Aula> ListAu)
        {

            Console.WriteLine();
            Console.WriteLine("Agregar aula:\n");
            string clave;
            string nombreE = "";
            string descripcion = "";

            do
            {
                Console.WriteLine("Nombre del aula");
                clave = Console.ReadLine();
            } while (BuscaClave(clave) == true);


            do
            {
                Console.WriteLine("Nombre del edificio");
                nombreE = Console.ReadLine();
                if (nombreE == "")
                {
                    Console.WriteLine("El campo está vacío");
                }
            } while (nombreE == "");
            do
            {
                Console.WriteLine("Descripción del edificio");
                descripcion = Console.ReadLine();
                if (descripcion == "")
                {
                    Console.WriteLine("Campo vacio");
                }
            } while (descripcion == "");

            Aula au = new Aula(clave, nombreE, descripcion);
            ListAu.Add(au);
        }

        /* ///////////////////////////////////////////////////////////////////// */

        public void Reporte()
        {
            foreach (Aula a in ListAula)
            {
                Console.WriteLine("Clave: {0} | Edificio: {1} | Descripción: {2}", a.pClave, a.pNombreEdificio, a.pDescripcion);
            }
            Console.WriteLine();
        }

        /* ///////////////////////////////////////////////////////////////////// */

        public bool BuscaClave(string clave)
        {
            bool bandera = false;

            foreach (Aula a in ListAula)
            {
                if (a.pClave == clave)
                {
                    bandera = true;
                }
            }
            return bandera;
        }

        /* ///////////////////////////////////////////////////////////////////// */

    }
}
