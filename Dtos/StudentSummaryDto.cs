namespace student_grades_api.Dtos;

public class StudentSummaryDto
{
    public int Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string? Phone { get; set; }
    public DateTime CreateAt { get; set; }
    public double AverageScore { get; set; }
}
