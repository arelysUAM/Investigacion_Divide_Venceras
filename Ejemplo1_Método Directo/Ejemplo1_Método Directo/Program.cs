/* Suma de elementos de un arreglo (Método Directo)
Dado un arreglo de números enteros, queremos calcular 
la suma de todos los elementos del arreglo.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1_Método_Directo
{
    internal class Program
    {
        //Método iterativo: toma un arreglo de enteros como argumento.
        int SumArrayDirecto(int[] arr)
        {
            int suma = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                //Acumulación
                suma += arr[i];
            }
            return suma;
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

            // Llamar al método SumArrayDirect y guardar el resultado
            int resultado = programa.SumArrayDirecto(numeros);

            // Imprimir
            Console.WriteLine("La suma de los elementos del arreglo es: " + resultado);

            Console.ReadKey();
        }
    }
}
