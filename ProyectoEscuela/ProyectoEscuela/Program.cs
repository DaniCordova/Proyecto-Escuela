using System;
using System.Collections.Generic;

namespace ProyectoEscuela
{
    class Program
    {
        AdministraAula AA = new AdministraAula();
        AdministraMateria AM = new AdministraMateria();

        static void Main(string[] args)
        {
            Program p = new Program();

            int opc = 0;
            do
            {
                try
                {
                    Console.WriteLine("    Instituto Tecnológico de Culiacán");
                    Console.WriteLine("__________________________________________");
                    Console.WriteLine("           RELACIÓN AULA MATERIA ");
                    Console.WriteLine("__________________________________________\n");
                    Console.WriteLine(" (1)  Aula ");
                    Console.WriteLine(" (2)  Materia");
                    Console.WriteLine(" (3)  Salir\n");
                    Console.WriteLine("SELECCIONE UNA OPCIÓN");

                    opc = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Solo se aceptan números\n");
                }

                switch (opc)
                {
                    case 1:
                        p.AA.MenuAula(p.AA.ListAula);
                        break;
                    case 2:
                        p.AM.MenuMateria(p.AM.ListMateria, p.AA.ListAula);
                        break;
                    case 3:
                        break;
                }
            } while (opc != 3);
        }
    }
}
