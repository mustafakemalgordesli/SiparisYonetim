using Application.Dtos;
using Application.Interfaces.Repository;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.UrunFeatures.Queries.GetAll
{
    public class GetAllUrunQueryHandler : IRequestHandler<GetAllUrunQuery, List<UrunViewDto>>
    {
        IMapper mapper;
        IUrunRepository urunRepository;
        public GetAllUrunQueryHandler(IMapper mapper, IUrunRepository urunRepository)
        {
            this.mapper = mapper;
            this.urunRepository = urunRepository;
        }

        public async Task<List<UrunViewDto>> Handle(GetAllUrunQuery request, CancellationToken cancellationToken)
        {
            var alllist = await urunRepository.GetAllAsync();
            return mapper.Map<List<UrunViewDto>>(alllist);
        }
    }
}
