using System;
using System.Collections.Generic;

namespace ProyectoEscuela
{
    class Program
    {
        AdministraAula AA = new AdministraAula();
        AdministraMateria AM = new AdministraMateria();
        AdministraMaestro AMAE = new AdministraMaestro();

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
                    Console.WriteLine(" (3)  Maestro");
                    Console.WriteLine(" (4)  Consulta de asignacion de aulas");
                    Console.WriteLine(" (5)  Consulta de maestros");
                    Console.WriteLine(" (6)  Modificacion de asignacion de aulas");
                    Console.WriteLine(" (7)  Impresión de todos los horarios y aulas asignadas");
                    Console.WriteLine(" (8)  Salir\n");
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
                        p.AM.MenuMateria(p.AM.dicAsignacion, p.AA.ListAula, p.AMAE.ArrMaestro);
                        break;
                    case 3:
                        p.AMAE.MenuMaestro(p.AMAE.ArrMaestro);
                        break;
                    case 4:
                        p.AM.ConsultaAsignacionAulas();
                        break;
                    case 5:
                        p.AM.ConsultaDeMaestros();
                        break;
                    case 6:
                        p.AM.ModificaAsignacion();
                        break;
                    case 7:
                        p.AM.Reporte();
                        break;
                    case 8:
                        break;
                }
            } while (opc != 7);
        }
    }
}
