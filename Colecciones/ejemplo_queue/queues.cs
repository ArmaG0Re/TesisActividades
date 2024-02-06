using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones.ejemplo_queue
{
    public class queues
    {
        public queues()
        {
            Queue<int> cola = new Queue<int> { };
            cola.Enqueue(1);
            cola.Enqueue(2);
            cola.Enqueue(3);
            cola.Enqueue(4);
            cola.Enqueue(5);
            Console.WriteLine($"Ejemplo con queue");
            Console.WriteLine($"-------------------");
            ObtenerElementoCola(cola);

            Console.WriteLine("Agregamos el elemento 10 a la coleccón");
            cola.Enqueue(10);
            ObtenerElementoCola(cola);

            Console.WriteLine("Eliminamos un elemento de la colección");
            cola.Dequeue();
            ObtenerElementoCola(cola);

           
            
        }
        public void ObtenerElementoCola(Queue<int> cola) 
        {
            foreach (int q in cola) 
            {
                Console.WriteLine($"Los elementos de la cola son: {q}");
            }
        }
    }
}
