using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos;

public class FirmaViewDto
{
    public int Id { get; set; }
    public string FirmaAd { get; set; }
    public bool? OnayDurum { get; set; }
    public TimeSpan SiparisBaslangıcSaat { get; set; }
    public TimeSpan SiparisBitisSaat { get; set; }
}
