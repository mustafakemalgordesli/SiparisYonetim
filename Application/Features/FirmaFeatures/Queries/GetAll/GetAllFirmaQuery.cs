using Application.Dtos;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.FirmaFeatures.Queries.GetAll
{
    public class GetAllFirmaQuery : IRequest<List<FirmaViewDto>>
    {
    }
}
