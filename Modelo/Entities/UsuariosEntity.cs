﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entities
{
    public class UsuariosEntity
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public DateTime fecha_registro { get; set; }
        public string contraseña { get; set; }
        public string rol_id { get; set; }
    }
}