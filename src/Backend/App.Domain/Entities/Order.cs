namespace App.Domain.Entities
{
    public class Order : EntityBase
    {
        public string CustomerName { get; set; } = string.Empty;
        public DateTime OrderDate { get; set; }
        public string Status { get; set; } = string.Empty;

        public ICollection<OrderItem> OrderItems { get; set; } = [];
    }
}
