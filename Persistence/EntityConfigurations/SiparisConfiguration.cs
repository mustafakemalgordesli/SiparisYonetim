using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.EntityConfigurations
{
    public class SiparisConfiguration : BaseEntityConfiguration<Siparis>
    {

        public override void Configure(EntityTypeBuilder<Siparis> builder)
        {
            base.Configure(builder);

            builder.ToTable("siparisler", ApplicationDbContext.DEFAULT_SCHEMA);

            builder.Property(x => x.MusteriAd).IsRequired().HasMaxLength(255);
            builder.Property(x => x.FirmaId).IsRequired();
            builder.Property(x => x.UrunId).IsRequired();
            builder.Property(x => x.SiparisTarih).HasDefaultValue(DateTime.Now);

            builder.HasOne(x => x.Firma).WithMany(x => x.Siparisler).HasForeignKey(i => i.FirmaId).OnDelete(DeleteBehavior.NoAction); ;
            builder.HasOne(x => x.Urun).WithMany(x => x.Siparisler).HasForeignKey(i => i.UrunId).OnDelete(DeleteBehavior.NoAction); ;
        }

    }
}
