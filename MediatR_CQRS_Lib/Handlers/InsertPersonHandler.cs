using MediatR;
using MediatR_CQRS_Lib.Commands;
using MediatR_CQRS_Lib.DataAccess;
using MediatR_CQRS_Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR_CQRS_Lib.Handlers
{
    public class InsertPersonHandler : IRequestHandler<InsertPersonCommand, PersonModel>
    {
        private readonly IDataAccess data;

        public InsertPersonHandler(IDataAccess data)
        {
            this.data = data;
        }


        public Task<PersonModel> Handle(InsertPersonCommand request, CancellationToken cancellationToken)
        {
            
            return Task.FromResult(data.InsertPerson(request.FirstName, request.LastName));
        }
    }
}
