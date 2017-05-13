using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011103413_ENT
{
    public class Automovil 
    {
        public int AutomovilId { get; set; }
        public TipoAuto TipoAuto { get; set; }

        public ICollection<Carro> Carro { get; set; }

        public Automovil()
        {
            Carro = new List<Carro>();
        }
    }
}
