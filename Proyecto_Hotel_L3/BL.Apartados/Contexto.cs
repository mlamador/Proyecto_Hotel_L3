using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Apartados
{
    public class Contexto : DbContext
    {

        public Contexto() : base(@"Data Source=(LocalDb)\MSSQLLocalDB;AttachDBFilename=" + 
        Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"Proyecto_Hotel_L3 5.0.mdf")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            Database.SetInitializer(new DatosdeInicio());
        }

        public DbSet<Habitacion> Habitaciones { get; set; }
        public DbSet<Tipo> Tipos { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
