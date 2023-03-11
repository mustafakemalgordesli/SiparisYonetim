using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Siparis : BaseEntity
    {
        public int FirmaId { get; set; }
        public int UrunId { get; set; }
        public string MusteriAd { get; set; }
        public DateTime SiparisTarih { get; set; }
        public virtual Firma Firma { get; set; }
        public virtual Urun Urun { get; set; }
    }
}
