using Application.Dtos;
using Application.Interfaces.Repository;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.SiparisFeatures.Queries.GetAllByFirma
{
    public class GetAllByFirmaQueryHandler : IRequestHandler<GetAllByFirmaQuery, List<SiparisViewDto>>
    {
        private readonly ISiparisRepository siparisRepository;
        private readonly IMapper mapper;
        private readonly IFirmaRepository firmaRepository;
        public GetAllByFirmaQueryHandler(IFirmaRepository firmaRepository, IMapper mapper, ISiparisRepository siparisRepository)
        {
            this.firmaRepository = firmaRepository;
            this.mapper = mapper;
            this.siparisRepository = siparisRepository;
        }
        public async Task<List<SiparisViewDto>> Handle(GetAllByFirmaQuery request, CancellationToken cancellationToken)
        {
            var alllist = siparisRepository.FindAllByCondition(x => x.FirmaId == request.Id);
            var viewModel = alllist.Select(x => mapper.Map<SiparisViewDto>(x)).ToList();
            return viewModel;
        }
    }
}
