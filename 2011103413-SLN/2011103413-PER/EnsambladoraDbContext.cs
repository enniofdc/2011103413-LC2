using _2011103413_ENT;
using _2011103413_PER.EntityTypeConfigurations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011103413_PER
{
    public class EnsambladoraDbContext : DbContext
    {
        public DbSet <Propietario> Propietario { get; set; }
        public DbSet <Parabrisas> Parabrisas{ get; set; }
        public DbSet <Llanta> Llanta{ get; set; }
        public DbSet <Asiento> Asiento{ get; set; }
        public DbSet <Cinturon> Cinturon{ get; set; }
        public DbSet <Volante> Volante{ get; set; }
        public DbSet <Automovil> Automovil{ get; set; }
        public DbSet <Carro> Carro{ get; set; }
        public DbSet <Bus> Bus{ get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AsientoConfiguration());
            modelBuilder.Configurations.Add(new AutomovilConfiguration());
            modelBuilder.Configurations.Add(new BusConfiguration());
            modelBuilder.Configurations.Add(new CarroConfiguration());
            modelBuilder.Configurations.Add(new CinturonConfiguration());
            modelBuilder.Configurations.Add(new EnsambladoraConfiguration());
            modelBuilder.Configurations.Add(new LlantaConfiguration());
            modelBuilder.Configurations.Add(new ParabrisasConfiguration());
            modelBuilder.Configurations.Add(new PropietarioConfiguration());
            modelBuilder.Configurations.Add(new VolanteConfiguration());


            base.OnModelCreating(modelBuilder);
        }

    }


}
