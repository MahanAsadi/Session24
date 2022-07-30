namespace Demo.Models
{
    public class AddressRepository : GenericRepository<Address>, IAdressRepository
    {
        public AddressRepository(PeopleContext context) : base(context) { }
    }
}
