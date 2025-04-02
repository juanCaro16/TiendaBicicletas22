using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo.Entities
{
    class Detalles_VentaEntity
    {
        public int id { get; set; }
        public int cantidad { get; set; }
        public decimal precio_unitario { get; set; }
        public decimal subtotal { get; set; }
        public int venta_id { get; set; }
        public int bicicleta_id { get; set; }
    }
}
