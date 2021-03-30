using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal.Models
{
    public class PresupuestoDetalle
    {
        public int Id { get; set; }
        public int PresupuestoId { get; set; }
        public int Gastos { get; set; }
        public decimal Monto { get; set; }

        public PresupuestoDetalle()
        {
            this.Id = 0;
            this.PresupuestoId = 0;
            this.Gastos = 0;
            this.Monto = 0;
        }

    }
}
