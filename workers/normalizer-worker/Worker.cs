namespace JobForge.Normalizer.Worker;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;
    // TODO: Inject ServiceBusClient and processor

    public Worker(ILogger<Worker> logger)
    {
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _logger.LogInformation("Normalizer Worker starting at: {time}", DateTimeOffset.Now);

        // TODO: Create Service Bus processor for "job-events" topic subscription
        // var processor = serviceBusClient.CreateProcessor("job-events", "normalizer-sub");
        // processor.ProcessMessageAsync += ProcessJobFetchedEventAsync;
        // processor.ProcessErrorAsync += ProcessErrorAsync;
        // await processor.StartProcessingAsync(stoppingToken);

        while (!stoppingToken.IsCancellationRequested)
        {
            _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
            await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken);
        }

        _logger.LogInformation("Normalizer Worker stopping at: {time}", DateTimeOffset.Now);
    }

    // TODO: Implement event processing
    // private async Task ProcessJobFetchedEventAsync(ProcessMessageEventArgs args)
    // {
    //     try
    //     {
    //         // 1. Deserialize JobFetched event
    //         // 2. Parse and normalize raw job data
    //         // 3. Create JobNormalized event
    //         // 4. Publish to Service Bus topic
    //         // 5. Complete the message
    //         await args.CompleteMessageAsync(args.Message);
    //     }
    //     catch (Exception ex)
    //     {
    //         _logger.LogError(ex, "Error processing JobFetched event");
    //         // Let message go to DLQ after max retries
    //     }
    // }

    // private Task ProcessErrorAsync(ProcessErrorEventArgs args)
    // {
    //     _logger.LogError(args.Exception, "Service Bus error: {ErrorSource}", args.ErrorSource);
    //     return Task.CompletedTask;
    // }
}
