namespace JobForge.Indexer.Worker;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;
    // TODO: Inject ServiceBusClient and SearchClient

    public Worker(ILogger<Worker> logger)
    {
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _logger.LogInformation("Indexer Worker starting at: {time}", DateTimeOffset.Now);

        // TODO: Create Service Bus processor for "job-events" topic subscription
        // var processor = serviceBusClient.CreateProcessor("job-events", "indexer-sub");
        // processor.ProcessMessageAsync += ProcessJobNormalizedEventAsync;
        // processor.ProcessErrorAsync += ProcessErrorAsync;
        // await processor.StartProcessingAsync(stoppingToken);

        while (!stoppingToken.IsCancellationRequested)
        {
            _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
            await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken);
        }

        _logger.LogInformation("Indexer Worker stopping at: {time}", DateTimeOffset.Now);
    }

    // TODO: Implement event processing
    // private async Task ProcessJobNormalizedEventAsync(ProcessMessageEventArgs args)
    // {
    //     try
    //     {
    //         // 1. Deserialize JobNormalized event
    //         // 2. Transform to search document format
    //         // 3. Index document in Azure Cognitive Search
    //         // 4. Create JobIndexed event
    //         // 5. Publish JobIndexed event (optional notification)
    //         // 6. Complete the message
    //         await args.CompleteMessageAsync(args.Message);
    //     }
    //     catch (Exception ex)
    //     {
    //         _logger.LogError(ex, "Error processing JobNormalized event");
    //         // Let message go to DLQ after max retries
    //     }
    // }

    // private Task ProcessErrorAsync(ProcessErrorEventArgs args)
    // {
    //     _logger.LogError(args.Exception, "Service Bus error: {ErrorSource}", args.ErrorSource);
    //     return Task.CompletedTask;
    // }
}
