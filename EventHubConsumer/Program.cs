using Azure.Messaging.EventHubs.Consumer;

var connectionString = "";
var consumerGroup = "$Default";


EventHubConsumerClient eventHubConsumerClient= new EventHubConsumerClient(consumerGroup, connectionString);

await foreach(PartitionEvent _event in eventHubConsumerClient.ReadEventsAsync())
{
    Console.WriteLine(_event.Partition.PartitionId);
    Console.WriteLine(_event.Data.Offset);
    Console.WriteLine(_event.Data.SequenceNumber);
    Console.WriteLine(_event.Data.PartitionKey);
    Console.WriteLine(_event.Data.EventBody);
}

Console.ReadKey();