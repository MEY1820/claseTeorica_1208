using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseTeorica_1208
{
    class Semana_3_Ejercicio_2
    {
        static void Main(char[] argumentos)
        {
            // escribir un ciclo que permita capturar los valores
            // almacenar en el arreglo de numbers con un tamaño de 10
            // 2- Calcular e imprimir el promedio de los numeros almacenados 


            int[] numbers = new int[10];
            int sumatoria = 0;

            for (int f = 0; f < numbers.Length; f++)
            {
              Console.WriteLine(" Ingrese un número ");
              numbers[f] = Convert.ToInt32(Console.ReadLine());
              sumatoria = sumatoria + numbers[f];
          
            }
            Console.WriteLine(" Los numeros que usten ha ingresado son: ");
            foreach (int intem in numbers)  
            {
                Console.WriteLine(intem);

            }
            Console.WriteLine(" La sumatoria de los números que se ingresaron es de: {0} ", sumatoria);
            Console.WriteLine(" El promedio de los números que se ingresaron es de: {0} ", sumatoria / (numbers.Length));
            Console.ReadKey();
        }
    }

}    

