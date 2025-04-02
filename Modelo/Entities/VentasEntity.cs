using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo.Entities
{
    class VentasEntity
    {
        public int id { get; set; }
        public DateTime fecha { get; set; }
        public decimal total { get; set; }
        public string metodo_pago { get; set; }
        public int cliente_id { get; set; }
    }
}
