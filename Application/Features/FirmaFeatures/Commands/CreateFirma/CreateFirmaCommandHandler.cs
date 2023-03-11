using Application.Dtos;
using Application.Interfaces.Repository;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.FirmaFeatures.Commands.CreateFirma
{
    public class CreateFirmaCommandHandler : IRequestHandler<CreateFirmaCommand, FirmaViewDto>
    {
        private readonly IFirmaRepository firmaRepository;
        private readonly IMapper mapper;
        public CreateFirmaCommandHandler(IFirmaRepository firmaRepository, IMapper mapper)
        {
            this.firmaRepository = firmaRepository;
            this.mapper = mapper;
        }
        public async Task<FirmaViewDto> Handle(CreateFirmaCommand request, CancellationToken cancellationToken)
        {
            var entity = mapper.Map<Firma>(request);
            await firmaRepository.AddAsync(entity);
            FirmaViewDto viewModel = mapper.Map<FirmaViewDto>(entity);
            return viewModel;
        }
    }
}
