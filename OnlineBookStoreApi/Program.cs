using Microsoft.EntityFrameworkCore;
using OnlineBookStoreApi.Database;
using OnlineBookStoreApi.UnitOfWork;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//database connection
var connectionString = builder.Configuration.GetConnectionString("ApplicationDbContext");
builder.Services.AddDbContext<OnlineBookStoreDbcontext>(options => options.UseSqlServer(connectionString));

//intefaces
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

//cors
builder.Services.AddCors();
//###########################################################################################################


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(m => m.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

app.UseAuthorization();

app.MapControllers();

app.Run();
