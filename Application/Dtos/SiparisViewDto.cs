using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos
{
    public class SiparisViewDto
    {
        public int Id { get; set; }
        public int FirmaId { get; set; }
        public int UrunId { get; set; }
        public string MusteriAd { get; set; }
        public DateTime SiparisTarih { get; set; }
    }
}
