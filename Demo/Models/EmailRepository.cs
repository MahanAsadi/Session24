namespace Demo.Models
{
    public class EmailRepository : GenericRepository<Email>, IEmailRepository
    {
        public EmailRepository(PeopleContext context) : base(context) { }
    }
}
