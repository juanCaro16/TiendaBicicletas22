using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo.Entities
{
    class DetallesPedidoEntity
    {
        public int id { get; set; }
        public int cantidad { get; set; }
        public decimal precio_unitario { get; set; }
        public decimal subtotal { get; set; }
        public int pedido_id { get; set; }
        public int bicicleta_id { get; set; }

    }
}
