using TesisActividades.Clases;
using static TesisActividades.assets.Variables;

namespace TesisActividades // El namespace depende del nombre que le diste al proyecto al iniciarlo.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ObtenerDesarrollador();
        }

        private static void ObtenerDesarrollador()
        {
           Desarrollador desarrollador1 = new Desarrollador();
            desarrollador1.Nombre = "Armando González Reta";
            desarrollador1.FechaIngreso = DateTime.Now;
            desarrollador1.Email = "prueba@hotmail.com";
            desarrollador1.Categoria = CategoriaNivel.Nivel1;
            desarrollador1.Proyectos = new List<Proyecto>() 
            { 
                ObtenerProyecto()
            };
            Console.WriteLine($"Nombre: {desarrollador1.Nombre}, Email: {desarrollador1.Email}, Proyectyo: {desarrollador1.Proyectos[0].Nombre}");
        }

        private static Proyecto ObtenerProyecto()
        {
            Proyecto proyecyo1 = new Proyecto();
            proyecyo1.Nombre = "UMBRELLA";
            proyecyo1.Categoria = CategoriaNivel.Nivel3;
            proyecyo1.DuracionHoras = 80;
            proyecyo1.FechaInicio = DateTime.Now;
            return proyecyo1;
        }

    }
}