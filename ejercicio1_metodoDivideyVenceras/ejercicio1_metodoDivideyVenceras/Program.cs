/*
 Programa que ordena una lista de números enteros ingresados por el usuario. 
 Se organiza la lista dividiendo y ordenando recursivamente los elementos alrededor de un pivote.
 Realizado por Arelys Obando, Jonathan Rivera y Kimberly Zapata 
 */

/*
    Método tradicional 

    static void Main()
    {
        // Pedir al usuario que ingrese la cantidad de números
        Console.Write("¿Cuántos números quieres ordenar? ");
        int cantidad = int.Parse(Console.ReadLine());

        // Crear un arreglo para almacenar los números
        int[] numeros = new int[cantidad];

        // Pedir al usuario que ingrese los números
        for (int i = 0; i < cantidad; i++)
        {
            Console.Write("Ingresa el número " + (i + 1) + ": ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < cantidad - 1; i++)
        {
            for (int j = 0; j < cantidad - 1 - i; j++)
            {
                if (numeros[j] > numeros[j + 1])
                {
                    // Intercambiar los números
                    int temp = numeros[j];
                    numeros[j] = numeros[j + 1];
                    numeros[j + 1] = temp;
                }
            }
        }

        // Mostrar los números ordenados
        Console.WriteLine("Números ordenados:");
        for (int i = 0; i < cantidad; i++)
        {
            Console.Write(numeros[i] + " ");
        }
    }
} */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1_metodoDivideyVenceras
{
    internal class Program
    {
        // Este método ordena el arreglo usando Quick Sort (es el algoritmo de ordenamiento del método dyv)
        static void QuickSort(int[] arr, int low, int high)
        {
            // Si hay más de un elemento para ordenar
            if (low < high) // Aquí se aplica el "divide y vencerás"
            {
                // Se obtiene la posición del pivote (que es el punto de referencia) después de organizar
                int pivotIndex = Partition(arr, low, high);
                // Se llama a QuickSort para ordenar la parte izquierda del pivote
                QuickSort(arr, low, pivotIndex - 1);
                // Se llama a QuickSort para ordenar la parte derecha del pivote
                QuickSort(arr, pivotIndex + 1, high);
            }
        }

        // Este método organiza los números alrededor del pivote
        static int Partition(int[] arr, int low, int high)
        {
            // Se elige el último número como pivote
            int pivot = arr[high];
            int i = low - 1; // i es el índice del elemento más pequeño

            // Se recorre los números desde low hasta high
            for (int j = low; j < high; j++)
            {
                // Condicional por si se encuntra un número menor que el pivote
                if (arr[j] < pivot)
                {
                    i++; // Se aumenta el índice del elemento más pequeño
                    Swap(arr, i, j); // y despues se intercambian los números
                }
            }
            // Se coloca el pivote en su lugar correcto
            Swap(arr, i + 1, high);
            return i + 1; // Devolvemos la posición del pivote
        }

        // Este método intercambia dos números en el arreglo
        static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i]; // Se guarda el número en la posición i
            arr[i] = arr[j]; // Se coloca el número en la posición j en la posición i
            arr[j] = temp; // Se coloca el número guardado en la posición j
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Programa que ordena números ENTEROS");
            Console.WriteLine();
            // Se pide al usuario que ingrese números
            Console.WriteLine("Ingrese números separados por espacio: ");
            string input = Console.ReadLine(); // Se lee 

            // Se intenta (por eso el try) convertir la entrada a un arreglo de enteros
            try
            {
                // Se convierte la cadena de texto en un arreglo de números
                int[] numbers = Array.ConvertAll(input.Split(' '), int.Parse);

                // Se llama al método QuickSort para ordenar los números
                QuickSort(numbers, 0, numbers.Length - 1);

                // Se muestra los números ordenados
                Console.WriteLine("Números ordenados:");
                Console.WriteLine(string.Join(", ", numbers));
            }
            catch (FormatException) // Si hay un error de formato
            {
                // Mostramos un mensaje de error
                Console.WriteLine("Error: Asegúrese de ingresar solo números enteros separados por espacios.");
            }
            catch (OverflowException) // Si hay un error de desbordamiento
            {
                // Mostramos un mensaje de error
                Console.WriteLine("Error: Uno o más números son demasiado grandes o pequeños.");
            }

            // Esperamos a que el usuario presione una tecla antes de cerrar
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}

