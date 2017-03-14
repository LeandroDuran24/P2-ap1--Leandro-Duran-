using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Entidades;

namespace DAL
{
    public class ParcialDb:DbContext
    {
        public ParcialDb() : base("ConStr")
        {

        }

        public DbSet<Retenciones> retencion { get; set; }
        public DbSet<TiposEmails> email { get; set; }
        public DbSet<Empleados> empleado { get; set; }
      

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Retenciones>()
            .HasMany(p => p.EmpleadosList)
            .WithMany(p => p.RetencionList)
            .Map(mapeo =>
            {
                mapeo.MapLeftKey("EmpleadoId");
                mapeo.MapRightKey("RetencionId");
                mapeo.ToTable("EmpleadosRetenciones");
            });
        }
       
    }
}
