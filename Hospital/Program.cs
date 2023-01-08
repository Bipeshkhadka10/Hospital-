using Hospital.DAL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<HospitalDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DbString"));
});

builder.Services.AddCors(options =>
{
  options.AddPolicy(name: "Alloworigin",
    builder =>
    {
        builder.WithOrigins("https://localhost:7278/api/Doctor", "http://localhost:4200") //cross platform frontend and backend
                             .AllowAnyHeader()
                             .AllowAnyHeader();
    });
});


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
app.UseCors("AllowOrigin");
app.UseAuthorization();

app.MapControllers();

app.Run();
