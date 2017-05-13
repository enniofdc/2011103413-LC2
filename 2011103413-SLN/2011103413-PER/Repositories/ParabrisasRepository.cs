﻿using _2011103413_ENT;
using _2011103413_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011103413_PER.Repositories
{
    public class ParabrisasRepository : Repository<Parabrisas>, IParabrisasRepository
    {
        private readonly EnsambladoraDbContext _Context;

        public ParabrisasRepository(EnsambladoraDbContext context)
        {
            _Context = context;
        }

        private ParabrisasRepository()
        {
                
        }
    }
}
