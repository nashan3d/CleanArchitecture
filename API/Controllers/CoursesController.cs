using Core;
using Core.Courses.Commands;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> AddCourse(CreateCourseDto input)
        {
            var result = await Mediator.Send(new CreateCourseCommand(input));
            return Ok(result);
        }
    }
}
