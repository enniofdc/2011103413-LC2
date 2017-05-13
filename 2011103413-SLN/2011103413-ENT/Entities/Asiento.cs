using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011103413_ENT
{
    public class Asiento 
    {
        public int AsientoId { get; set; }
        public string NumSerie { get; set; }
        public Cinturon Cinturon { get; set; }

        public ICollection<Carro> Carro { get; set; }

        public Asiento()
        {
            Carro = new List<Carro>();
            
        }
    }
}
