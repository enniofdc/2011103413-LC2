using _2011103413_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011103413_PER.EntityTypeConfigurations
{
    public class VolanteConfiguration : EntityTypeConfiguration<Volante>
    {


        public VolanteConfiguration()
        {
            Property(v => v.VolanteId)
                .IsRequired();
                
        }

      
    }
}
