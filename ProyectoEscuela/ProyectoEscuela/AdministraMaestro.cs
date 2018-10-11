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
                        break;
                    case 2:
                        break;
                }
            } while (opc != 3);
        }

        /* ///////////////////////////////////////////////////////////////////// */
    }
}
