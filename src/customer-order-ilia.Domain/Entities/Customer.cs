namespace customer_order_ilia.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public Customer()
        {

        }
        public Customer(string name, string email)
        {   
            Name = name;
            Email = email;
        }

        public string Name { get; private set; }
        public string Email { get; private set; }

        public void UpdateName(string name)
        {
            Name = name;
        }

        public void UpdateEmail(string email)
        {
            Email = email;
        }
    }
}
