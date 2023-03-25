using Confluent.Kafka;
using Consumer.Models;
using System.Text.Json;

ConsumerConfig config = new()
{
    GroupId = "MongoDataTransfer",
    BootstrapServers = "localhost:29092",
    AutoOffsetReset = AutoOffsetReset.Earliest
};

using IConsumer<Ignore, string> consumer = new ConsumerBuilder<Ignore, string>(config).Build();
consumer.Subscribe("datatransfer.public.Product");

CancellationTokenSource source = new CancellationTokenSource();
Console.CancelKeyPress += (_, e) =>
{
    e.Cancel = true;
    source.Cancel();
};

while (true)
{
    ConsumeResult<Ignore, string> result = consumer.Consume(source.Token);
    Console.WriteLine($"Topic Name : {result.TopicPartitionOffset}");
    Console.WriteLine($"Message : {result.Value}");

    // Mongo aktarımı için buraya ilgili kodlarınızı ekleyebilirsiniz
}