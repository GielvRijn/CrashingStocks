using Microsoft.AspNetCore.Mvc;

namespace CrashingStocks.Controllers
{
    [ApiController]
    [Route("NewApi/[Controller]")]
    public class NewController : ControllerBase
    {
        [HttpGet]
        public string SayHii()
        {
            return "Hii Learners";
        }
    }
}
