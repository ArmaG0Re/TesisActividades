using System.Security.Cryptography.X509Certificates;
using TesisActividades.Clases;
using static TesisActividades.assets.Variables;

namespace TesisActividades // El namespace depende del nombre que le diste al proyecto al iniciarlo.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ObtenerDesarrollador();
            //Método con parametros referenciados
            int refValue = 10;
            Console.WriteLine($"El valor inicial es {refValue}");
            MetodoParRef(ref refValue);
            Console.WriteLine($"El valor referido es {refValue}");
            //Mmétodo con parametros out
            int outValue;
            MetodoParOut(out outValue);
            Console.WriteLine($"Valor salida: {outValue}");
            //Metodos con parametros in
            int inValue=0;
            MetodoParIn( inValue);
            Console.WriteLine($"Valor in: {inValue}");
            //MEtodos con parametro readonly ref
            int roValue = 100;
            MetodoParRefReadO(ref roValue);
            Console.WriteLine($"Valor ref readonlye: {roValue}");
            MetodoDirecto();
            //Prueba con parametros dinamicos
            MetodoParams(); //Sin valor
            MetodoParams(null); //Valor null
            MetodoParams("4", "3", "2", "1"); //Valores multiples
            MetodoParams(["4", "3", "2", "1"]); //arreglo
            //Método multiple return
            var tupla = MetodoMultipleReturn();
            Console.WriteLine($"Primer elemento {tupla.Entero}, segundo elementod {tupla.String}, tercer elemento {tupla.Item3}");

        }

        #region PruebaMétodos
        private static void MetodoParRef(ref int v)
        {
            v = 100;
        }
        private static void MetodoParams(params string[]? values)
        {
            //Codigo
        }
        public static void MetodoDirecto() => Console.WriteLine("Metodo directo");
        private static void MetodoParOut(out int outValue)
        {
            outValue = 50;
        }
        private static void MetodoParIn(in int value)
        {
            //value = 10; 
            //Los parametros in, solo son parametros que no se les permite cambiar el valor del parametro
            //A pesar de pedir una variable con referencia in, este no asegura que pasemos un parametro con referencia
        }
        public static void MetodoParRefReadO(ref readonly int ro) 
        {
            //ro = 10;
            //AL igual que in, este no deja editar, sin embargo ref readonly se asegura que el parametro si sea referencia
        }
        private static (int Entero, string String,double) MetodoMultipleReturn()
        {
            return ( 10,"Diez",10.1);
        }
        #endregion

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