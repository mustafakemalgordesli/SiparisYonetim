using Application.Dtos;
using MediatR;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces.Repository;
using Application.Exceptions;
using Domain.Common;
using Domain.Entities;

namespace Application.Features.FirmaFeatures.Commands.UpdateFirma;

public class UpdateFirmaCommandHandler : IRequestHandler<UpdateFirmaCommand, FirmaViewDto>
{
    IMapper mapper;
    IFirmaRepository firmaRepository;
    public UpdateFirmaCommandHandler(IMapper mapper, IFirmaRepository firmaRepository)
    {
        this.mapper = mapper;
        this.firmaRepository = firmaRepository;
    }
    public async Task<FirmaViewDto> Handle(UpdateFirmaCommand request, CancellationToken cancellationToken)
    {
        var firma = await firmaRepository.GetByIdAsync(request.Id);
        if (firma == null)
            throw new NotFoundException(Messages.FirmaNotFound);

        firma.OnayDurum = request?.OnayDurum ?? firma.OnayDurum;
        firma.SiparisBaslangıcSaat = request?.SiparisBaslangıcSaat ?? firma.SiparisBaslangıcSaat;
        firma.SiparisBitisSaat = request?.SiparisBitisSaat ?? firma.SiparisBitisSaat;

        firmaRepository.Update(firma);

        var viewModel = mapper.Map<FirmaViewDto>(firma);
        return viewModel;
    }
}
