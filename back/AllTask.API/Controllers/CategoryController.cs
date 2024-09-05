using AllTask.Application.Models;
using AllTask.Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace AllTask.API.Controllers;

[ApiController]
[Route("api/category")]
public class CategoryController : ControllerBase
{
    private readonly AllTaskDbContext _context;

    public CategoryController(AllTaskDbContext context)
    {
        _context = context;
    }
    
    [HttpPost]
    public async Task<IActionResult> SaveCategory(CreateCategoryInputModel model)
    {
        var category = model.FromEntity();

        await _context.Categories.AddAsync(category);
        await _context.SaveChangesAsync();
        
        return Ok();
    }
}