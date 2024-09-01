using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace AllTask.API.Controllers
{
    [Route("api/routine")]
    [ApiController]
    public class RoutineController : ControllerBase
    {
        [HttpPost]
        public IActionResult saveRoutine()
        {
            return Ok();
        }
    }
}
