using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Producto
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        
        public double PrecioVenta { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public bool EstaActivo { get; set; }

        public DateTime? FechaVencimiento { get; set; }

        public double IGV{get;set;}

    }
}
