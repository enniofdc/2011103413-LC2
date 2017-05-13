using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011103413_ENT
{
    public class Propietario
    {
        public int PropietarioId { get; set; }
        public string Dni { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string LicenciaConducir { get; set; }

        public ICollection<Carro> Carro { get; set; }

        public Propietario()
        {
            Carro = new List<Carro>();
        }

    }
}
