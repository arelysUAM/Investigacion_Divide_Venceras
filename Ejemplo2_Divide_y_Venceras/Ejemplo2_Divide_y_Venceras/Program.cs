/* Búsqueda en un arreglo ordenado (Método Divide y Vencerás)
Descripción: Dado un arreglo ordenado de números enteros, 
queremos determinar si un número específico está en el arreglo.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2_Divide_y_Venceras
{
    internal class Program
    {
        //  Método Recursivo
        bool BinarySearch(int[] arr, int izquierda, int derecha, int objetivo)
        {
            //Caso base
            if (izquierda > derecha)
            {
                return false;
            }

            int mitad = (izquierda + derecha) / 2;

            // Llamadas recursivas
            if (arr[mitad] == objetivo)
            {
                return true;
            }
            else if (arr[mitad] > objetivo)
            {
                return BinarySearch(arr, izquierda, mitad - 1, objetivo);
            }
            else
            {
                return BinarySearch(arr, mitad + 1, derecha, objetivo);
            }
        }

        static void Main(string[] args)
        {
            // Instancia
            Program programa = new Program();

            // Arreglo ordenado
            int[] numeros = { 1, 3, 5, 7, 9, 11, 13, 15 };

            // Pedir al usuario el número a buscar
            Console.Write("Ingrese el número a buscar: ");
            int objetivo = int.Parse(Console.ReadLine());

            // Llamar al método BinarySearch y guardar el resultado
            bool encontrado = programa.BinarySearch(numeros, 0, numeros.Length - 1, objetivo);

            // Imprimir el resultado en la consola
            if (encontrado)
            {
                Console.WriteLine($"El número {objetivo} se encuentra en el arreglo.");
            }
            else
            {
                Console.WriteLine($"El número {objetivo} NO se encuentra en el arreglo.");
            }

            Console.ReadKey();
        }
    }
}
