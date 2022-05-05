using OAPR.Domain.Common;

namespace OAPR.Domain.Entities
{
    public class Order : BaseEntity<int>
    {
        public string Description { get; private set; }

        public int Quantity { get; private set; }

        public decimal Price { get; private set; }

        public int ClientId { get; private set; }

        public Order(string description, int quantity, decimal price, int clientId)
        {
            Description = description;
            Quantity = quantity;
            Price = price;
            ClientId = clientId;
        }

        public Order(int id, string description, int quantity, decimal price, int clientId)
        {
            Id = id;
            Description = description;
            Quantity = quantity;
            Price = price;
            ClientId = clientId;
        }
    }
}