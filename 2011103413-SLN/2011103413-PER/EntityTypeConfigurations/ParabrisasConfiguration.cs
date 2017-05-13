using _2011103413_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011103413_PER.EntityTypeConfigurations
{
    public class ParabrisasConfiguration : EntityTypeConfiguration<Parabrisas>
    {

        public ParabrisasConfiguration()
        {
            Property(v => v.ParabrisasId)
                .IsRequired();

        }

    }
}
