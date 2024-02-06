using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones.ejemplo_diccionario
{
    public class diccionarios
    {
        public diccionarios()
        {
            Dictionary<string,int> diccionario = new Dictionary<string, int> 
            {
                {"uno",1 },
                {"dos",2 },
                {"tres",3 }
            };
            Console.WriteLine($"Ejemplo con diccionario");
            Console.WriteLine($"-------------------");
            ObtenerValorKeyDiccionario(diccionario);

            Console.WriteLine("Agregamos el elemento con la clave cinco y valor 5");
            diccionario.Add("cinco",5);
            ObtenerValorKeyDiccionario(diccionario);

            Console.WriteLine($"El valor de la clave tres es: {diccionario["tres"]}");

            Console.WriteLine($"La clave con el valor de 2 es: { diccionario.Where(p => p.Value == 2).Select(p => (string)p.Key).FirstOrDefault()  }");

            Console.WriteLine($"¿Existe la clave seis?: {diccionario.ContainsKey("seis")}");

            Console.WriteLine("Removemos la clave tres");
            diccionario.Remove("tres");
            ObtenerValorKeyDiccionario(diccionario);

        }
        public void ObtenerValorKeyDiccionario(Dictionary<string,int> dicc) 
        {
            Console.WriteLine("Los elementos del diccionario son:");
            foreach (KeyValuePair<string,int> d in dicc) 
            {
                //Console.WriteLine("La clave: {0} tiene como valor: {1}",d.Key,d.Value);
                Console.WriteLine($"La clave: {d.Key} tiene como valor: {d.Value}");
            }
        }
    }
}
