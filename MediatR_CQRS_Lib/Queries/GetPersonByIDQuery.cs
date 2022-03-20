using MediatR;
using MediatR_CQRS_Lib.Models;

namespace MediatR_CQRS_Lib.Queries
{
    public record GetPersonByIDQuery(int id) : IRequest<PersonModel>;
}
