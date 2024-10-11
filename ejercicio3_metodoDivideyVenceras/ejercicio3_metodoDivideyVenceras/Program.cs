/*
 Programa que busca el número más grande en una lista dividiéndola en mitades recursivamente. 
 Luego, compara los números de ambas mitades para encontrar el mayor.
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

        // Inicializar la variable para encontrar el número más grande
        int maximo = numeros[0];

        // Buscar el número más grande
        for (int i = 1; i < cantidad; i++)
        {
            if (numeros[i] > maximo)
            {
                maximo = numeros[i];
            }
        }

        // Mostrar el número más grande
        Console.WriteLine("El número más grande es: " + maximo);
    }
}

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo3_DivideyVenceras
{
    internal class Program
    {
        // Método para encontrar el máximo 
        static int FindMax(int[] arr, int low, int high)
        {
            // Caso base: si solo queda un elemento, es el máximo en esa porción
            if (low == high)
            {
                return arr[low]; // Se devuelve el único elemento
            }

            // Se divide el arreglo en dos mitades
            int mid = (low + high) / 2;

            // Se busca el máximo en la mitad izquierda aqui se usa el divide y vencerás)
            int leftMax = FindMax(arr, low, mid);

            // Se busca el máximo en la mitad derecha aqui se usa el divide y vencerás
            int rightMax = FindMax(arr, mid + 1, high);

            // Se compara el máximo de ambas mitades y se devuelve el más grande
            return Math.Max(leftMax, rightMax);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Programa para encontrar el máximo en una lista de numeros (ENTEROS)");
            Console.WriteLine();
            // Se pide al usuario que ingrese una serie de números separados por espacio
            Console.Write("Ingrese números separados por espacio: ");
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            // Llama al método FindMax para encontrar el número más grande
            int maxNumber = FindMax(numbers, 0, numbers.Length - 1);

            // Se muestra el número más grande
            Console.WriteLine($"El número más grande es: {maxNumber}");

            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}

