using _2011103413_ENT;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011103413_PER.EntitiesConfigurations
{
    public class ParabrisasConfiguration:EntityTypeConfiguration<Parabrisas>
    {
        public ParabrisasConfiguration()
        {
            ToTable("Parabrisas");

            HasKey(c => c.ParabrisasId);
            //Propiedades
            Property(c => c.NumSerie)
                .IsRequired()
                .HasMaxLength(10);
            Property(c => c.ParabrisasId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
