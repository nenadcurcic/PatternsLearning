using MediatR;
using MediatR_CQRS_Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatR_CQRS_Lib.Commands
{
    public record InsertPersonCommand(string FirstName, string LastName) : IRequest<PersonModel>;

    //public class InsertPersonCommand : IRequest<PersonModel>
    //{
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }

    //    public InsertPersonCommand(string firts, string last)
    //    {
    //        FirstName = firts;
    //        LastName = last;
    //    }
    //}
}
