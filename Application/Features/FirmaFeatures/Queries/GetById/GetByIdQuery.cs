using Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.FirmaFeatures.Queries.GetById;

public class GetByIdQuery : IRequest<FirmaViewDto>
{
	public GetByIdQuery(int id)
	{
		Id = id;
	}
    public int Id { get; set; }
}
