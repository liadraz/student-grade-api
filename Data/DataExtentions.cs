using System;
using Microsoft.EntityFrameworkCore;

namespace student_grades_api.Data;

public static class DataExtensions
{
    public static async Task MigrateDbAsync(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<StudentGradesContext>();

        await context.Database.MigrateAsync();  // equivalent to `dotnet ef database update`
    }
}
