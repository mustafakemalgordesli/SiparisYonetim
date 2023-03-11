using Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.UrunFeatures.Commands.CreateUrun
{
    public class CreateUrunCommand : IRequest<UrunViewDto>
    {
        public int FirmaId { get; set; }
        public string UrunAd { get; set; }
        public int Stok { get; set; }
        public decimal Fiyat { get; set; }
    }
}
