using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WEB_API_CORE_ResultFilterDemo.Controllers
{
   // [ServiceFilter(typeof(CustomResultFilter))]
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        [HttpGet]
    
        public IActionResult Get()
        {
            return Ok(new { Id = 1, Name = "Prakash" });
        }
    }
}
