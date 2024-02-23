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
            //Una clave no puede ser NULL
            //Un valor puede ser null dependiendo su construcción
            //KeyValuePair<Tk,Tv> es cada elemento del diccionario
            Dictionary<string,int> diccionario = new Dictionary<string, int> 
            {
                {"uno",1 },
                {"dos",2 },
                {"tres",3 }
            };

            Console.WriteLine($"Ejemplo con diccionario");
            Console.WriteLine($"-------------------");
            ObtenerValorKeyDiccionario(diccionario);
            Console.WriteLine($"");

            Console.WriteLine($"Obtenemos el valor de la clave 'dos' del diccionario: {diccionario["dos"]}");
            Console.WriteLine($"");

            Console.WriteLine($"Existe la clave 'cuatro',  {diccionario.TryGetValue("cuatro",out int value)}");
            Console.WriteLine($"");

            Console.WriteLine($"Existe la clave 'tres', {diccionario.TryGetValue("tres", out int value2)}");
            Console.WriteLine($"");

            Console.WriteLine($"Existe el valor '4', {diccionario.ContainsValue(4)}");
            Console.WriteLine($"");

            Console.WriteLine($"Existe el valor '3', {diccionario.ContainsValue(3)}");
            Console.WriteLine($"");

            Console.WriteLine("Agregamos el elemento con la clave 'cinco' y valor 5");
            diccionario.Add("cinco",5);
            ObtenerValorKeyDiccionario(diccionario);
            Console.WriteLine($"");

            Console.WriteLine($"La clave con el valor de 2 es: { diccionario.Where(p => p.Value == 2).Select(p => (string)p.Key).FirstOrDefault()  }");
            Console.WriteLine($"");

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
