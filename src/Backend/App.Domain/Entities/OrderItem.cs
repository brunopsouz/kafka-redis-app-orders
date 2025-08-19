namespace App.Domain.Entities
{
    public class OrderItem : EntityBase
    {
        public long OrderId { get; set; }   
        public string ProductCode { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public string UnitPrice { get; set; } = string.Empty;
    }
}