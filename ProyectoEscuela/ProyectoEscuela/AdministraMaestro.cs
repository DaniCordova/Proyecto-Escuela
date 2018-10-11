using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEscuela
{
    class AdministraMaestro
    {
        List<Maestro> ListMaestro = new List<Maestro>();
        AdministraMaestro AMa = new AdministraMaestro();

        public void MenuMateria(List<Materia> ListMat, List<Aula> ListAu)
        {
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
                        AgregarMaestro(ListMaestro);
                        break;
                    case 2:
                        break;
                }
            } while (opc != 3);
        }

        /* ///////////////////////////////////////////////////////////////////// */

        public void AgregarMaestro(List<Maestro> ListMae)
        {
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

            } while (BuscaClave(clave, ListMae));

            Console.WriteLine("Ingresa el nombre del maestro: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingresa la formación académica.");
            formacionAcademica = Console.ReadLine();

            Console.WriteLine("Ingresa el horario del profesor. (Ejemplo. 7:00am - 14:00pm)");
            horario = Console.ReadLine();

            Maestro mae = new Maestro(clave, nombre, formacionAcademica, horario);

            ListMaestro.Add(mae);
        }

        /* ///////////////////////////////////////////////////////////////////// */

        public bool BuscaClave(int clave, List<Maestro> ListMae)
        {
            bool bandera = false;

            foreach (Maestro m in ListMae)
            {
                if (m.pClave == clave)
                {
                    bandera = true;
                }
            }
            return bandera;
        }

    }
}
