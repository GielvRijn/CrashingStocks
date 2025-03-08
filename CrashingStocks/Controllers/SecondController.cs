using Microsoft.AspNetCore.Mvc;

namespace CrashingStocks.Controllers
{
    [ApiController]
    [Route("SecondApi/[action]")]
    public class SecondController : ControllerBase
    {
        [HttpGet]
        public string NeverSayHii()
        {
            return "HelloLearners";
        }
    }
}
