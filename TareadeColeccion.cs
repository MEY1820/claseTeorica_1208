using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciodeTarea19_08
{
    public class TareadeColeccion
    {
        public static void SortedListCollection()
        {
            // Ejercicio de tarea: crear una biblioteca que permita determinar el numero mayor de una serie.

            int c, d, e;
            Console.WriteLine("PORVAFOR INGRESE EL PRIMER NUMERO");
            c = Convert . ToInt32(Console.ReadLine());
            Console.WriteLine("PORFAVOR INGRESE EL SEGUNDO NUMERO");
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("PORFAVOR INGRESE EL TERCER NUMERO");
            e = Convert.ToInt32(Console.ReadLine());

            if (c > d && c > e )
            {
                Console.WriteLine("El MAYOR SERIA C: {0}", c);
                if (d > e)
                {
                    Console.WriteLine("EL DEL MEDIO SERIA D: {0}", d);
                    Console.WriteLine("EL MENOR SERIA E: {0} ", e);
                }
                else
                {
                    Console.WriteLine("EL DEL MEDIO SERIA E: {0}", e);
                    Console.WriteLine("EL MENOR SERIA D: {0}", d);
                } 
                }
            else
            {
                if (d > c && d > e)
                {
                    Console.WriteLine("EL MAYOR SERIA D: {0}", d);
                    if (c > e)
                    {
                        Console.WriteLine("EL DEL MEDIO SERIA C: {0}", c);
                        Console.WriteLine("EL MENOR SERIA E: {0}", e);
                    }
                    else
                    {
                        Console.WriteLine("EL DEL MEDIO SERIA E: {0}", e);
                        Console.WriteLine("EL MENOR SERIA C: {0}", c);
                    }
                }
                else
                {
                    Console.WriteLine("EL MAYOR SERIA E:");
                    if (c > d)
                    {
                        Console.WriteLine("EL DEL MEDIO SERIA C: {0}", c);
                        Console.WriteLine("EL MENOR SERIA D: {0}", d);
                    }
                    else
                    {
                        Console.WriteLine("EL DEL MEDIO SERIA D: {0}", d);
                        Console.WriteLine("EL MENOR SERIA C: {0}", c);
                    }
                }
            }

               
               
            }


        }
 
    }

