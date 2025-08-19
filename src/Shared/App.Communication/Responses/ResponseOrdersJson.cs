namespace App.Communication.Responses
{
    public class ResponseOrdersJson
    {
        public string CustomerName { get; set; } = string.Empty;
        public DateTime OrderDate { get; set; }
        public string Status { get; set; } = string.Empty;

        public ICollection<ResponseOrderItemJson> OrderItems { get; set; } = [];
    }
}
