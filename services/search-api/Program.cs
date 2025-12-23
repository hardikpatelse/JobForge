var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddOpenApi();

// TODO: Add Azure App Configuration
// builder.Configuration.AddAzureAppConfiguration(options =>
// {
//     options.Connect(new Uri(builder.Configuration["AppConfig:Endpoint"]), new DefaultAzureCredential())
//            .ConfigureKeyVault(kv => kv.SetCredential(new DefaultAzureCredential()));
// });

// TODO: Add Azure Cognitive Search SDK
// builder.Services.AddSingleton<SearchClient>(sp => {
//     var endpoint = new Uri(builder.Configuration["Search:Endpoint"]);
//     return new SearchClient(endpoint, "jobs-index", new DefaultAzureCredential());
// });

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

// Health endpoint for monitoring and load balancers
app.MapGet("/health", () => Results.Ok(new { status = "Healthy", service = "Search.API" }))
    .WithName("HealthCheck")
    .WithTags("Health");

// Placeholder API endpoints
app.MapGet("/api/search", (string? query) => 
    Results.Ok(new { message = "Search API - GET /api/search endpoint", query, results = Array.Empty<object>() }))
    .WithName("SearchJobs")
    .WithTags("Search");

app.Run();
