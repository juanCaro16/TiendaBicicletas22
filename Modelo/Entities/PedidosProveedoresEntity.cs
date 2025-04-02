using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entities
{
    public class PedidosProveedoresEntity
    {
        public int id { get; set; }
        public DateTime fecha_pedido { get; set; }
        public string estado { get; set; }
        public int proveedor_id { get; set; }
    }
}
