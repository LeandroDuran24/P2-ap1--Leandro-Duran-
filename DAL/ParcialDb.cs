using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Entidades;

namespace DAL
{
    class ParcialDb:DbContext
    {
        public ParcialDb() : base("ConStr")
        {

        }

        public DbSet<Retenciones> retencion { get; set; }
        public DbSet<TiposEmail> email { get; set; }
        public DbSet<Empleados> empelado { get; set; }
    }
}
