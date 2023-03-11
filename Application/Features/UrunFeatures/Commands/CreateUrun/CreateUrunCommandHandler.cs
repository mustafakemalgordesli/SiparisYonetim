using Application.Dtos;
using Application.Interfaces.Repository;
using Application.Mapping;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.UrunFeatures.Commands.CreateUrun;

public class CreateUrunCommandHandler : IRequestHandler<CreateUrunCommand, UrunViewDto>
{
	private readonly IUrunRepository urunRepository;
	private readonly IMapper mapper;
	public CreateUrunCommandHandler(IUrunRepository urunRepository, IMapper mapper)
	{
		this.urunRepository = urunRepository;
		this.mapper = mapper;
	}

    public async Task<UrunViewDto> Handle(CreateUrunCommand request, CancellationToken cancellationToken)
    {
		Urun entity = mapper.Map<Urun>(request);
		await urunRepository.AddAsync(entity);
		var viewModel = mapper.Map<UrunViewDto>(entity);
		return viewModel;
    }
}
