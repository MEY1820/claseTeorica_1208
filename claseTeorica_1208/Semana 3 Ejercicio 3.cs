using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseTeorica_1208
{
    class Semana_3_Ejercicio_3
    {
        static void Main(string[] args)
        {
            // 3- crear un diccionario con los datos de 4 familiares, almacene el nombre y la edad, incluya sus datos

            Dictionary<string, int> Family = new Dictionary<string, int>();

            Family.Add("Jose Antonio Reyes Flores", 54);
            Family.Add("Deysi Nohemy Medina Fuentes", 42);
            Family.Add("Daylin Krisali Reyes Medina", 12);
            Family.Add("Meylin Nohely Reyes Medina", 18);

            foreach(KeyValuePair<string, int> Familiares in Family)
            {
                Console.WriteLine("Clave: {0}, Valor: {1}", Familiares.Key, Familiares.Value);

            }

            //elementos ordenados del diccionario familiar

            var dicc = Family.Keys.ToList();
            dicc.Sort();

            Console.WriteLine("Diccionario De La Familia Ordenado");

            foreach (var item in dicc)
            {
                Console.WriteLine("{0}: {1}", item, Family[item]);

            }

            //contar los elementos del diccionario familiar

            Console.WriteLine("Elementos En El Diccionario Familia: {0}", Family.Count);

            Console.ReadKey();



        }
        
    }
}
