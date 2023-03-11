using Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.UrunFeatures.Queries.GetAll
{
    public class GetAllUrunQuery : IRequest<List<UrunViewDto>>
    {
    }
}
