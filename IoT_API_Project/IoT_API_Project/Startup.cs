// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Project2_IoT_Management.Models;
using Microsoft.AspNetCore.Hosting;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Configuration;



var builder = WebApplication.CreateBuilder(args);

IServiceCollection services = builder.Services;



    //ConfigureServices
services.AddSwaggerGen();
services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "InternetOfThings",
        Description = "Simple test",
    });
});

// Add services to the container.

services.AddControllers();
    
services.AddDbContext<CategoriesContext>(opt => 
   opt.UseInMemoryDatabase("Category"));
/*services.AddMvc();
services.AddDbContext<CategoriesContext>(options =>
{
    options.UseSqlServer("DefaultConnection");
});*/

services.AddDbContext<DeviceContext>(opt =>
    opt.UseInMemoryDatabase("Device"));
services.AddDbContext<ZoneContext>(opt =>
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
