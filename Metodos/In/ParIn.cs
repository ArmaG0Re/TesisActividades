using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos.In
{
    public class ParIn
    {
        public ParIn()
        {
            //EL método NO asigna valor al parametro, el parametro enviado tiene que estar inicializado.
            //No es necesario indicar que el parametro sea IN
            Console.WriteLine("Metodo con parametros entrada (in");
            Console.WriteLine("_______________");
            int inValue = 0;
            MetodoParIn(inValue);
            Console.WriteLine($"Valor in: {inValue}");
        }
        private static void MetodoParIn(in int value)
        {
            //value = 10; 
        }

    }
}
