using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo.Entities
{
    class UsuarioEntity
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string email { get; set; }
        public string  contraseña { get; set; }
        public string rol { get; set; }
    }
}
