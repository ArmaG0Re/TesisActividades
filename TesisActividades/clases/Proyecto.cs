using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TesisActividades.assets.Variables;

namespace TesisActividades.Clases
{
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
}
