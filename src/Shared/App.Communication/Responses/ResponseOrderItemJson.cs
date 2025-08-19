namespace App.Communication.Responses
{
    public class ResponseOrderItemJson
    {
        public long OrderId { get; set; }
        public string ProductCode { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public string UnitPrice { get; set; } = string.Empty;
    }
}