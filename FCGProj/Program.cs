using FCGProj.Interfaces.Repositories;
using FCGProj.Interfaces.Services;
using FCGProj.Models;
using FCGProj.Repositories;
using FCGProj.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Remove these model registrations unless you specifically need them resolved via DI
// builder.Services.AddTransient<Client>();
// builder.Services.AddTransient<Game>();

// Register EF Core DbContext using the connection string named "DefaultConnection"
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Register repositories
builder.Services.AddScoped<IGameRepository, GameRepository>();
builder.Services.AddScoped<IClientRepository, ClientRepository>();

// Register application services (Scoped is appropriate when using DbContext)
builder.Services.AddScoped<IGameService, GameService>();
builder.Services.AddScoped<IClientService, ClientService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();