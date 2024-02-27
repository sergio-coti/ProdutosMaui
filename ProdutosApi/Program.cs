using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options => options.SwaggerDoc("v1",
                new OpenApiInfo
                {
                    Title = "ProdutosAPI - Treinamento NET MAUI.",
                    Description = "API para consulta de produtos.",
                    Version = "v1",
                    Contact = new OpenApiContact
                    {
                        Name = "COTI Informática",
                        Email = "contato@cotiinformatica.com.br",
                        Url = new Uri("http://www.cotiinformatica.com.br")
                    }
                }));

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseAuthorization();
app.UseStaticFiles();
app.MapControllers();

app.Run();
