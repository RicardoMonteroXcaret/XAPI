using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace XApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MongoController : ControllerBase
    {
        [HttpGet(Name = "TestMongo")]
        public void TestMongo()
        {

        }
    }
}
