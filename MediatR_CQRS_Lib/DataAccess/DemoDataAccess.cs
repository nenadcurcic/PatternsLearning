using MediatR_CQRS_Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatR_CQRS_Lib.DataAccess
{
    public class DemoDataAccess : IDataAccess
    {

        private List<PersonModel> people = new();

        public DemoDataAccess()
        {
            people.Add(new PersonModel { ID = 1, FirstName = "Marko", LastName = "Markovic" });
            people.Add(new PersonModel { ID = 2, FirstName = "Janko", LastName = "Jankovic" });
            people.Add(new PersonModel { ID = 3, FirstName = "Zdravko", LastName = "Zdravkovic" });
        }

        public List<PersonModel> GetPeople()
        {
            return people;
        }

        public PersonModel GetPersonByID(int id)
        {
            return people.FirstOrDefault(p => p.ID == id);
        }

        public PersonModel InsertPerson(string firstName, string lastName)
        {
            PersonModel p = new() { FirstName = firstName, LastName = lastName };

            p.ID = people.Last().ID + 1;
            people.Add(p);

            return p;
        }
    }
}
