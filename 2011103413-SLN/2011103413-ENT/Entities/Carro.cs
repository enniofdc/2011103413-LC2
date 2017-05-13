using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011103413_ENT
{
    public class Carro
    {
        public int CarroId { get; set; }
        public string NumSerieMotor { get; set; }
        public string NumSerieChasis { get; set; }
        public TipoCarro TipoCarro { get; set; }

        public Parabrisas Parabrisas { get; set; }
        public Llanta Llanta { get; set; }
        public Asiento Asiento { get; set; }
        public Volante Volante { get; set; }
        public Automovil Automovil { get; set; }
        public Bus Bus { get; set; }
        public Propietario Propietario { get; set; }

        //public int LlantaId { get; set; }
    }
}
