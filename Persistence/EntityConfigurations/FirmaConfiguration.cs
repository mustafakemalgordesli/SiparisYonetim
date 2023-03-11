using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.EntityConfigurations;

public class FirmaConfiguration : BaseEntityConfiguration<Firma>
{
    public override void Configure(EntityTypeBuilder<Firma> builder)
    {
        base.Configure(builder);

        builder.ToTable("firmalar", ApplicationDbContext.DEFAULT_SCHEMA);

        builder.Property(x => x.FirmaAd).IsRequired().HasMaxLength(100);
        builder.Property(x => x.SiparisBitisSaat).IsRequired();
        builder.Property(x => x.SiparisBaslangıcSaat).IsRequired();
        builder.Property(x => x.OnayDurum).HasDefaultValue(false);

        builder.HasMany(x => x.Siparisler).WithOne(x => x.Firma).HasForeignKey(x => x.FirmaId);
        builder.HasMany(x => x.Urunler).WithOne(x => x.Firma).HasForeignKey(x => x.FirmaId).OnDelete(DeleteBehavior.NoAction);
    }
}
