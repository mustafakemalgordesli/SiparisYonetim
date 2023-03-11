using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Urun : BaseEntity
    {
        public int FirmaId { get; set; }
        public string UrunAd { get; set; }
        public int Stok { get; set; }
        public decimal Fiyat { get; set; }

        public virtual Firma Firma { get; set; }
        public virtual List<Siparis> Siparisler { get; set; }
    }
}
