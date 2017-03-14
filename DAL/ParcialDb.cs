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
        public DbSet<Empleados> empleado { get; set; }
        public DbSet<EmpleadosEmail> empleadoEmail { get; set; }
        public DbSet<EmpleadosRetenciones> empleadoRetenciones { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Retenciones>()
            .HasMany(p => p.empleadosList)
            .WithMany(p => p.retencionList)
            .Map(mapeo =>
            {
                mapeo.MapLeftKey("EmpleadoId");
                mapeo.MapRightKey("RetencionId");
                mapeo.ToTable("EmpleadosRetenciones");
            });
        }
       
    }
}
