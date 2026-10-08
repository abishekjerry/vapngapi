using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi;

using VAapiPng.Models;
using static VAapiPng.CustomModels.Base;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;
        options.JsonSerializerOptions.Converters.Add(new NullToEmptyStringConverter());
    });
// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("ApiKey", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Name = "PMG-API-KEY",
        Type = SecuritySchemeType.ApiKey
    });
    options.AddSecurityDefinition("SecretKey", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Name = "PMG-Secret-KEY",
        Type = SecuritySchemeType.ApiKey
    });
    options.AddSecurityDefinition("Account", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Name = "PMG-Account",
        Type = SecuritySchemeType.ApiKey
    });
    //options.AddSecurityRequirement(new OpenApiSecurityRequirement
    //{
    //    {
    //        new OpenApiSecurityScheme
    //        {
    //            Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "ApiKey" }
    //        },
    //        new List<string>()
    //    },
    //    {
    //        new OpenApiSecurityScheme
    //        {
    //            Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "SecretKey" }
    //        },
    //        new List<string>()
    //    },
    //    {
    //        new OpenApiSecurityScheme
    //        {
    //            Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "Account" }
    //        },
    //        new List<string>()
    //    }
    //});
});

var baseConnection = builder.Configuration.GetConnectionString("VADbConnectionString");
if (string.IsNullOrEmpty(baseConnection))
    throw new InvalidOperationException("VADbConnectionString is missing from configuration.");
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(baseConnection));
var masterBuilder = new SqlConnectionStringBuilder(baseConnection)
{
    InitialCatalog = "Master"
};
builder.Services.AddDbContext<MasterDbContext>(options =>
    options.UseSqlServer(masterBuilder.ConnectionString));
var allowedOrigins = builder.Configuration.GetSection("HostURLS").Get<List<string>>() ?? [];
builder.Services.AddCors(options =>
{
    options.AddPolicy("AppCorsPolicy", policy =>
    {
        policy.WithOrigins([.. allowedOrigins]) // Use WithOrigins instead of AllowAnyOrigin
              .AllowAnyHeader()
              .AllowAnyMethod()
              .AllowCredentials();
    });
});
// Filters
builder.Services.AddScoped<ApiKeyAuthFilter>();
builder.Services.AddScoped<ValidationFilter>();
builder.Services.AddHealthChecks();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "VA API V1");
    });
}
// Middleware
app.UseMiddleware<RequestLoggingMiddleware>();
app.UseMiddleware<ErrorHandlingMiddleware>();
app.UseCors("AppCorsPolicy");
app.UseAuthorization();
app.MapControllers();
// After app.MapControllers();
app.MapGet("/health", () => Results.Ok(new { status = "healthy", time = DateTime.UtcNow }));
app.Run();
