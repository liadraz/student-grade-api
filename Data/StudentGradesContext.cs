using System;
using Microsoft.EntityFrameworkCore;
using student_grades_api.Models;

namespace student_grades_api.Data;

public class StudentGradesContext : DbContext
{
    public StudentGradesContext(DbContextOptions<StudentGradesContext> options)
        : base(options) { }

    public DbSet<Student> Students { get; set; }
    public DbSet<Grade> Grades { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Grade>()
            .HasOne(g => g.Student)
            .WithMany(s => s.Grades)
            .HasForeignKey(g => g.StudentId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<Student>()
            .HasIndex(s => s.Phone)
            .IsUnique();

        DateTime createdAt = new DateTime(2025, 7, 9, 0, 0, 0, DateTimeKind.Utc);

        builder.Entity<Student>().HasData(
            new Student {
                Id = 1,
                FullName = "Liad Raz",
                Phone = "0555912051",
                CreateAt = createdAt},
            new Student
            {
                Id = 2,
                FullName = "Yoav Elad",
                Phone = "0555912281",
                CreateAt = createdAt},
            new Student
            {
                Id = 3,
                FullName = "Biscuit Potato",
                Phone = "0585917051",
                CreateAt = createdAt}
        );

        builder.Entity<Grade>().HasData(
            new Grade { Id = 1, Subject = "Math", Score = 90, StudentId = 1 },
            new Grade { Id = 2, Subject = "English", Score = 85, StudentId = 1 },
            new Grade { Id = 3, Subject = "History", Score = 78, StudentId = 1 },

            new Grade { Id = 4, Subject = "Math", Score = 88, StudentId = 2 },
            new Grade { Id = 5, Subject = "Science", Score = 91, StudentId = 2 },
            new Grade { Id = 6, Subject = "Literature", Score = 84, StudentId = 2 },

            new Grade { Id = 7, Subject = "Physics", Score = 76, StudentId = 3 },
            new Grade { Id = 8, Subject = "Chemistry", Score = 82, StudentId = 3 },
            new Grade { Id = 9, Subject = "Math", Score = 89, StudentId = 3 }
        );
    }
}
