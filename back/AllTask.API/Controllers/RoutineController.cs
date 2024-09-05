using AllTask.Application.Models;
using AllTask.Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AllTask.API.Controllers;

[ApiController]
[Route("api/routine")]
public class RoutineController : ControllerBase
{
    private readonly AllTaskDbContext _context;

    public RoutineController(AllTaskDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> SaveRoutine([FromBody] CreateRoutineInputModel model)
    {
        var routine = model.FromEntity();

        await _context.Routines.AddAsync(routine);
        await _context.SaveChangesAsync();
        
        return NoContent();
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _context.Routines
            .Include(r => r.Category)
            .Where(r => !r.IsDeleted)
            .ToListAsync();
        
        return Ok(result);
    }
}