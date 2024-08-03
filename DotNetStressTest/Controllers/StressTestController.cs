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
            long y = 1;
            //finish = stoprunning;
            for (long i = 0;i<100000000; i++)
            {
                y++;
                y=y / 100;
            }
            return "Running Stops";
        }

        
    }
}