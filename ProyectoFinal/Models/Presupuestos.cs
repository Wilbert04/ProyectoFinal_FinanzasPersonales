using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal.Models
{
    public class Presupuestos
    {
        [Key]
        public int PresupuestoId { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public virtual List<PresupuestoDetalle> Detalle { get; set; }

        public Presupuestos()
        {

            this.Detalle = new List<PresupuestoDetalle>();
        }
    }

}
