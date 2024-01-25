using Microsoft.EntityFrameworkCore;
using dotnet_webapi_test.Models;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<SessionContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SessionContext") ?? throw new InvalidOperationException("Connection string 'SessionContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<ConferenceContext>(opt =>
    opt.UseInMemoryDatabase("SessionList"));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
