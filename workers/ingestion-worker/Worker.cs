namespace JobForge.Ingestion.Worker;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;
    // TODO: Inject ServiceBusClient and external API clients

    public Worker(ILogger<Worker> logger)
    {
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _logger.LogInformation("Ingestion Worker starting at: {time}", DateTimeOffset.Now);

        while (!stoppingToken.IsCancellationRequested)
        {
            try
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

                // TODO: Implement job ingestion logic
                // 1. Fetch jobs from external sources (LinkedIn, Indeed, Glassdoor)
                // 2. Transform to JobFetched event format
                // 3. Publish to Service Bus topic "job-events"
                // 4. Implement retry logic with exponential backoff
                // 5. Handle errors and send to dead-letter queue

                await Task.Delay(TimeSpan.FromMinutes(5), stoppingToken); // Poll every 5 minutes
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in ingestion worker");
                await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken); // Wait before retry
            }
        }

        _logger.LogInformation("Ingestion Worker stopping at: {time}", DateTimeOffset.Now);
    }
}
