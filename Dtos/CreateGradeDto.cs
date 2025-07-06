using System.ComponentModel.DataAnnotations;

namespace student_grades_api.Dtos;

public class CreateGradeDto
{
    [Required]
    [StringLength(40)]
    public string Subject { get; set; } = string.Empty;

    [Range(0, 100)]
    public double Score { get; set; }

    [Required]
    int StudentId { get; set; }
}
