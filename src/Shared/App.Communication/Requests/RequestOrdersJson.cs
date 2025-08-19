namespace App.Communication.Requests
{
    public class RequestOrdersJson
    {
        public string CustomerName { get; set; } = string.Empty;
        public DateTime OrderDate { get; set; }
        public string Status { get; set; } = string.Empty;

        public ICollection<RequestOrderItemJson> OrderItems { get; set; } = [];
    }
}
