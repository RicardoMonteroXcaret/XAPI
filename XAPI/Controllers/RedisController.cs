using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace XApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RedisController : ControllerBase
    {
        [HttpGet(Name = "InsertReadis")]
        public void InsertReadis()
        {

        }
    }
}
