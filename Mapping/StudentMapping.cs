using student_grades_api.Dtos;
using student_grades_api.Models;

namespace student_grades_api.Mapping;

public static class StudentMapping
{
    public static StudentSummaryDto ToSummaryDto(Student student)
    {
        return new StudentSummaryDto()
        {
            Id = student.Id,
            FullName = student.FullName,
            Phone = student.Phone,
            CreateAt = student.CreateAt,

            Grades = student.Grades.Select(grade => new GradeDto()
            {
                Subject = grade.Subject,
                Score = grade.Score
            }).ToList() ?? new List<GradeDto>(),

            AverageScore = student.Grades
                .Select(g => g.Score)
                .DefaultIfEmpty(0)
                .Average()
        };
    }

    public static StudentDetailsDto ToDetailsDto(Student student)
    {
        return new StudentDetailsDto()
        {
            Id = student.Id,
            FullName = student.FullName,
            Phone = student.Phone,
            CreateAt = student.CreateAt,

            Grades = student.Grades.Select(grade => new GradeDto()
            {
                Subject = grade.Subject,
                Score = grade.Score
            }).ToList() ?? new List<GradeDto>(),

            AverageScore = student.Grades
                .Select(g => g.Score)
                .DefaultIfEmpty(0)
                .Average()
        };
    }

    public static Student ToEntity(CreateStudentDto student)
    {
        return new Student()
        {
            FullName = student.FullName,
            Phone = student.Phone,
            Grades = student.Grades.Select(g => new Grade()
            {
                Subject = g.Subject,
                Score = g.Score
            }).ToList()
        };
    }

    public static void UpdateEntity(Student student, UpdateStudentDto update)
    {
        student.FullName = update.FullName;
        student.Phone = update.Phone;
    }
}
