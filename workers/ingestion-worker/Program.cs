using JobForge.Ingestion.Worker;

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

// Register the background worker
builder.Services.AddHostedService<Worker>();

var host = builder.Build();
host.Run();
