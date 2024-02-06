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
            Console.WriteLine($"Ejemplo con listas");
            Console.WriteLine($"-------------------");
            ObtenerValoresListado(listaInt, out lv);
            Console.WriteLine($"La lista inicial es: {lv}");

            Console.WriteLine("Agregamos el elemento 4 a la lista");
            listaInt.Add(4);
            ObtenerValoresListado(listaInt, out lv);
            Console.WriteLine($"La lista es: {lv}"); 

            Console.WriteLine("Agregamos los elementos 5,6,7,9 a la lista");
            listaInt.AddRange([ 5, 6, 7, 9]);
            ObtenerValoresListado(listaInt, out lv);
            Console.WriteLine($"La lista es: {lv}");

            Console.WriteLine("Removeremos el elemento 9 de la lista");
            listaInt.Remove(9);
            ObtenerValoresListado(listaInt, out lv);
            Console.WriteLine($"La lista es: {lv}"); 

            Console.WriteLine("¿En qué posición está el elento 6?");
            Console.WriteLine($"el elemento 6 está en la posición: {listaInt.IndexOf(6)+1}");

            Console.WriteLine("¿La lista contiene el elemento 9?");
            Console.WriteLine(listaInt.Contains(9));

            Console.WriteLine($"La lista tiene un total de: {listaInt.Count} elementos");

            Console.WriteLine("Removeremos el elemento en la quinta posición de la lista");
            listaInt.RemoveAt(4);
            ObtenerValoresListado(listaInt, out lv);
            Console.WriteLine($"La lista es: {lv}");
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
    }
}
