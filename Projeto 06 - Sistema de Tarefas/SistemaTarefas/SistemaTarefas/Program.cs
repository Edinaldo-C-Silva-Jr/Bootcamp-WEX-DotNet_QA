using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using SistemaTarefas.Context;
using System.Reflection;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<TarefaContext>
    (options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoTarefas")));

builder.Services.AddControllers().
    AddJsonOptions(options => { options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()); });

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen (options => 
    { 
        options.SwaggerDoc ("v1", new OpenApiInfo { Version = "v1", Title = "Tarefas API", Description = "Uma API do ASP.NET para cadastrar tarefas.",} );
        var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
        options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
    });

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
