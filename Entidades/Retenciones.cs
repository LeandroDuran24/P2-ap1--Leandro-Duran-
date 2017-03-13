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
        public int RetencionesId { get; set; }
        public string Descripcion { get; set; }
        public int Valor { get; set; }

        public virtual List<Empleados>empleadosList { get; set; }

        public Retenciones()
        {
            this.empleadosList = new List<Empleados>();
        }
    }
}
