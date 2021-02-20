using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_Con_Detalle.Entidades
{
    class Ordenes
    {
        [Key]

        public int OrdenesId { get; set; }
        public DateTime Fecha { get; set; }

        [ForeignKey("OrdenesId")]
        public virtual List<OrdenesDetalle> OrdenesDetalles { get; set; }
    
        public Ordenes()
        {
            OrdenesId = 0;
            Fecha = DateTime.Now;

            OrdenesDetalles = new List<OrdenesDetalle>();
        }
    }
}
