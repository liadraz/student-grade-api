using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using student_grades_api.Data;
using student_grades_api.Dtos;
using student_grades_api.Mapping;
using student_grades_api.Models;

namespace student_grades_api.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentsController : ControllerBase
{
    private readonly StudentGradesContext _context;

    public StudentsController(StudentGradesContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<List<StudentSummaryDto>> GetAll([FromQuery] double? minAverage)
    {
        var studentsQuery = _context.Students
            .Include(student => student.Grades)
            .AsNoTracking()
            .AsQueryable();

        if (minAverage.HasValue)
        {
            studentsQuery = studentsQuery
                .Where(student => student.Grades.Any())
                .Where(student => student.Grades.Average(grade => grade.Score) >= minAverage.Value);
        }

        var students = studentsQuery
            .Select(student => StudentMapping.ToSummaryDto(student))
            .ToList();

        return Ok(students);
    }

    [HttpGet("{id}")]
    public ActionResult<StudentDetailsDto> GetById(int id)
    {
        Student? student = _context.Students.Find(id);

        return student is null ?
            NotFound() : Ok(StudentMapping.ToDetailsDto(student));
    }

    [HttpPost]
    public ActionResult<StudentDetailsDto> Create(CreateStudentDto newStudent)
    {
        var student = StudentMapping.ToEntity(newStudent);

        _context.Students.Add(student);
        _context.SaveChanges();

        var result = StudentMapping.ToDetailsDto(student);

        return CreatedAtAction(nameof(GetById), new { id = student.Id }, result);
    }

    [HttpPut("{id}")]
    public ActionResult Update(int id, UpdateStudentDto updateStudent)
    {
        Student? student = _context.Students.Find(id);
        if (student is null) return NotFound();

        StudentMapping.UpdateEntity(student, updateStudent);
        _context.SaveChanges();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        Student? student = _context.Students.Find(id);
        if (student is null) return NotFound();

        _context.Students.Remove(student);
        _context.SaveChanges();

        return NoContent();
    }
}
