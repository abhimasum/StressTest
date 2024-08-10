using Microsoft.AspNetCore.Mvc;

namespace DotNetStressTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StressTestController : ControllerBase
    {
       
        
        public StressTestController()
        {
           
        }

        [HttpGet(Name = "GetStressTest")]
        public string Get()
        {
            long y = 55555;
            //finish = stoprunning;
            for (long i = 0;i<100000000; i++)
            {
                y = y * 23;
                y = y / 23;              
            }
            return "Running Stops";
        }

        
    }
}