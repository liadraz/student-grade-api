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
            CreateAt = student.CreateAt
        };
    }

    public static StudentDetailsDto ToDetailsDto(Student student)
    {
        return new StudentDetailsDto()
        {
            Id = student.Id,
            FullName = student.FullName,
            Phone = student.Phone,
            CreateAt = student.CreateAt
        };
    }

    public static Student ToEntity(CreateStudentDto student)
    {
        return new Student()
        {
            FullName = student.FullName,
            Phone = student.Phone,
        };
    }

    public static void UpdateEntity(Student student, UpdateStudentDto updateStudent)
    {
        student.FullName = updateStudent.FullName;
        student.Phone = updateStudent.Phone;
    }
}
