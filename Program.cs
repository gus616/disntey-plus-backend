using disntney_plus_api.Data;
using disntney_plus_api.Models;
using disntney_plus_api.Repositories;
using disntney_plus_api.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container


builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddScoped<ICommonRepository<Category>, CategoriesRepository>();
builder.Services.AddScoped<ICommonService<Category>, CategoriesService>();

builder.Services.AddScoped<IMovieRepository, MovieRepository>();
builder.Services.AddScoped<IMovieService, MovieService>();

builder.Services.AddDbContext<AppDbContext>(options =>
 options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
builder.Services.AddOpenApi();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "react-app-client", builder =>
    {
        builder.WithOrigins("http://localhost:5173", "https://nice-ocean-0db720610.1.azurestaticapps.net")
        .AllowAnyHeader()
        .AllowAnyMethod()
        .AllowCredentials();
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}


app.UseCors("react-app-client");
// Enable controllers
app.MapControllers();

app.Run();
