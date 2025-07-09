using System;
using student_grades_api.Models;

namespace student_grades_api.Data;

public static class DBInitializer
{
    public static async Task SeedDataAsync(StudentGradesContext context)
    {
        if (context.Grades.Any())
        {
            return;
        }

        await context.Grades.AddRangeAsync(new List<Grade>
        {
            new Grade { Subject = "Math", Score = 85, StudentId = 1 },
            new Grade { Subject = "English", Score = 78, StudentId = 1 },
            new Grade { Subject = "History", Score = 90, StudentId = 1 },

            new Grade { Subject = "Math", Score = 88, StudentId = 2 },
            new Grade { Subject = "English", Score = 74, StudentId = 2 },
            new Grade { Subject = "Science", Score = 82, StudentId = 2 },

            new Grade { Subject = "Math", Score = 92, StudentId = 3 },
            new Grade { Subject = "History", Score = 86, StudentId = 3 },
            new Grade { Subject = "Science", Score = 89, StudentId = 3 }
        });

        await context.SaveChangesAsync();
    }
}
