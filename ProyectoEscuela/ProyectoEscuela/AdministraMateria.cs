using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEscuela
{
    class AdministraMateria
    {
        AdministraAula AA = new AdministraAula();
        AdministraMaestro AMAE = new AdministraMaestro();
        public Dictionary<string, Materia> dicAsignacion = new Dictionary<string, Materia>();

        /* ///////////////////////////////////////////////////////////////////// */

        public void MenuMateria(Dictionary<string, Materia> dicAsig, List<Aula> ListAu, Maestro[] ArrMae)
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

                    Console.WriteLine(" (1) Asignar aula a maestro ");
                    Console.WriteLine(" (2) Salir");
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
                        AgregarMaterias(dicAsig, ListAu, ArrMae);
                        break;
                    case 2:
                        break;
                }
            } while (opc != 2);
        }

        /* ///////////////////////////////////////////////////////////////////// */

        public void AgregarMaterias(Dictionary<string, Materia> dicAsig, List<Aula> ListAu, Maestro[] ArrMae)
        {
            Console.Clear();

            string nombreMateria = "";
            int claveMaestro = 0;
            string claveAula = "";
            int hora = 0;

            Console.WriteLine("\n Agregar Materia\n");

            do
            {
                Console.WriteLine("Nombre de la materia");
                nombreMateria = Console.ReadLine().ToUpper();
                if (nombreMateria == "")
                {
                    Console.WriteLine("El campo está vacio");
                }
            } while (nombreMateria == "");

            do
            {
                try
                {
                    Console.WriteLine("Clave del maestro");
                    claveMaestro = Convert.ToInt32(Console.ReadLine());
                    if (claveMaestro == 0)
                    {
                        Console.WriteLine("El campo está vacio");
                    }
                }
                catch
                {
                    Console.WriteLine("Solo números para clave de maestro.");
                }
            } while (AMAE.BuscaClave(claveMaestro, ArrMae) == false);

            do
            {
                Console.WriteLine("Clave del Aula");
                AA.Reporte(ListAu);
                claveAula = Console.ReadLine().ToUpper();
            } while (BuscaClave(claveAula, ListAu) == false);


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

            if (ValidaHoraMate(claveAula, hora))
            {
                Console.WriteLine("EL Aula Esta Ocupada");
                Console.ReadLine();
                MenuMateria(dicAsig, ListAu, ArrMae);
            }
            else
            {
                string claveCompuesta = hora+claveAula;
                Materia ma = new Materia(nombreMateria, claveMaestro, claveAula, hora);
                dicAsignacion.Add(claveCompuesta, ma);
            }
        }

        /* ///////////////////////////////////////////////////////////////////// */

        public void Reporte()
        {
            Console.Clear();
            foreach (var key in dicAsignacion.Keys)
            {
                Materia mat = dicAsignacion[key];
                Console.WriteLine("Clave: {0} | Nombre de la materia: {1} | Clave del maestro: {2} | Aula: {3} | Hora: {4}", key, mat.pNombreMateria, mat.pClaveMaestro, mat.pClaveAula, mat.pHora);
                Console.WriteLine();
            }
        }

        /* ///////////////////////////////////////////////////////////////////// */

        public bool ValidaHoraMate(string aula, int hora)
        {
            bool bandera = false;

            foreach (var key in dicAsignacion.Keys)
            {
                Materia mat = dicAsignacion[key];
                if (mat.pClaveAula == aula && mat.pHora == hora)
                {
                        bandera = true; 
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

        /* ///////////////////////////////////////////////////////////////////// */

        public void ConsultaAsignacionAulas()
        {
            Console.Clear();
            string claveAula = "";

            do
            {
                try
                {
                    Console.WriteLine("Escribe la clave del aula: ");
                    claveAula = Console.ReadLine().ToUpper();
                }
                catch
                {
                    Console.WriteLine("Ejemplo: B01");
                }
            } while(claveAula == "");


            Console.WriteLine("\nAulas asignadas a la clave: {0}\n", claveAula);

            foreach (var key in dicAsignacion.Keys)
            {
                Materia mat = dicAsignacion[key];
                if(claveAula == mat.pClaveAula)
                {
                    Console.WriteLine("Clave: {0} | Nombre de la materia: {1} | Clave del maestro: {2} | Aula: {3} | Hora: {4}", key, mat.pNombreMateria, mat.pClaveMaestro, mat.pClaveAula, mat.pHora);
                }
            }
            Console.ReadLine();
        }

        /* ///////////////////////////////////////////////////////////////////// */

        public void ConsultaDeMaestros()
        {
            Console.Clear();
            int claveMaestro = 0;

            do
            {
                try
                {
                    Console.WriteLine("Escribe la clave del maestro: ");
                    claveMaestro = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Escribe solo números.");
                }
            }while (claveMaestro == 0);

            Console.WriteLine("\nHorarios de los maestros: {0}\n", claveMaestro);

            foreach (var key in dicAsignacion.Keys)
            {
                Materia mat = dicAsignacion[key];
                if (claveMaestro == mat.pClaveMaestro)
                {
                    Console.WriteLine("Clave: {0} | Nombre de la materia: {1} | Aula: {2} | Hora: {3}", key, mat.pNombreMateria, mat.pClaveAula, mat.pHora);
                }
            }
            Console.ReadLine();
        }

        /* ///////////////////////////////////////////////////////////////////// */

        public void ModificaAsignacion()
        {
            string claveAula = "";
            int hora = 0;
            int claveMaestro = 0;
            string materia = "";

            Console.WriteLine("Modificar asignación de aulas.\n");

            Console.WriteLine("Ingrese la clave del aula");
            claveAula = Console.ReadLine().ToUpper();

            Console.WriteLine("Ingrese la hora");
            hora = Convert.ToInt32(Console.ReadLine());

            foreach (var key in dicAsignacion.Keys)
            {
                Materia mat = dicAsignacion[key];
                if (claveAula == mat.pClaveAula)
                {
                    if(hora == mat.pHora)
                    {
                        do
                        {
                            try
                            {
                                Console.WriteLine("Ingrese la nueva clave de maestro.");
                                claveMaestro = Convert.ToInt32(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Solo números,.");
                            }
                        } while(claveMaestro == 0);

                        Console.WriteLine("Ingrese la nueva materia.");
                        materia = Console.ReadLine().ToUpper();

                        mat.pClaveMaestro = claveMaestro;
                        mat.pNombreMateria = materia;
                    }
                }
            }

            /* ///////////////////////////////////////////////////////////////////// */

        }
    }
}
