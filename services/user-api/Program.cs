var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddOpenApi();

// TODO: Add Azure App Configuration
// builder.Configuration.AddAzureAppConfiguration(options =>
// {
//     options.Connect(new Uri(builder.Configuration["AppConfig:Endpoint"]), new DefaultAzureCredential())
//            .ConfigureKeyVault(kv => kv.SetCredential(new DefaultAzureCredential()));
// });

// TODO: Add authentication/authorization
// builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
//     .AddJwtBearer(options => { ... });

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
// app.UseAuthentication();
// app.UseAuthorization();

// Health endpoint for monitoring and load balancers
app.MapGet("/health", () => Results.Ok(new { status = "Healthy", service = "User.API" }))
    .WithName("HealthCheck")
    .WithTags("Health");

// Placeholder API endpoints
app.MapGet("/api/users/profile", () => 
    Results.Ok(new { message = "User API - GET /api/users/profile endpoint", user = new { id = "placeholder" } }))
    .WithName("GetUserProfile")
    .WithTags("Users");

app.Run();
