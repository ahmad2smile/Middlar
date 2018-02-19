using Microsoft.AspNetCore.Mvc;
using Middlar.ViewModels;

namespace Middlar.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        [HttpPost]
        public IActionResult Post([FromBody] IncomingRequest value)
        {
            return new JsonResult(value);
        }
    }
}
