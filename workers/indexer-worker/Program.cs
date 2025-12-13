using JobForge.Indexer.Worker;

var builder = Host.CreateApplicationBuilder(args);

// TODO: Add Azure App Configuration
// builder.Configuration.AddAzureAppConfiguration(options =>
// {
//     options.Connect(new Uri(builder.Configuration["AppConfig:Endpoint"]), new DefaultAzureCredential())
//            .ConfigureKeyVault(kv => kv.SetCredential(new DefaultAzureCredential()));
// });

// TODO: Add Azure Service Bus client with Managed Identity
// builder.Services.AddSingleton<ServiceBusClient>(sp => {
//     var serviceBusNamespace = builder.Configuration["ServiceBus:Namespace"];
//     return new ServiceBusClient(serviceBusNamespace, new DefaultAzureCredential());
// });

// TODO: Add Azure Cognitive Search client
// builder.Services.AddSingleton<SearchClient>(sp => {
//     var endpoint = new Uri(builder.Configuration["Search:Endpoint"]);
//     return new SearchClient(endpoint, "jobs-index", new DefaultAzureCredential());
// });

// Register the background worker
builder.Services.AddHostedService<Worker>();

var host = builder.Build();
host.Run();
