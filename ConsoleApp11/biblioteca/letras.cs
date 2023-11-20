using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.biblioteca
{
    public class letras
    {
        static List<int> edades = new List<int>();
        static List<int> SI_NO = new List<int>();
        static void Main()
        {
            int opcion;
            do
            {
                Console.Clear();
                MENUPRIN();
                opcion = LeerOpcion();
                Program.ProcesarOpcion(opcion);

            } while (opcion != 5);
        }
        
        static int LeerOpcion()
        {
            int opcion;
            while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 5)
            {
                Console.WriteLine("Opción no válida. Intente nuevamente.");
                Console.Write("Ingrese una opción: ");
            }
            return opcion;
        }
        public static void MENUPRIN()
        {
            Console.WriteLine("================================\r\n" +
                "Encuesta Covid-19\r\n" +
                "================================\r\n" +
                "1: Realizar Encuesta\r\n" +
                "2: Mostrar Datos de la encuesta\r\n" +
                "3: Mostrar Resultados\r\n" +
                "4: Buscar Personas por edad\r\n" +
                "5: Salir\r\n" +
                "================================\r\n");
            Console.Write("Ingrese una opción:");
        }
        public static void encuesta()
        {
            Console.Clear();
            Console.WriteLine("===================================\r\n" +
                "Encuesta de vacunación\r\n" +
                "===================================\r\n");

            Console.Write("¿Qué edad tienes?: ");
            int edad = Convert.ToInt32(Console.ReadLine());
            edades.Add(edad);

            Console.WriteLine("Te has vacunado\r\n" +
                "1: Sí\r\n" +
                "2: No\r\n" +
                "===================================\r\n");
            int respuesta;
            do
            {
                Console.Write("Ingrese una opción: ");
            } while (!int.TryParse(Console.ReadLine(), out respuesta) || respuesta < 1 || respuesta > 2);
            SI_NO.Add(respuesta);
            Console.Clear();
            Console.WriteLine("===================================\r\n" +
            "Encuesta de vacunación\r\n" +
            "===================================\r\n" +
            "\r\n¡Gracias por participar!\r\n" +
            "\r\n===================================\r\n");
            Console.WriteLine("Presione cualquier tecla para volver al menú principal...");
            Console.ReadKey(true);
        }
        public static void MostrarDatosEncuesta()
        {
            Console.Clear();
            Console.WriteLine("===================================\r\n" +
                "Datos de la encuesta\r\n" +
                "===================================\r\n");

            Console.WriteLine("ID    | Edad | Vacunado");
            Console.WriteLine("=======================");

            for (int i = 0; i < edades.Count; i++)
            {
                Console.WriteLine($"{i:D4}  |  {edades[i],-4}  |   {(SI_NO[i] == 1 ? "Si" : "No"),-3}");
            }

            Console.WriteLine("===================================\r\n");
            Console.WriteLine("Presione cualquier tecla para volver al menú principal...");
            Console.ReadKey(true);
        }
        public static void MostrarResultadosEncuesta()
        {
            Console.Clear();
            Console.WriteLine("===================================\r\n" +
                "Resultados de la encuesta\r\n" +
                "===================================\r\n");
            int vacunados = 0;
            int noVacunados = 0;
            int[] rangosEdad = new int[6];

            for (int i = 0; i < edades.Count; i++)
            {
                if (SI_NO[i] == 1)
                {
                    vacunados++;
                }
                else
                {
                    noVacunados++;
                }

                // Contar por rangos de edad
                int edad = edades[i];
                if (edad <= 20)
                    rangosEdad[0]++;
                else if (edad <= 30)
                    rangosEdad[1]++;
                else if (edad <= 40)
                    rangosEdad[2]++;
                else if (edad <= 50)
                    rangosEdad[3]++;
                else if (edad <= 60)
                    rangosEdad[4]++;
                else
                    rangosEdad[5]++;
            }
            Console.WriteLine($"{vacunados} personas se han vacunado");
            Console.WriteLine($"{noVacunados} personas no se han vacunado\n");

            Console.WriteLine("Existen:");
            Console.WriteLine($"{rangosEdad[0]} personas entre 01 y 20 años");
            Console.WriteLine($"{rangosEdad[1]} personas entre 21 y 30 años");
            Console.WriteLine($"{rangosEdad[2]} personas entre 31 y 40 años");
            Console.WriteLine($"{rangosEdad[3]} personas entre 41 y 50 años");
            Console.WriteLine($"{rangosEdad[4]} personas entre 51 y 60 años");
            Console.WriteLine($"{rangosEdad[5]} personas de más de 61 años\n");

            Console.WriteLine("===================================\r\n");
            Console.WriteLine("Presione cualquier tecla para volver al menú principal...");
            Console.ReadKey(true);
        }
        public static void BuscarPersonasPorEdad()
        {
            Console.Clear();
            Console.WriteLine("===================================\r\n" +
                "Busca a personas por edad\r\n" +
                "===================================\r\n");

            Console.Write("¿Qué edad quieres buscar?: ");
            int edadBuscada;
            while (!int.TryParse(Console.ReadLine(), out edadBuscada) || edadBuscada < 1)
            {
                Console.WriteLine("Edad no válida. Intente nuevamente.");
                Console.Write("Ingrese una edad válida: ");
            }

            int vacunados = 0;
            int noVacunados = 0;

            for (int i = 0; i < edades.Count; i++)
            {
                if (edades[i] == edadBuscada)
                {
                    if (SI_NO[i] == 1)
                    {
                        vacunados++;
                    }
                    else
                    {
                        noVacunados++;
                    }
                }
            }

            Console.WriteLine($"\n{vacunados} se vacunaron");
            Console.WriteLine($"{noVacunados} no se vacunaron\n");

            Console.WriteLine("===================================\r\n");
            Console.WriteLine("Presione cualquier tecla para volver al menú principal...");
            Console.ReadKey(true);
        }
    }
}
