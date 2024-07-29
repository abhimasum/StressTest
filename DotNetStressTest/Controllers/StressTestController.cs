using Microsoft.AspNetCore.Mvc;

namespace DotNetStressTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StressTestController : ControllerBase
    {
        private static bool finish = false;
        
        public StressTestController()
        {
           
        }

        [HttpGet(Name = "GetStressTest")]
        public string Get(bool stoprunning=false)
        {
            finish = stoprunning;
            for (int i = 0;; i++)
            {                
                if (finish)
                    break;               
            }
            return "Running Stops";
        }

        
    }
}