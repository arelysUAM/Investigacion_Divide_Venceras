/*
 Programa que encuentra el k-ésimo número más grande en una lista de enteros, dividiendo 
 la lista en partes más pequeñas con un pivote y buscando recursivamente en la mitad relevante.
 Realizado por Arelys Obando, Jonathan Rivera y Kimberly Zapata 
 */

/*


class Program
{
    static void Main()
    {
        // Pedir al usuario que ingrese la cantidad de números
        Console.Write("¿Cuántos números quieres ingresar? ");
        int cantidad = int.Parse(Console.ReadLine());

        // Crear un arreglo para almacenar los números
        int[] numeros = new int[cantidad];

        // Pedir al usuario que ingrese los números
        for (int i = 0; i < cantidad; i++)
        {
            Console.Write("Ingresa el número " + (i + 1) + ": ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        // Pedir al usuario que ingrese el valor de k
        Console.Write("¿Qué k-ésimo número más grande deseas encontrar? ");
        int k = int.Parse(Console.ReadLine());

        // Ordenar el arreglo en orden descendente
        Array.Sort(numeros);
        Array.Reverse(numeros);

        // Comprobar si k es válido
        if (k > 0 && k <= cantidad)
        {
            Console.WriteLine($"El {k}-ésimo número más grande es: {numeros[k - 1]}");
        }
        else
        {
            Console.WriteLine("El valor de k no es válido.");
        }
    }
}

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2_DivideyVenceras
{
    internal class Program
    {
        // Método que encuentra el k-ésimo número más grande
        int EncontrarKesimo(int[] arr, int inicio, int fin, int k)
        {
            int pivote = arr[fin]; // Usar el último elemento como pivote
            int i = inicio;

            for (int j = inicio; j < fin; j++)
            {
                // Reorganizar el arreglo
                if (arr[j] >= pivote)
                {
                    // Intercambiar arr[i] y arr[j]
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                }
            }

            // Intercambiar el pivote con arr[i]
            int tempPivote = arr[i];
            arr[i] = arr[fin];
            arr[fin] = tempPivote;

            // Verificar la posición del pivote
            if (i == k - 1) return arr[i]; // k-ésimo encontrado
            else if (i < k - 1) return EncontrarKesimo(arr, i + 1, fin, k); // Buscar a la derecha
            else return EncontrarKesimo(arr, inicio, i - 1, k); // Buscar a la izquierda
        }

        static void Main(string[] args)
        {
            Program programa = new Program();

            // Ingreso de datos
            Console.Write("Cantidad de números: ");
            int n = int.Parse(Console.ReadLine());
            int[] numeros = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Número {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Ingrese k - k-ésimo más grande: ");
            int k = int.Parse(Console.ReadLine());

            // Validar k
            if (k < 1 || k > n)
            {
                Console.WriteLine("k debe estar entre 1 y la cantidad de números.");
            }
            else
            {
                // Encontrar y mostrar el k-ésimo número más grande
                int resultado = programa.EncontrarKesimo(numeros, 0, n - 1, k);
                Console.WriteLine($"El {k}-ésimo número más grande es: {resultado}");
            }

            Console.ReadKey(); // Esperar a que el usuario presione una tecla
        }
    }
}

