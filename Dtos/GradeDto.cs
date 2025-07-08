using System;

namespace student_grades_api.Dtos;

public class GradeDto
{
    public string Subject { get; set; } = string.Empty;
    public double Score { get; set; }
}
