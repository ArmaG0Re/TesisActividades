// See https://aka.ms/new-console-template for more information
Desarrollador desarrollador = new Desarrollador();
desarrollador.Nombre = "Armando Gonzalez";
desarrollador.Categoria = CategoriaNivel.Nivel1;

public class Desarrollador
{
    public string Nombre { get; set; }
    public DateTime FechaIngreso { get; set; }
    public string Email { get; set; }
    public CategoriaNivel Categoria { get; set; }
    public List<Proyecto> Proyectos { get; set; }

    // Métodos para asignar proyecto.
    public void AsignarProyecto(Proyecto proyecto)
    {
        Proyectos.Add(proyecto);
    }
}

public class Proyecto
{
    public string Nombre { get; set; }
    public CategoriaNivel Categoria { get; set; }
    public int DuracionHoras { get; set; }
    public DateTime FechaInicio { get; set; }
    public Desarrollador Desarrollador { get; set; }
    public Dictionary<DateTime, int> HorasTrabajadasPorDia { get; set; }

    // Método para registrar horas trabajadas.
    public void RegistrarHoras(DateTime fecha, int horas)
    {
        if (HorasTrabajadasPorDia.ContainsKey(fecha))
        {
            HorasTrabajadasPorDia[fecha] += horas;
        }
        else
        {
            HorasTrabajadasPorDia.Add(fecha, horas);
        }
    }

    // Método para calcular las horas restantes en el proyecto.
    public int HorasRestantes()
    {
        int totalHorasTrabajadas = HorasTrabajadasPorDia.Values.Sum();
        return DuracionHoras - totalHorasTrabajadas;
    }
}

public enum CategoriaNivel 
{
    Nivel1 = 1,
    Nivel2 = 2,
    Nivel3 = 3
}
