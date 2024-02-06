using Colecciones.ejemplo_diccionario;
using Colecciones.ejemplo_listas;
using Colecciones.ejemplo_observablecollection;
using Colecciones.ejemplo_queue;
using Colecciones.ejemplos_arrays;

namespace Colecciones 
{
    public class Program 
    {
        public static void Main(string[] args)
        {
            //Actividad con listas
            listas listaEjemplo = new listas();
            //Actividad con diccionario
            diccionarios diccionarios = new diccionarios();
            //Actividad queue
            queues queues = new queues();
            //Actividad observablecollection
            observableCollection oCollection = new observableCollection();
            //Actividad array
            arreglos arreglos = new arreglos();
        }
    }
}