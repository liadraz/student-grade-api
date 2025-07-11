using Microsoft.EntityFrameworkCore;
using student_grades_api.Data;

var builder = WebApplication.CreateBuilder(args);

//
// Builder Setup
//
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Registers controller services (dependency injection, routing, etc.)
builder.Services.AddControllers();

// Register the DbContext with the dependency injection container
var connString = builder.Configuration.GetConnectionString("studentGrades");
builder.Services.AddDbContext<StudentGradesContext>(options =>
    options.UseNpgsql(connString));


var app = builder.Build();

// Register Swagger and its UI middleware that intercept requests to /swagger
app.UseSwagger();
app.UseSwaggerUI();

// Route incoming HTTP requests to controllers using their [Route] attributes
app.MapControllers();

await app.MigrateDbAsync();

await app.RunAsync();