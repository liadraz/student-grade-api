using System.ComponentModel.DataAnnotations;

namespace student_grades_api.Models;

public class Student
{
    public int Id { get; set; }

    [Required]
    [StringLength(30)]
    public string FullName { get; set; } = string.Empty;

    [StringLength(12)]
    public string? Phone { get; set; }

    public DateTime CreateAt { get; set; } = DateTime.UtcNow;

    // Navigation property
    public List<Grade> Grades { get; set; } = new List<Grade>();
}
