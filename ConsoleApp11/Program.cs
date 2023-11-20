using ConsoleApp11.biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class Program
    {
        public static void ProcesarOpcion(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    letras.encuesta();
                    break;
                case 2:
                    letras.MostrarDatosEncuesta();
                    break;
                case 3:
                    letras.MostrarResultadosEncuesta();
                    break;
                case 4:
                    letras.BuscarPersonasPorEdad();
                    break;
                case 5:
                    Console.WriteLine("Saliendo del programa. ¡Hasta luego!");
                    break;
            }
        }
    }
}
