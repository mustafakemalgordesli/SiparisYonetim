using Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.FirmaFeatures.Commands.UpdateFirma
{
    public class UpdateFirmaCommand : IRequest<FirmaViewDto>
    {
        public int Id { get; set; }
        public bool? OnayDurum { get; set; }
        public TimeSpan? SiparisBaslangıcSaat { get; set; }
        public TimeSpan? SiparisBitisSaat { get; set; }
    }
}
