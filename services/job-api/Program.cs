var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddOpenApi();

// TODO: Add Azure App Configuration
// builder.Configuration.AddAzureAppConfiguration(options =>
// {
//     options.Connect(new Uri(builder.Configuration["AppConfig:Endpoint"]), new DefaultAzureCredential())
//            .ConfigureKeyVault(kv => kv.SetCredential(new DefaultAzureCredential()));
// });

// TODO: Add Application Insights
// builder.Services.AddApplicationInsightsTelemetry();

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

// Health endpoint for monitoring and load balancers
app.MapGet("/health", () => Results.Ok(new { status = "Healthy", service = "Job.API" }))
    .WithName("HealthCheck")
    .WithTags("Health");

// Placeholder API endpoints
app.MapGet("/api/jobs", () => Results.Ok(new { message = "Job API - GET /api/jobs endpoint", jobs = Array.Empty<object>() }))
    .WithName("GetJobs")
    .WithTags("Jobs");

app.Run();
