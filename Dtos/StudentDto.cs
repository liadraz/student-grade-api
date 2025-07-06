namespace student_grades_api.Dtos;

public class StudentDto
{
    public int Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string? Phone { get; set; }
    public DateTime CreateAt { get; set; }
    public List<GradeDto> Grades { get; set; } = new List<GradeDto>();
    public double AverageScore { get; set; }
}
