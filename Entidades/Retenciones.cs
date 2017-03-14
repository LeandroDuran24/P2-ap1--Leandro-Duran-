using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Retenciones
    {
        [Key]
        public int RetencionId { get; set; }
        public string Descripcion { get; set; }
        public int Valor { get; set; }

        public virtual List<Empleados>EmpleadosList { get; set; }

        public Retenciones()
        {
            this.EmpleadosList = new List<Empleados>();
        }
    }
}
