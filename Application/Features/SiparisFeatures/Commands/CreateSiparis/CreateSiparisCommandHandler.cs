using Application.Dtos;
using Application.Exceptions;
using Application.Interfaces.Repository;
using AutoMapper;
using Domain.Common;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.SiparisFeatures.Commands.CreateSiparis;

public class CreateSiparisCommandHandler : IRequestHandler<CreateSiparisCommand, SiparisViewDto>
{
    private readonly ISiparisRepository siparisRepository;
    private readonly IMapper mapper;
    private readonly IFirmaRepository firmaRepository;
	public CreateSiparisCommandHandler(IFirmaRepository firmaRepository, IMapper mapper, ISiparisRepository siparisRepository)
	{
        this.firmaRepository = firmaRepository;
        this.mapper = mapper;
        this.siparisRepository = siparisRepository;
	}

    public async Task<SiparisViewDto> Handle(CreateSiparisCommand request, CancellationToken cancellationToken)
    {
        Firma firma = await firmaRepository.GetByIdAsync(request.FirmaId);

        if (firma == null) 
            throw new NotFoundException(Messages.FirmaNotFound);

        // Firma onaylı değilse siparişe izin vermeyecek
        if (firma.OnayDurum != true) 
            throw new BadRequestException(Messages.CompanyNotApproved);

        TimeSpan siparisSaat = new TimeSpan(request.SiparisTarih.Hour, request.SiparisTarih.Minute, 0);

        // Siparis izin verilen saatler dışında ise siparis oluşturulmayacak
        if (firma.SiparisBaslangıcSaat > siparisSaat || siparisSaat > firma.SiparisBitisSaat)
            throw new BadRequestException(Messages.CompanyNotOrder);

        var entity = mapper.Map<Siparis>(request);
        await siparisRepository.AddAsync(entity);
        var viewModel = mapper.Map<SiparisViewDto>(entity);
        return viewModel;
    }
}
