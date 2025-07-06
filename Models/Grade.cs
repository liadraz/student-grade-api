using System.ComponentModel.DataAnnotations;

namespace student_grades_api.Models;

public class Grade
{
    public int Id { get; set; }

    [Required]
    public string Subject { get; set; } = string.Empty;

    [Range(0, 100)]
    public double Score { get; set; }

    // Foreign Key
    public int StudentId { get; set; }
    
    // Navigation property
    public Student? Student { get; set; }
}
