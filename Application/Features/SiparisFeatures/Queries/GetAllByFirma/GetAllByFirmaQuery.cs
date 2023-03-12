using Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.SiparisFeatures.Queries.GetAllByFirma
{
    public class GetAllByFirmaQuery : IRequest<List<SiparisViewDto>>
    {
        public int Id { get; set; }
        public GetAllByFirmaQuery(int id)
        {
            Id = id;
        }
    }
}
