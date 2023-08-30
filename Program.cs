using Microsoft.EntityFrameworkCore;
using MyAPI.ApiConnections;
using MyAPI.Services;
using MyAPI.Services.IServices;

var builder = WebApplication.CreateBuilder(args);

//creating a connection
builder.Services.AddDbContext<ApiDbConnection>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("localConnection"));
});

//registering services (dependency injection)
builder.Services.AddScoped<IIstructorService, InstructorService>();
//adding autoMapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
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

app.UseAuthorization();

app.MapControllers();

app.Run();
