using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos.Ref
{
    public class ParRef
    {
        public ParRef()
        {
            //El método puede reasignar valor al parametro.
            //El parametro debe ser inicializado y el método puede o no modificar el parametro
            Console.WriteLine("Metodo con parametros referenciados (ref");
            Console.WriteLine("_______________");
            int refValue = 10;
            Console.WriteLine($"El valor inicial es {refValue}");
            MetodoParRef(ref refValue);
            Console.WriteLine($"El valor referido es {refValue}");
        }

        private static void MetodoParRef(ref int v)
        {
            v = 100;
        }


    }
}
