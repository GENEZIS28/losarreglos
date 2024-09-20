using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arreglo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arreglo que lea 10 numeros, suma los numeros pares e impares por separado 
            //Nicole:)
            //contastante 
            const int tam = 10;
            int sumapar = 0;
            int sumaimpar = 0;

            int[] numeros = new int[tam];
            Console.WriteLine("Digite los datos del arreglo");
            Console.WriteLine();
            for (int i = 0; i < tam; i++)
            {
                //lectura 
                Console.Write("Ingrese un numero:");
                numeros[i] = int.Parse(Console.ReadLine());
            }


            //imprime
            Console.WriteLine();
            Console.WriteLine("Datos del arreglo:");
            Console.WriteLine();
            for(int i = 0;i < tam; i++)
            {
                //imprimirlo
                Console.Write(numeros[i] + ",");
                //suma
                if (numeros[i] % 2 == 0)
                {
                    sumapar += numeros[i];

                }
                else
                {
                    sumaimpar += numeros[i];

                }

            }

            Console.WriteLine();
            Console.WriteLine("La suma de los numeros pares es:" + sumapar);
            Console.WriteLine("La suma de los numeros impares es:" + sumaimpar);


            Console.ReadKey();  
        }
    }
}
