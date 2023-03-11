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
    public class UrunConfiguration : BaseEntityConfiguration<Urun>
    {
        public override void Configure(EntityTypeBuilder<Urun> builder)
        {
            base.Configure(builder);

            builder.ToTable("urunler", ApplicationDbContext.DEFAULT_SCHEMA);

            builder.Property(x => x.FirmaId).IsRequired();
            builder.Property(x => x.UrunAd).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Stok).IsRequired();
            builder.Property(x => x.Fiyat).IsRequired();

            builder.HasOne(x => x.Firma).WithMany(x => x.Urunler).HasForeignKey(i => i.FirmaId).OnDelete(DeleteBehavior.NoAction); ;
        }
    }
}
