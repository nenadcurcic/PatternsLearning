using MediatR;
using MediatR_CQRS_Lib.Models;
using System.Collections.Generic;

namespace MediatR_CQRS_Lib.Queries
{
    public record GetPersonListQuery() : IRequest<List<PersonModel>>;

    //public class GetPersonListQuery : IRequest<List<PersonModel>>
    //{
    //}
    
}
