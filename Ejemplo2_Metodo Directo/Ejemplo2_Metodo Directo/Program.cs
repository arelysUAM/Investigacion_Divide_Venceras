/* Búsqueda en un arreglo ordenado (Método Directo)
Descripción: Dado un arreglo ordenado de números enteros, 
queremos determinar si un número específico está en el arreglo.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2_Metodo_Directo
{
    internal class Program
    {
        //Método Iterativo: toma un arreglo de enteros y un entero objetivo como argumentos.
        bool BusquedaLineal(int[] arr, int objetivo)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == objetivo)
                {
                    return true;
                }
            }
            return false;
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

            // Llamar al método LinearSearch y guardar el resultado
            bool encontrado = programa.BusquedaLineal(numeros, objetivo);

            // Imprimir
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
