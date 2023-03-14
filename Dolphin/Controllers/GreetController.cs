using Microsoft.AspNetCore.Mvc;

namespace Dolphin.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GreetController : Controller
    {
        [HttpGet]
        public string Index()
        {
            return "Hello, World!";
        }
    }
}
