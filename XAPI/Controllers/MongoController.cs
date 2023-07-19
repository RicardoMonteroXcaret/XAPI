using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using XLogic;

namespace XApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MongoController : ControllerBase
    {
        public MongoController(IMongo )
        {
                
        }

        [HttpGet(Name = "TestMongo")]
        public void TestMongo()
        {

        }
    }
}
