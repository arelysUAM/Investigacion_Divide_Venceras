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
        // Método recursivo que ordena el arreglo dividiéndolo en partes más pequeñas
        void Ordenar(int[] arr, int inicio, int fin)
        {
            if (inicio < fin)
            {
                int mitad = (inicio + fin) / 2;    // Encuentra la mitad

                Ordenar(arr, inicio, mitad);       // Ordena la primera mitad
                Ordenar(arr, mitad + 1, fin);      // Ordena la segunda mitad
                Combinar(arr, inicio, mitad, fin); // Combina ambas mitades
            }
        }

        // Método que une dos partes ya ordenadas en un solo arreglo ordenado
        void Combinar(int[] arr, int inicio, int mitad, int fin)
        {
            int[] temp = new int[fin - inicio + 1]; // Arreglo temporal
            int i = inicio;       // Índice para la primera mitad
            int j = mitad + 1;    // Índice para la segunda mitad
            int k = 0;            // Índice para el arreglo temporal

            // Comparar elementos de las dos mitades y agregarlos en orden al arreglo temporal
            while (i <= mitad && j <= fin)
            {
                if (arr[i] <= arr[j])
                    temp[k++] = arr[i++];  // Agregar el número de la primera mitad si es menor
                else
                    temp[k++] = arr[j++];  // Si no, agregar el de la segunda mitad
            }

            // Copiar lo que queda de la primera y segunda mitad
            while (i <= mitad) temp[k++] = arr[i++];
            while (j <= fin) temp[k++] = arr[j++];

            // Poner los valores ordenados de nuevo en el arreglo original
            for (i = inicio, k = 0; i <= fin; i++, k++)
                arr[i] = temp[k];
        }

        static void Main(string[] args)
        {
            Program programa = new Program();

            // Pedir al usuario que ingrese cuántos números quiere ordenar
            Console.Write("Cantidad de números: ");
            int n = int.Parse(Console.ReadLine());
            int[] numeros = new int[n]; // Crear el arreglo de números con la cantidad indicada

            // Pedir al usuario que ingrese cada número del arreglo
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Número {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            // Llamar al método para ordenar los números usando el algoritmo de dividir y vencerás
            programa.Ordenar(numeros, 0, n - 1);

            // Mostrar el arreglo de números ya ordenados utilizando for
            Console.WriteLine("Números ordenados:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(numeros[i] + " "); // Imprimir cada número ordenado
            }

            Console.ReadKey(); 
        }
    }
}

