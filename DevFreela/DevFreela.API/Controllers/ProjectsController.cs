using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [Route("api/projects")]
    public class ProjectsController : Controller
    {
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
