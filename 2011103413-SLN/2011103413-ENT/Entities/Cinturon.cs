﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011103413_ENT
{
    public class Cinturon
    {
        public int CinturonId { get; set; }
        public string NumSerie { get; set; }
        public int Metraje { get; set; }

        public ICollection<Asiento> Asiento { get; set; }

        public Cinturon()
        {
            Asiento = new List<Asiento>();
        }

    }
}
