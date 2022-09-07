// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using Project2_IoT_Management.Models;

var builder = WebApplication.CreateBuilder(args);

//ConfigureServices
builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "InternetOfThings",
        Description = "Simple test",
    });
});


// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<CategoriesContext>(opt => 
    opt.UseInMemoryDatabase("Category"));
builder.Services.AddDbContext<DeviceContext>(opt =>
    opt.UseInMemoryDatabase("Device"));
builder.Services.AddDbContext<ZoneContext>(opt =>
    opt.UseInMemoryDatabase("Zone"));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();

}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Showing API V1");
});
app.Run();
