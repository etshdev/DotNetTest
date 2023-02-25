using AutoMapper;
using DotNetTest.DTO;
using DotNetTest.IOC;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DotNetTest.DAL.AppContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DotNetTest_Connection"));
}, ServiceLifetime.Transient);
builder.Services.RegisterServices();
// Auto Mapper Configurations

var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new MappingProfile());
});

IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("corsapp");
        

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();



app.Run();
