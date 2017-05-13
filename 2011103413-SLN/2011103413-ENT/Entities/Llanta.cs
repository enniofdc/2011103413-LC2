using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011103413_ENT
{
    public class Llanta 
    {
        public int LlantaId { get; set; }
        public string NumSerie { get; set; }

        //public ICollection<Carro> Carro { get; set; }
        public Carro carro { get; set; }
        public int CarroId  { get; set; }
    public Llanta()
    {
       // Carro carro = new List<Carro>();
    }
}
}
