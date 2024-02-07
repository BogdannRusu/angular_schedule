using athena.api.Models;
using Dapper;
using Microsoft.Data.SqlClient;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
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

app.MapGet("profesori", async (IConfiguration config) =>
{
    var connectionString = config.GetConnectionString("DefaultConnection");

    using var connect = new SqlConnection(connectionString);
    const string sql = "Select * From profesori";
    var profesori = await connect.QueryAsync<Profesori>(sql);
    return Results.Ok(profesori);

});

app.UseAuthorization();

app.MapControllers();

app.Run();
