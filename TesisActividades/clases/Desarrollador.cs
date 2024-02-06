using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TesisActividades.assets.Variables;

namespace TesisActividades.Clases
{
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
}
