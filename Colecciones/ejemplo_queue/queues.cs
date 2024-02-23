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
            //Coleccion que representa el primero que entra el primero que sale
            Queue<int> cola = new Queue<int> { };
            cola.Enqueue(1);
            cola.Enqueue(2);
            cola.Enqueue(3);
            cola.Enqueue(4);
            cola.Enqueue(5);
            Console.WriteLine($"Ejemplo con queue");
            Console.WriteLine($"-------------------");
            ObtenerElementoCola(cola);
            Console.WriteLine($"");

            Console.WriteLine("Agregamos el elemento 10 a la coleccón");
            cola.Enqueue(10);
            ObtenerElementoCola(cola);
            Console.WriteLine($"");

            Console.WriteLine("Eliminamos un elemento de la colección");
            cola.Dequeue();
            ObtenerElementoCola(cola);
            Console.WriteLine($"");

            Console.WriteLine("Mostramos el elemento más viejo de la queque");
            Console.WriteLine(cola.Peek());

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
