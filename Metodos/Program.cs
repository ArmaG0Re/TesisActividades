
namespace Metodos // El namespace depende del nombre que le diste al proyecto al iniciarlo.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //MEtodos con parametro readonly ref
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
       
        private static void MetodoParams(params string[]? values)
        {
            //Codigo
        }
        public static void MetodoDirecto() => Console.WriteLine("Metodo directo");
       
       
       
        private static (int Entero, string String, double) MetodoMultipleReturn()
        {
            return (10, "Diez", 10.1);
        }
    }
}