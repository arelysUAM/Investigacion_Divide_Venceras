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
        // Método para dividir el arreglo alrededor de un pivote
        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high]; // Elige el último elemento como pivote
            int i = low - 1; // Índice para los números mayores que el pivote

            // Recorre el arreglo desde el índice low hasta high - 1
            for (int j = low; j < high; j++)
            {
                // Si el número actual es mayor o igual que el pivote
                if (arr[j] >= pivot) // Buscando los más grandes
                {
                    i++; // Incrementa el índice de los números grandes
                    Swap(arr, i, j); // Intercambia el número mayor con el número en la posición i
                }
            }
            Swap(arr, i + 1, high); // Coloca el pivote en su lugar correcto
            return i + 1; // Devuelve la posición final del pivote
        }

        // Método para intercambiar dos elementos en el arreglo
        static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i]; // Guarda temporalmente el valor del primer número
            arr[i] = arr[j]; // Coloca el segundo número en la posición del primero
            arr[j] = temp; // Coloca el primer número en la posición del segundo
        }

        // Método QuickSelect para encontrar el k-ésimo elemento más grande
        static int QuickSelect(int[] arr, int low, int high, int k)
        {
            // Aplicando "Divide y Vencerás": se sigue dividiendo mientras haya elementos
            if (low <= high)
            {
                // Se divide el arreglo utilizando el pivote
                int pivotIndex = Partition(arr, low, high); // Aquí se divide el problema

                // Si el pivote está en la posición k, se ha encontrado el k-ésimo más grande
                if (pivotIndex == k)
                    return arr[pivotIndex]; // Caso base: se ha encontrado el k-ésimo más grande

                // Si el pivote está antes de la posición k, se busca en la mitad derecha aqui es el metodo divide y vencerás
                else if (pivotIndex < k)
                    return QuickSelect(arr, pivotIndex + 1, high, k); // Sigue dividiendo a la derecha

                // Si el pivote está después de la posición k, se busca en la mitad izquierda aqui se usa el metodo divide y vencerás
                else
                    return QuickSelect(arr, low, pivotIndex - 1, k); // Sigue dividiendo a la izquierda
            }
            return -1; // Si no se encuentra el elemento
        }

        static void Main(string[] args)
        {
            Console.Write("Programa que encuentra el k-ésimo número más grande (ENTEROS)");
            Console.WriteLine();
            // Se pide al usuario que ingrese una serie de números separados por espacio
            Console.Write("Ingrese números separados por espacio: ");
            // Convierte la entrada del usuario en un arreglo de enteros
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            // Se pide al usuario que ingrese el valor de k (el k-ésimo más grande)
            Console.Write("Ingrese el valor de k para encontrar el k-ésimo elemento más grande: ");
            int k = Convert.ToInt32(Console.ReadLine()) - 1; // Resta 1 para trabajar con índices basados en 0

            // Verifica si k está dentro del rango permitido
            if (k >= 0 && k < numbers.Length)
            {
                // Llama al método QuickSelect para encontrar el k-ésimo más grande
                int result = QuickSelect(numbers, 0, numbers.Length - 1, k);
                // Muestra el resultado al usuario
                Console.WriteLine($"El {k + 1}-ésimo elemento más grande es: {result}");
            }
            else
            {
                // Mensaje de error si k está fuera del rango
                Console.WriteLine("k debe estar entre 1 y el tamaño de la lista.");
            }

            // Espera a que el usuario presione una tecla antes de cerrar
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}

