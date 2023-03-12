using Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.SiparisFeatures.Commands.CreateSiparis;

public class CreateSiparisCommand : IRequest<SiparisViewDto>
{
    public int FirmaId { get; set; }
    public int UrunId { get; set; }
    public string MusteriAd { get; set; }
    public DateTime SiparisTarih { get; set; }
}
