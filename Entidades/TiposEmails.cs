using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
   public  class TiposEmails
    {
        [Key]
        public int TipoId { get; set; }
        public string Descripcion { get; set; }

       // public virtual ICollection <Empleados> empleadoLista { get; set; }
        public virtual ICollection<EmpleadosEmails> EmailList { get; set; }

        public TiposEmails()
        {
            //this.empleadoLista = new HashSet<Empleados>();
            this.EmailList = new HashSet<EmpleadosEmails>();
        }

       
    }
}
