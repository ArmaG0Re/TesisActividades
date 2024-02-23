using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos.Out
{
    public class ParOut
    {
        public ParOut()
        {
            //EL método asigna valor al parametro, el parametro enviado no tiene que estar inicializado
            Console.WriteLine("Metodo con parametros sálida (out)");
            Console.WriteLine("_______________");
            int outValue;
            MetodoParOut(out outValue);
            Console.WriteLine($"Valor salida: {outValue}");
        }
        private static void MetodoParOut(out int outValue)
        {
            outValue = 50;
        }
    }
}
