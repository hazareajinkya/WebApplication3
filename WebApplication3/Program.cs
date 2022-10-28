using Microsoft.Extensions.Configuration;
using System;
using WebApplication3;

var builder = WebApplication.CreateBuilder(args);

var startup = new Startup(builder.Configuration);
startup.ConfigureServices(builder.Services); // calling ConfigureServices method
var app = builder.Build();
startup.Configure(app, builder.Environment); // calling Configure method
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//builder.Services.AddDbContext<ProductDbContext>(x => x.UseSqlServer(Configuration.GetConnectionString("ConStr")));
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
