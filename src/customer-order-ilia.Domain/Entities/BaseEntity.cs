using System;
namespace customer_order_ilia.Domain.Entities
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; private set; }
    }
}
