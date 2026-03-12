using ClinicSystem.DataAccess;
using Microsoft.EntityFrameworkCore;
using ClinicSystem.AppLogic;
using ClinicSystem.DataAccess.Crud;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//Mapper al SQL(1)
builder.Services.AddDbContext<ClinicDbContext>(options =>options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
//Dependecias (2)
builder.Services.AddScoped<DoctorCrud>();
builder.Services.AddScoped<IDoctorsManager, DoctorsManager>();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();