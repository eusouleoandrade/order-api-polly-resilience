using OAPR.Infra.Notification.Abstractions;

namespace OAPR.Application.Dtos.Requests
{
    public class OrderUpdateUseCaseRequest : Notifiable
    {
        public string Description { get; private set; }

        public int Quantity { get; private set; }

        public decimal Price { get; private set; }

        public int ClientId { get; set; }

        public OrderUpdateUseCaseRequest(string description, int quantity, decimal price, int clientId) : this(description, quantity, price)
        {
            ClientId = clientId;
        }

        public OrderUpdateUseCaseRequest(string description, int quantity, decimal price)
        {
            Description = description;
            Quantity = quantity;
            Price = price;

            Validate();
        }

        private void Validate()
        {
            // TODO: Implement validations
        }
    }
}