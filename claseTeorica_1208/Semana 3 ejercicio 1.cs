using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseTeorica_1208
{
    class Semana_3_ejercicio_1
    {
        static void Main(string[] args)
        {
            // 1- escribir un ciclo que permita capturar los valores
            // a almacenar en el arreglo de numbers con un tamaño de 10

            int[] numbers = new int[10];
            for (int j = 0; j < numbers.Length; j++)
            {
                Console.WriteLine($"introduce el numero");
                numbers[j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Los numeros");
            foreach (int item in numbers)
            {
                Console.WriteLine(item);

            }
            Console.ReadKey();
        }
    }
}

