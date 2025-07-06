using System;
using System.ComponentModel.DataAnnotations;

namespace student_grades_api.Dtos;

public class CreateStudentDto
{
    [Required]
    [StringLength(30)]
    public string FullName { get; set; } = string.Empty;

    [StringLength(12)]
    public string? Phone { get; set; } 
}
