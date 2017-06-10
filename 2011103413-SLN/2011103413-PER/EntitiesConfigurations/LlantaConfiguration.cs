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
    public class LlantaConfiguration:EntityTypeConfiguration<Llanta>
    {
        public LlantaConfiguration()
        {
            ToTable("Llantas");

            HasKey(c => c.LlantaId);
            //Propiedades 
            Property(c => c.LlantaId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.NumSerie)
                .IsRequired();

        }
    }
}
