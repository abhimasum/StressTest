using Microsoft.AspNetCore.Mvc;

namespace DotNetStressTest.Controllers
{
    [ApiController]
    [Route("{controller}/{action}")]
    public class StressTestController : ControllerBase
    {
       
        
        public StressTestController()
        {
           
        }

        
        public string LongRun()
        {
            long y = 1523;
            //finish = stoprunning;
            for (long i = 0;i<100000; i++)
            {
                y = y * 23;
                y = y / 23;              
            }
            return "Long Run Completes";
        }

        
        public string Test()
        {
            
            return "Hello its working fine!!!";
        }


    }
}