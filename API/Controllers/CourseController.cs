using API.Controllers;
using Entity.Interfaces;
using Entity;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class CoursesController : BaseController
{
    private readonly ICourseRepository _repo;

    public CoursesController(ICourseRepository repo)
    {
        _repo = repo;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Course>>> GetCourses()
    {
        var courses = await _repo.GetAllAsync();
        return Ok(courses);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Course>> GetCourse(Guid id)
    {
        var course = await _repo.GetByIdAsync(id);
        return course is null ? NotFound() : Ok(course);
    }

    [HttpPost]
    public async Task<ActionResult> CreateCourse(Course course)
    {
        await _repo.AddAsync(course);
        await _repo.SaveChangesAsync();
        return CreatedAtAction(nameof(GetCourse), new { id = course.Id }, course);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteCourse(Guid id)
    {
        var course = await _repo.GetByIdAsync(id);
        if (course == null) return NotFound();

        _repo.Remove(course);
        await _repo.SaveChangesAsync();
        return NoContent();
    }
}
