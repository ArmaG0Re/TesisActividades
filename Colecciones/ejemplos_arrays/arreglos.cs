using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones.ejemplos_arrays
{
    public class arreglos
    {
        public arreglos()
        {
            Console.WriteLine($"Ejemplo con array unidimensional");
            Console.WriteLine($"-------------------");
            int[] arrayInt = new int[5];
            Console.WriteLine($"El arreglo inicializado tiene valores por defecto, en caso de enteros es: {arrayInt[0]}");
            string[] arrayString = ["uno", "dos", "tres", "cuatro", "cinco"];
            ObtenerArrayUnidimensional(in arrayString);
            Console.WriteLine("Cambiamos los valores del arreglo");
            arrayString[0] = "seis";
            arrayString[1] = "siete";
            arrayString[2] = "ocho";
            arrayString[3] = "nueve";
            arrayString[4] = "diez";
            ObtenerArrayUnidimensional(arrayString);
            Console.WriteLine($"Ejemplo con array multidimensional");
            Console.WriteLine($"-------------------");
            int[,] array2D = new int[2,2];
            array2D[0,0] = 0; 
            array2D[0,1] = 1;
            array2D[1,0] = 2;
            array2D[1,1] = 3;
            ObtenerArrayMultidimensional(array2D);
            Console.WriteLine($"Ejemplo con array tridimensional");
            Console.WriteLine($"-------------------");
            //int[,,] array3D = new int[,,] 
            //{
            //    {
            //        {1,2,3}
            //    },
            //    {
            //        {4,5,6 }
            //    }
            //};
            int[,,] array3D = new int[2,1,3];
            array3D[0, 0, 0] = 1;
            array3D[0, 0, 1] = 2;
            array3D[0, 0, 2] = 3;
            array3D[1, 0, 0] = 4;
            array3D[1, 0, 1] = 5;
            array3D[1, 0, 2] = 6;
            ObtenerArrayTridimensional(array3D);
        }

        public void ObtenerArrayUnidimensional(in string[] strings) 
        {
            foreach(string str in strings)
            {
                Console.WriteLine($"Elemento con valor de {str} del array unidimensional");
            }
        }

        public void ObtenerArrayMultidimensional(int[,] strings2D)
        {
            var i = 0;
            var j = 0;
            while (i < strings2D.GetLength(0)) 
            {
                while (j < strings2D.GetLength(1))
                {
                    Console.WriteLine(strings2D[i, j]);
                    j++;
                }
                j = 0;
                i++;
            }
        }
        public void ObtenerArrayTridimensional(int[,,] strings3D)
        {
            var i = 0;
            var j = 0;
            var k = 0;
            while (i < strings3D.GetLength(0))
            {
                while (j < strings3D.GetLength(1))
                {
                    while (k < strings3D.GetLength(2))
                    {
                        Console.WriteLine(strings3D[i, j, k]);
                        k++;
                    }
                    k = 0;
                    j++;
                }
                j = 0;
                i++;
            }
        }
    }
}
