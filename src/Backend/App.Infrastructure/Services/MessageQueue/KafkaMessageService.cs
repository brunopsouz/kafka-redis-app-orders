using App.Domain.Entities;
using App.Domain.Services.MessageQueue;
using Confluent.Kafka;
using System.Text.Json;

namespace App.Infrastructure.Services.MessageQueue
{
    public class KafkaMessageService : IKafkaMessageService
    {
        private readonly ProducerConfig _config;

        public KafkaMessageService(ProducerConfig config)
        {
            _config = config;
        }

        public async Task SendMessage(Order order)
        {
            using (var producer = new ProducerBuilder<string, string>(_config).Build())
            {
                try
                {
                    string json = JsonSerializer.Serialize(order);

                    var result = await producer.ProduceAsync(
                    "kafka_messages_queue",
                    new Message<string, string> { Key = Guid.NewGuid().ToString(), Value = json.ToString() });

                    Console.WriteLine($"Enviado para {result.TopicPartitionOffset}");

                }
                catch (ProduceException<Null, string> e)
                {
                    Console.WriteLine($"Delivery failed: {e.Error.Reason}");
                }

            }
        }
    }
}
