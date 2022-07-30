using System;

namespace Demo.Models
{
    public interface IUnitOfWork : IDisposable
    {
        IAdressRepository Address
        {
            get;
        }
        IEmailRepository Email
        {
            get;
        }
        IPersonRepository Person
        {
            get;
        }
        int Save();
    }
}
