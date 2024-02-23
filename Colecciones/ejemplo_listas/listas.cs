using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones.ejemplo_listas
{
    public class listas
    {
        public listas()
        {
            string lv;
            List<int> listaInt = new List<int> { 1, 2, 3 };
            List<string> listaStr = new List<string> { "hola", "Amigo", "enemigO" };
            List<int> Fibonacci = new List<int> { 1, 1 };

            Console.WriteLine($"Ejemplo con listas");
            Console.WriteLine($"-------------------");
            ObtenerValoresListado(listaInt, out lv);
            Console.WriteLine($"La lista inicial es: {lv}");
            Console.WriteLine($"");

            Console.WriteLine("Agregamos el elemento 4 a la lista");
            listaInt.Add(4);
            ObtenerValoresListado(listaInt, out lv);
            Console.WriteLine($"La lista es: {lv}");
            Console.WriteLine($"");

            Console.WriteLine("Agregamos los elementos 5,6,7,9 a la lista");
            listaInt.AddRange([ 5, 6, 7, 9]);
            ObtenerValoresListado(listaInt, out lv);
            Console.WriteLine($"La lista es: {lv}");
            Console.WriteLine($"");

            Console.WriteLine("Removeremos el elemento 9 de la lista");
            listaInt.Remove(9);
            ObtenerValoresListado(listaInt, out lv);
            Console.WriteLine($"La lista es: {lv}");
            Console.WriteLine($"");

            Console.WriteLine("¿En qué posición está el elento 6?");
            Console.WriteLine($"el elemento 6 está en la posición: {listaInt.IndexOf(6)+1}");
            Console.WriteLine($"");

            Console.WriteLine("¿La lista contiene el elemento 9?");
            Console.WriteLine(listaInt.Contains(9));
            Console.WriteLine($"");

            Console.WriteLine($"La lista tiene un total de: {listaInt.Count} elementos");
            Console.WriteLine($"");

            Console.WriteLine("Removeremos el elemento en la quinta posición de la lista");
            listaInt.RemoveAt(4);
            ObtenerValoresListado(listaInt, out lv);
            Console.WriteLine($"La lista es: {lv}");
            Console.WriteLine($"");

            Console.WriteLine("Obtendremos los elementos de la lista en mayuscula");
            ObtenerValoresListado(listaStr, out lv);
            Console.WriteLine($"La lista orginal: {lv}");
            ObtenerValoresListadoMatuscula(listaStr, out lv);
            Console.WriteLine($"La lista modificada es: {lv}");
            Console.WriteLine($"");

            Console.WriteLine("El indice 3 de la lista de números es:");
            Console.WriteLine($"{listaInt[2]}");
            Console.WriteLine("");

            Console.WriteLine("El índice del elemento 6 es:");
            Console.WriteLine($"{listaInt.IndexOf(6)}");
            Console.WriteLine("");

            Console.WriteLine($"Ordenaremos la lista de números");
            ObtenerValoresListadoOrdenados(listaInt, out lv);
            Console.WriteLine($"lista ordenada:{lv}");
            Console.WriteLine($"Ordenaremos la lista de string");
            ObtenerValoresListadoOrdenados(listaStr, out lv);
            Console.WriteLine($"lista ordenada:{lv}");
            Console.WriteLine("");

            SucesionFibonacci(Fibonacci,out lv,20);
            Console.WriteLine($"Los primeros 20 de la sucesión de fibonacci es: {lv}");



        }
        public string ObtenerValoresListado(List<int> listado, out string lv)
        {
            lv = "";
            foreach (int i in listado)
            {
                lv = lv + i + ",";
            }
            lv= lv.TrimEnd(',');
            return lv;
        }

        public string ObtenerValoresListado(List<string> listado, out string lv)
        {
            lv = "";
            foreach (string l in listado)
            {
                lv = lv + l + ",";
            }
            lv = lv.TrimEnd(',');
            return lv;
        }

        public string ObtenerValoresListadoMatuscula(List<string> listado, out string lv)
        {
            lv = "";
            foreach (string l in listado)
            {
                lv = lv + l.ToUpper() + ",";
            }
            lv = lv.TrimEnd(',');
            return lv;
        }

        public string ObtenerValoresListadoOrdenados(List<string> listado, out string lv)
        {
            listado.Sort();
            lv = "";
            foreach (string l in listado)
            {
                lv = lv + l + ",";
            }
            lv = lv.TrimEnd(',');
            return lv;
        }

        public string ObtenerValoresListadoOrdenados(List<int> listado, out string lv)
        {
            listado.Sort();
            lv = "";
            foreach (int l in listado)
            {
                lv = lv + l + ",";
            }
            lv = lv.TrimEnd(',');
            return lv;
        }

        public string SucesionFibonacci(List<int> fibonacci, out string lv, int posicion) 
        {
            lv = "";
            while (fibonacci.Count() < posicion) 
            {
                var anterior = fibonacci[fibonacci.Count() - 1];
                var anterior2 = fibonacci[fibonacci.Count() - 2];
                var siguiente = anterior + anterior2;
                fibonacci.Add(siguiente);
            }

            foreach (int l in fibonacci)
            {
                lv = lv + l + ",";
            }

            lv = lv.TrimEnd(',');

            return lv;
        }

    }
}
