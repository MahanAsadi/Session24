using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Models
{
    public class PersonFacade
    {
        private readonly IUnitOfWork unitOfWork;

        public PersonFacade(IUnitOfWork unitOfWork )
        {
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<Person> GetAllPersons()
        {
            return unitOfWork.Person.GetAll();
        }

        public void AddBatch(){
            unitOfWork.Person.Add(new Person());
            unitOfWork.Person.Add(new Person());
            unitOfWork.Save();

        }
    }
}
