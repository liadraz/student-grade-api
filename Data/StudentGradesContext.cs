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
            // .HasFilter("Phone IS NOT NULL");
    }
}
