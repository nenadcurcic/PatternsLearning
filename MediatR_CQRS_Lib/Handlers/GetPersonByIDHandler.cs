using MediatR;
using MediatR_CQRS_Lib.DataAccess;
using MediatR_CQRS_Lib.Models;
using MediatR_CQRS_Lib.Queries;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR_CQRS_Lib.Handlers
{
    public class GetPersonByIDHandler : IRequestHandler<GetPersonByIDQuery, PersonModel>
    {
        private readonly IMediator _mediator;

        public GetPersonByIDHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<PersonModel> Handle(GetPersonByIDQuery request, CancellationToken cancellationToken)
        {
            var allPerson = await _mediator.Send(new GetPersonListQuery());

            var person = allPerson.FirstOrDefault(p => p.ID == request.id);

            return person;
        }
    }
}
