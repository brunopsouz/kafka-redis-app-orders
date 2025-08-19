using App.Domain.Entities;

namespace App.Domain.Services.MessageQueue
{
    public interface IKafkaMessageService
    {
        Task SendMessage(Order order);
    }
}
