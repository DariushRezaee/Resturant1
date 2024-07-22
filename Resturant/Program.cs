using Microsoft.EntityFrameworkCore;
using Resturant.CustomerServices;
using Resturant.Db;
using Resturant.FoodRepository;
using Resturant.FoodServices;
using Resturant.Repository;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



builder.Services.AddDbContext<MyDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DariushCS"));
});


builder.Services.AddControllers();

builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<ICustomerRepo, CustomerRepo>();
builder.Services.AddScoped<IFoodService, FoodService>();
builder.Services.AddScoped<IFoodRepo, FoodRepo>();
builder.Services.AddScoped<MyDbContext, MyDbContext>();

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

app.UseAuthorization();

app.MapControllers();

app.Run();
