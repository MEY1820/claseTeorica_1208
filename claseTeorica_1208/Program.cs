using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseTeorica_1208
{
    class Program
    {
        static void Main(string[] args)
        {
            //llamado al metodo loops
            loops();

            Console.ReadLine();
        }

        //bucles
        public static void loops()
        {
            int[] numbers = new int[3];
            numbers[0] = 5;
            numbers[1] = 10;
            numbers[2] = 15;

            //capturar los valores a almacenar en el array
            for (int x = 0; x < numbers.Length; x++)
            {
                Console.Write("Escriba el valor para el elemento {0}: ", x);

            }
            //ciclo while
            int i = 0;
            Console.WriteLine("IMPRIME ELEMENTOS CON WHILE");
            while (i < numbers.Length)
            {
                Console.WriteLine(numbers[i]);
                i = i + 1; //i++
            }

            Console.WriteLine("IMPRIME ELEMENTOS CON DO-WHILE");
            int inc = 0;
            do
            {
                Console.WriteLine(numbers[inc]);
                inc++;
            } while (inc < numbers.Length);

            Console.WriteLine("IMPRIME ELEMENTOS CON FOR");
            for (int j = 0; j < numbers.Length; j++)
            {
                Console.WriteLine("Posicion {0} : {1}", j, numbers[j]);
            }

            Console.WriteLine("IMPRIME ELEMENTOS CON FOREACH");
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

        }


    }
}

   
