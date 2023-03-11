using Application.Dtos;
using Application.Interfaces.Repository;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.FirmaFeatures.Queries.GetById
{
    public class GetByIdQueryHandler : IRequestHandler<GetByIdQuery, FirmaViewDto>
    {
        private readonly IFirmaRepository firmaRepository;
        private readonly IMapper mapper;
        public GetByIdQueryHandler(IFirmaRepository firmaRepository, IMapper mapper)
        {
            this.firmaRepository = firmaRepository;
            this.mapper = mapper;
        }
        public async Task<FirmaViewDto> Handle(GetByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await firmaRepository.GetByIdAsync(request.Id);
            var viewModel = mapper.Map<FirmaViewDto>(entity);
            return viewModel;
        }
    }
}
