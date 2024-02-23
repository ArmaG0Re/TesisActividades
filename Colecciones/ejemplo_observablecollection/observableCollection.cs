using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones.ejemplo_observablecollection
{
    public class observableCollection
    {
        public observableCollection()
        {
            ObservableCollection<Empleado> empleados = new ObservableCollection<Empleado>();
            empleados.Add(new Empleado { Nombre = "Armando", Edad = 28 });
            empleados.Add(new Empleado { Nombre = "Luis", Edad = 30 });
            empleados.Add(new Empleado { Nombre = "Angel", Edad = 30 });
            empleados.CollectionChanged += Empleados_CollectionChanged;

            Console.WriteLine($"Ejemplo con observableCollection");
            Console.WriteLine($"-------------------");
            ObtenerEmpleado(in empleados);
            Console.WriteLine("Agregamos un nuevo empleado");
            empleados.Add(new Empleado { Nombre = "Julian", Edad = 50 });
            Console.WriteLine($"");

            Console.WriteLine("Removeremos un nuevo empleado");
            empleados.RemoveAt(0);
            ObtenerEmpleado(in empleados);
            Console.WriteLine($"");

        }

        private void Empleados_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add) 
            {
                Console.WriteLine($"Se agregó el siguiente empleado: {((Empleado)e.NewItems[0]).Nombre} y tiene {((Empleado)e.NewItems[0]).Edad} años");
            }
            else if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine($"Se removió el siguiente empleado: {((Empleado)e.OldItems[0]).Nombre} y tiene {((Empleado)e.OldItems[0]).Edad} años");
            }
        }

        public void ObtenerEmpleado(in ObservableCollection<Empleado> empleados)
        {
            empleados.ToList().ForEach(empleado =>
                {
                    Console.WriteLine($"Los empleados son: {empleado.Nombre}");
                });
        }


    }
}