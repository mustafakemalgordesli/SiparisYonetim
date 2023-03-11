using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos
{
    public class UrunViewDto
    {
        public int Id { get; set; }
        public int FirmaId { get; set; }
        public string UrunAd { get; set; }
        public int Stok { get; set; }
        public decimal Fiyat { get; set; }
    }
}
