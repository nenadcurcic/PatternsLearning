using MediatR_CQRS_Lib.Models;
using System.Collections.Generic;

namespace MediatR_CQRS_Lib.DataAccess
{
    public interface IDataAccess
    {
        List<PersonModel> GetPeople();

        PersonModel GetPersonByID(int id);
        PersonModel InsertPerson(string firstName, string lastName);
    }
}