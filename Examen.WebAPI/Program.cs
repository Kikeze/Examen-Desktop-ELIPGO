using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using Examen.Data.Context;


// Inicializacion
var builder = WebApplication.CreateBuilder(args);
var sConnection = builder.Configuration.GetConnectionString("MainConnection");


// Servicios.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Base de datos
builder.Services.AddDbContext<ApplicationDBContext>(options =>
{
    options.UseSqlServer(sConnection, b => b.MigrationsAssembly("Examen.WebAPI"));
    //options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
    //options.UseLazyLoadingProxies();
});


// Json
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.PropertyNamingPolicy = null;
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});


// Ejecucion
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
