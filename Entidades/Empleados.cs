using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Empleados
    {
        [Key]
        public int EmpleadoId { get; set; }
        public string Nombres { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public double Sueldo { get; set; }

        public virtual List<Retenciones> retencionList { get; set; }

        public Empleados()
        {
            this.retencionList = new List<Retenciones>();
        }
    }
}
