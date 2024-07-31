using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_08
{
    internal class recetasCulinarias
    {
        public string Nombre { get; set; }
        public string Ingredientes { get; set; }
        public string CantidadPorIngrediente { get; set; }
        public string Utensilios { get; set; } 
        public int TiempoDeCoccion { get; set;}

        public recetasCulinarias(string nombre, string ingredientes, string cantidadingredientes, string utensilios, int tiempococcion)
        {
            Nombre = nombre;
            Ingredientes = ingredientes;
            CantidadPorIngrediente = cantidadingredientes;
            Utensilios = utensilios;
            TiempoDeCoccion = tiempococcion;
        }

    }

}
