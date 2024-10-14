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
        // Método para encontrar el número máximo en un arreglo
        static int EncontrarMaximo(int[] arr, int inicio, int fin)
        {
            // Si solo hay un elemento, devolverlo
            if (inicio == fin)
            {
                return arr[inicio];
            }

            // Calcular el punto medio
            int mitad = (inicio + fin) / 2;

            // Llamadas recursivas para encontrar el máximo en ambas mitades
            int maxIzquierda = EncontrarMaximo(arr, inicio, mitad);
            int maxDerecha = EncontrarMaximo(arr, mitad + 1, fin);

            // Comparar y devolver el máximo de las dos mitades
            return Math.Max(maxIzquierda, maxDerecha);
        }

        static void Main(string[] args)
        {
            // Pedir la cantidad de elementos
            Console.Write("Ingrese la cantidad de números a ingresar: ");
            int n = int.Parse(Console.ReadLine());

            // Crear el arreglo
            int[] numeros = new int[n];

            // Ingresar los elementos del arreglo
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Número {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            // Llamar al método para encontrar el número máximo
            int maximo = EncontrarMaximo(numeros, 0, n - 1);

            // Imprimir el resultado
            Console.WriteLine("El número más grande en el arreglo es: " + maximo);
            Console.ReadKey();
        }
    }
}

