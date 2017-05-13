using _2011103413_ENT;
using _2011103413_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011103413_PER.Repositories
{
    public class CinturonRepository : Repository<Cinturon>, ICinturonRepository
    {
        private readonly EnsambladoraDbContext _Context;

        public CinturonRepository(EnsambladoraDbContext context)
        {
            _Context = context;
        }

        private CinturonRepository()
        {
                
        }
    }
}
