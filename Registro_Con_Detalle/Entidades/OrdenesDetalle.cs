using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_Con_Detalle.Entidades
{
    public class OrdenesDetalle
    {

        [Key]
        public int OrdenesDetalleId { get; set; }
        public int OrdenesId { get; set; }
        public int ProductoId { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public float precio { get; set; }

        public OrdenesDetalle()
        {
            OrdenesDetalleId = 0;
            OrdenesId = 0;
            ProductoId = 0;
            Cantidad = 0;
            Descripcion = string.Empty;
            precio = 0.0f;
        }

        public OrdenesDetalle(int ordenId, int productoId, int cantidad)
        {
            OrdenesDetalleId = 0;
            OrdenesId = ordenId;
            ProductoId = productoId;
            Cantidad = cantidad;
        }

        public OrdenesDetalle(int OrdenesDetalleId, int OrdenesId, int ProductoId, string Descripcion, int Cantidad, float precio)
        {
            this.OrdenesDetalleId = OrdenesDetalleId;
            this.OrdenesId = OrdenesId;
            this.ProductoId = ProductoId;
            this.Descripcion = Descripcion;
            this.Cantidad = Cantidad;
            this.precio = precio;
        }
    }
}
