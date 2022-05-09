namespace OAPR.Application.Dtos.Requests
{
    public class OrderUpdateRequest
    {
        public string Description { get; private set; }

        public int Quantity { get; private set; }

        public decimal Price { get; private set; }

        public OrderUpdateRequest(string description, int quantity, decimal price)
        {
            Description = description;
            Quantity = quantity;
            Price = price;
        }
    }
}