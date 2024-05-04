using CollelBll.functions;
using CollelBll.interfaces;
using CollelDal.functions;
using CollelDal.interfaces;
using CollelDal.models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//add cors
builder.Services.AddCors(opt => opt.AddPolicy("AllowAll",
    p => p.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));


//add opt of use in automapper
builder.Services.AddAutoMapper(typeof(Program));
//Dependency injection to database
builder.Services.AddDbContext<CollelDbContext>(opt => opt.UseSqlServer
("Server=DESKTOP-ROECGEC\\SQLEXPRESS; Database=CollelDB;" +
" Trusted_Connection=True; TrustServerCertificate=true"));
//Dependency injection to classes
builder.Services.AddScoped<IavrechDal,AvrechDal>();
builder.Services.AddScoped(IavrechBll, AvrechBll);

var app = builder.Build();

//use it
app.UseCors("AllowAll");


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
