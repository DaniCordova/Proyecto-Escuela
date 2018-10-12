using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEscuela
{
    class AdministraMaestro
    {
        public static int numMaestro = 0; 
        public Maestro[] ArrMaestro = new Maestro[10];

        public void MenuMaestro(Maestro[] ArrMae)
        {
            Console.Clear();
            int opc = 0;

            do
            {
                try
                {
                    Console.WriteLine("    Instituto Tecnologico de Culiacan");
                    Console.WriteLine("__________________________________________");
                    Console.WriteLine("                 Maestro  ");
                    Console.WriteLine("__________________________________________");

                    Console.WriteLine(" (1) Agregar Maestro ");
                    Console.WriteLine(" (2) Reporte Maestros");
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
                        AgregarMaestro(ArrMae);
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

        public void AgregarMaestro(Maestro[] ArrMae)
        {
            Console.Clear();
            int clave = 0;
            string nombre = "";
            string formacionAcademica = "";
            string horario = "";

            Console.WriteLine("\n Agregar Materia\n");
            do
            {
                try
                {
                    Console.WriteLine("Ingresa la clave del maestro: ");
                    clave = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Ingresa solo números");
                }

            } while (BuscaClave(clave, ArrMae));

            Console.WriteLine("Ingresa el nombre del maestro: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingresa la formación académica.");
            formacionAcademica = Console.ReadLine();

            Console.WriteLine("Ingresa el horario del profesor. (Ejemplo. 7:00am - 14:00pm)");
            horario = Console.ReadLine();

            Maestro mae = new Maestro(clave, nombre, formacionAcademica, horario);
            ArrMae[numMaestro] = mae;
            numMaestro++;
        }

        /* ///////////////////////////////////////////////////////////////////// */

        public bool BuscaClave(int clave, Maestro[] ArrMae)
        {
            bool bandera = false;

            for(int i = 0; i < numMaestro; i++)
                {
                    
                    if (ArrMae[i].pClave == clave)
                    {
                        bandera = true;
                    }
                    
                }
            
            return bandera;
        }

        /* ///////////////////////////////////////////////////////////////////// */

        public void Reporte()
        {
            for(int i = 0; i<numMaestro; i++)
            {
                Console.WriteLine("Clave del maestro: {0} | Nombre del maestro: {1} | Formación académica: {2} | Horario: {3}", ArrMaestro[i].pClave, ArrMaestro[i].pNombre, ArrMaestro[i].pFormacionAcademica, ArrMaestro[i].pHorario);
            }
            Console.ReadLine();
        }
    }
}
