/* Suma de elementos de un arreglo (Método Divide y Vencerás)
Dado un arreglo de números enteros, queremos calcular 
la suma de todos los elementos del arreglo.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1_Divide_y_Vencerás
{
    internal class Program
    {
        //Método Recursivo: toma un arreglo de enteros y dos índices que representan
        //los límites izquierdo y derecho del subarreglo.
        int SumArrayDivideYVenceras(int[] arr, int izquierda, int derecha)
        {
            if (izquierda == derecha)
            {
                return arr[izquierda]; // Caso base: Un solo elemento
            }

            //Llamadas recursivas
            int mitad = (izquierda + derecha) / 2;
            int izquierdaSum = SumArrayDivideYVenceras(arr, izquierda, mitad);
            int derechaSum = SumArrayDivideYVenceras(arr, mitad + 1, derecha);

            //Combinación
            return izquierdaSum + derechaSum;
        }

        static void Main(string[] args)
        {
            // Instancia
            Program programa = new Program();

            // Pedir datos
            Console.Write("Ingrese la cantidad de elementos en el arreglo: ");
            int n = int.Parse(Console.ReadLine());

            // Arreglo
            int[] numeros = new int[n];

            // Ingresar los elementos del arreglo
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elemento {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            // Llamar al método SumArrayDivideAndConquer y pasar los índices adecuados
            int resultado = programa.SumArrayDivideYVenceras(numeros, 0, n - 1); //Elementos, índice 0, índice de finalización.

            // Imprimir
            Console.WriteLine("La suma de los elementos del arreglo es: " + resultado);

            Console.ReadKey();
        }
    }
}
