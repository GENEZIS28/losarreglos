using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //programa lea toda esta información correspondiente a las ventas del mes anterior,
            //y que resuma las ventas totales por vendedor y por producto.
            // Constantes: 4 vendedores y 5 productos

            const int V = 4; // V=Vendedores
            const int P = 5; // P=Productos

            // Matriz para almacenar las ventas
            double[,] tablal = new double[P, V];

            // Volantes que llevan: número del vendedor, número del producto, valor del producto
            int[,] volantes = new int[,]
            {
            { 2, 3, 10 }, { 1, 1, 30 }, { 3, 4, 40 }, { 2, 1, 20 }, { 3, 4, 15 }, { 3, 5, 5 },
            { 4, 2, 10 }, { 4, 5, 5 }, { 1, 5, 20 }, { 2, 4, 10 }, { 3, 5, 5 }, { 4, 4, 20 },
            { 1, 2, 30 }, { 1, 5, 30 }, { 1, 1, 10 }, { 1, 2, 30 }, { 2, 2, 50 }, { 2, 1, 30 },
            { 2, 3, 40 }, { 3, 1, 50 }, { 3, 2, 10 }, { 4, 2, 20 }, { 4, 4, 30 }, { 4, 1, 50 }
            };

            // Llenar la matriz de ventas con los valores de los volantes
            for (int i = 0; i < volantes.GetLength(0); i++)
            {
                int vendedor = volantes[i, 0] - 1;  // Ajustar índice para empezar desde 0
                int producto = volantes[i, 1] - 1;  // Ajustar índice para empezar desde 0
                double venta = volantes[i, 2];      // Valor de la venta

                // Sumar la venta en la matriz de ventas
                tablal[producto, vendedor] += venta;
            }

            // Imprimir encabezados de vendedores
            Console.WriteLine("Ventas por vendedor y producto:");
            Console.WriteLine();

            
            for (int v = 0; v < V; v++)
            {
                Console.Write($"\tVendedor {v + 1}");
            }
            Console.WriteLine("\tTProducto");

            // Variables para totales por vendedor
            double[] totalVendedor = new double[V];
            double totalGlobal = 0;

            // Imprimir la tabla de ventas por producto
            for (int p = 0; p < P; p++)
            {
                double totalProducto = 0;
                Console.Write($"Producto {p + 1}\t");

                for (int v = 0; v < V; v++)
                {
                    Console.Write($"{tablal[p, v]}\t\t");
                    totalProducto += tablal[p, v];  // Sumar para el total de productos
                    totalVendedor[v] += tablal[p, v];  // Sumar para el total de vendedores
                }

                Console.WriteLine($"{totalProducto}");  // Total por producto
                totalGlobal += totalProducto;  // Sumar para el total global
            }

            // Imprimir totales por vendedor
            Console.Write("TVendedor\t");
            for (int v = 0; v < V; v++)
            {
                Console.Write($"{totalVendedor[v]}\t\t");
            }
            

            Console.ReadKey();










        }

       
    }
}
