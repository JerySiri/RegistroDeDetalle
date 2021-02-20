using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_Con_Detalle.Entidades
{
    class Producto
    {
        public int ProductoId { get; set; }
        public string Nombre { get; set; }

        public Producto()
        {
            ProductoId = 0;
            Nombre = string.Empty;
        }

    }
}
