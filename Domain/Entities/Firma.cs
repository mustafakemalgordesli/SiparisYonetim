using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class Firma : BaseEntity
{
    public string FirmaAd { get; set; }
    public bool OnayDurum { get; set; }
    [Column(TypeName = "time")]
    public TimeSpan SiparisBaslangıcSaat { get; set; }
    [Column(TypeName = "time")]
    public TimeSpan SiparisBitisSaat { get; set; }
    public virtual List<Urun> Urunler { get; set; }
    public virtual List<Siparis> Siparisler { get; set; }
}
