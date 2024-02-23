using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos.RefOnly
{
    public class ParRefOnly
    {
        public ParRefOnly()
        {
            //EL método NO asigna valor al parametro, el parametro enviado tiene que estar inicializado.
            //Es necesario indicar que el parametro sea ref readonly
            Console.WriteLine("Metodo con parametros readonly ref");
            Console.WriteLine("_______________");
            int roValue = 100;
            MetodoParRefReadO(ref roValue);
            Console.WriteLine($"Valor ref readonlye: {roValue}");
        }

        public static void MetodoParRefReadO(ref readonly int ro)
        {
            //ro = 10;
        }

    }
}
