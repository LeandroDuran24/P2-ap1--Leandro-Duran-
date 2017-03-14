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
        public int Sueldo { get; set; }
        public int RetencionId { get; set; }

        public virtual List<Retenciones> RetencionList { get; set; }
        //public virtual List<TiposEmails> tipoList { get; set; }
        public virtual ICollection<EmpleadosEmails> EmailList { get; set; }

        public Empleados()
        {
            this.RetencionList = new List<Retenciones>();
            //this.tipoList = new List<TiposEmails>();
            this.EmailList = new HashSet<EmpleadosEmails>();
        }

        public void AgregarEmailDetalle(TiposEmails nuevo,string email)
        {
            this.EmailList.Add(new EmpleadosEmails(nuevo.TipoId, email));
        }
      




    }
}
