using MediatR;
using MediatR_CQRS_Lib.DataAccess;
using MediatR_CQRS_Lib.Models;
using MediatR_CQRS_Lib.Queries;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR_CQRS_Lib.Handlers
{
    public class GetPersonListHandler : IRequestHandler<GetPersonListQuery, List<PersonModel>>
    {
        private readonly IDataAccess _data;
        public GetPersonListHandler(IDataAccess data)
        {
            _data = data;
        }

        public Task<List<PersonModel>> Handle(GetPersonListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.GetPeople());
        }
    }
}
