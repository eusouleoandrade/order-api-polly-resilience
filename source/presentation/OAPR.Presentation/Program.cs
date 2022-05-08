using OAPR.Infra.BackOfficeIntegration.IoC;
using OAPR.Presentation.Extensions;

var builder = WebApplication.CreateBuilder(args);
IConfiguration configuration = builder.Configuration;

// Add services to the container.
builder.Services.AddIntegrationInfra();
builder.Services.AddHttpClientOrderIntegrationService(configuration);
builder.Services.AddSwaggerExtension();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddApiVersioningExtension();
builder.Services.AddHealthChecks();

var app = builder.Build();
app.UseHttpsRedirection();
app.UseAuthorization();
app.UseSwaggerExtension();
app.UseHealthChecks("/health");
app.UseStaticFiles();
app.MapControllers();
app.Run();