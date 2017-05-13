using _2011103413_ENT;
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


      

    }
}
