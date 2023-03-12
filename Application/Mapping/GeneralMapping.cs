using Application.Dtos;
using Application.Features.FirmaFeatures.Commands.CreateFirma;
using Application.Features.SiparisFeatures.Commands.CreateSiparis;
using Application.Features.UrunFeatures.Commands.CreateUrun;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mapping;

public class GeneralMapping : Profile
{
	public GeneralMapping()
	{
		CreateMap<CreateFirmaCommand, Firma>();
		CreateMap<Firma, FirmaViewDto>();
		CreateMap<Urun, UrunViewDto>();
		CreateMap<CreateUrunCommand, Urun>();
		CreateMap<CreateSiparisCommand, Siparis>();
		CreateMap<Siparis, SiparisViewDto>();
	}
}
