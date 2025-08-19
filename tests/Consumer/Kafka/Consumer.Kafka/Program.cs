using Confluent.Kafka;

class Program
{
    /// <summary>
    /// Bruno Souza:
    /// Simples classe de consumo somente para testar se está recebendo as mensagens via Kafka.
    /// </summary>
    /// <param name="args"></param>

    public static void Main(string[] args)
    {
        var conf = new ConsumerConfig
        {
            GroupId = "test-consumer-group",
            BootstrapServers = "localhost:9092",
            AutoOffsetReset = AutoOffsetReset.Earliest
        };

        using (var c = new ConsumerBuilder<string, string>(conf).Build())
        {
            c.Subscribe("kafka_messages_queue");

            CancellationTokenSource cts = new CancellationTokenSource();
            Console.CancelKeyPress += (_, e) =>
            {
                e.Cancel = true;
                cts.Cancel();
            };

            try
            {
                while (true)
                {
                    try
                    {
                        var cr = c.Consume(cts.Token);
                        Console.WriteLine($"Consumed message '{cr.Message.Value}' at: '{cr.TopicPartitionOffset}'. ");
                    }
                    catch (ConsumeException e)
                    {
                        Console.WriteLine($"Error occured: {e.Error.Reason}");
                    }
                }
            }
            catch (OperationCanceledException)
            {
                c.Close();
            }
        }
    }
}