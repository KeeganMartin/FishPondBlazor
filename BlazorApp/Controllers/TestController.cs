using Microsoft.AspNetCore.Mvc;

namespace BlazorApp.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class TestController : Controller
    {
        [HttpGet("[action]")]
        public ActionResult<string> Test()
        {
            return "Hello, World";
        }
    }
}