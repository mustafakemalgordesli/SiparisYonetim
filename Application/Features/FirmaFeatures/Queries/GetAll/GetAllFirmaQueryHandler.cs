using Application.Dtos;
using Application.Interfaces.Repository;
using Application.Mapping;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.FirmaFeatures.Queries.GetAll
{
    public class GetAllFirmaQueryHandler : IRequestHandler<GetAllFirmaQuery, List<FirmaViewDto>>
    {
        private readonly IFirmaRepository firmaRepository;
        private readonly IMapper mapper;
        public GetAllFirmaQueryHandler(IFirmaRepository firmaRepository, IMapper mapper)
        {
            this.firmaRepository = firmaRepository;
            this.mapper = mapper;
        }
        public async Task<List<FirmaViewDto>> Handle(GetAllFirmaQuery request, CancellationToken cancellationToken)
        {
            var allist = await firmaRepository.GetAllAsync();
            var viewModel = mapper.Map<List<FirmaViewDto>>(allist);
            return viewModel;
        }
    }
}
