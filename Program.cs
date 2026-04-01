using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// ✅ 1. MVC + Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "MES Production API",
        Version = "v1"
    });
});

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "MES Production API v1");
    });
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.MapControllers();

app.Run();