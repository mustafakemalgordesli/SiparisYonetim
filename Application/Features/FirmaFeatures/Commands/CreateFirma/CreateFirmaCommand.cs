using Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.FirmaFeatures.Commands.CreateFirma
{
    public class CreateFirmaCommand : IRequest<FirmaViewDto>
    {
        public string FirmaAd { get; set; }
        public bool? OnayDurum { get; set; }
        public TimeSpan SiparisBaslangıcSaat { get; set; }
        public TimeSpan SiparisBitisSaat { get; set; }
    }
}
