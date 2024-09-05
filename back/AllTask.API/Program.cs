using AllTask.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var AllowAllOrigins = "AllowAllOrigins";

// Add services to the container.

builder.Services.AddControllers();

var connectionString = builder.Configuration.GetConnectionString("AllTask");
builder.Services.AddDbContext<AllTaskDbContext>(o => o.UseSqlServer(connectionString));

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: AllowAllOrigins,
        configurePolicy: policy =>
        {
            policy.AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
    
});

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseCors(AllowAllOrigins);


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
