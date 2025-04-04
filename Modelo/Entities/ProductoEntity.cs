using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entities
{
    public class ProductoEntity
    {
        public int id { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string tipo { get; set; }
        public string tamaño { get; set; }
        public decimal precio { get; set; }
        public int stock { get; set; }
        public string imagen { get; set; }
    }
}
