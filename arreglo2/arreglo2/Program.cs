using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arreglo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //programa que almacena los datos(10 numeros) en la tabla: Arreglo bidimencionales
            //suma cada fila y cada columna, nicole :)

            //matriz
            int[,] tabla1 = new int[3, 3];
            int f, c; //f:filas, c:columnas
            
            //para filas
            int sumafila3 =0;
            int sumafila2 =0;
            int sumafila1 =0;
            //para columnas 
            int sumacolum1=0;   
            int sumacolum2 =0; 
            int sumacolum3 =0;

            Console.WriteLine("Ejemplos de arreglos bidimencionales");
            Console.WriteLine("Digite los datos del arreglo:");

            //lee
            for (f=0; f<3; f++)
            {
                for(c=0; c<3; c++)
                {
                    tabla1[f,c] =int.Parse(Console.ReadLine());
                }
            }

            //imprime el arreglo 
            Console.WriteLine("imprime el arreglo");
            for (f = 0; f < 3; f++)
            {
                for (c = 0; c < 3; c++)
                {
                    Console.Write("" + tabla1[f, c]);
                }
                Console.WriteLine("");
            }

            
            //suma de fila 1
            
            for (f = 0; f < 1; f++)
            {
                for (c = 0; c < 3; c++)
                {
                    sumafila1 += tabla1[f, c];
                }

            }
            Console.WriteLine("la suma de la fila 1 es:" + sumafila1);

            
            //suma de fila 2
            for (f = 1; f < 2; f++)
            {
                for (c = 0; c < 3; c++)
                {
                    sumafila2 += tabla1[f, c];
                }

            }
            Console.WriteLine("la suma de la fila 2 es:" + sumafila2);

            //suma de fila3
            for (f = 2; f < 3; f++)
            {
                for (c = 0; c < 3; c++)
                {
                    sumafila3 += tabla1[f, c];
                }

            }
            Console.WriteLine("la suma de la fila 3 es:" + sumafila3);

           //suma de columna 1
            for (f = 0; f < 3; f++)
            {
                for (c = 0; c < 1; c++)
                {
                    sumacolum1 += tabla1[f, c];
                }

            }
            Console.WriteLine("la suma de la columna 1 es:" + sumacolum1);

           
            //suma de columna 2
            for (f = 0; f < 3; f++)
            {
                for (c = 1; c < 2; c++)
                {
                    sumacolum2 += tabla1[f, c];
                }

            }
            Console.WriteLine("la suma de la columna 2 es:" + sumacolum2);

            //suma de columna 3
            for (f = 0; f < 3; f++)
            {
                for (c = 2; c < 3; c++)
                {
                    sumacolum3 += tabla1[f, c];
                }

            }
            Console.WriteLine("la suma de la columna 3 es:" + sumacolum3);


            Console.ReadKey();

        }
    }
}
