using Avanade.Estagiario.API.Repositorio;
using Avanade.Estagiario.API.Services;
using Avanade.Estagiario.API.Services.Implementations;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ICervejaService, CervejaServiceImplementation>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connection = "Server=localhost;Database=Avanade;Uid=root;Pwd=@Matheus@1996;";
builder.Services.AddDbContext<CervejaContext>(opt => opt.UseMySql(connection, ServerVersion.AutoDetect(connection)));

builder.Services.AddScoped<ICervejaService, CervejaServiceImplementation>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
