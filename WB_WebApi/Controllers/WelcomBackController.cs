using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WelcomeBackTasks;

namespace WB_WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
        
    public class WelcomeBackController: ControllerBase
    {
       
       public WelcomeBackController(){}
        
        [HttpGet("GetPalindromeMin/{decimals}")]
        public int GetMin(int decimals)
        {
            PalindromicStuff p = new PalindromicStuff();
            return p.PalindromeMin(decimals);
        } 

        [HttpGet("GetPalindromeMax/{decimals}")]
        public int GetMax(int decimals)
        {
            PalindromicStuff p = new PalindromicStuff();
            return p.PalindromeMax(decimals);
            // this i s getting me a weird error if i go to 3 decimal places
        } 

        [HttpGet("GetRemainder/{limit}")]
        public int GetRemainder(int limit)
        {
            DividingThingy d = new DividingThingy();
            return d.remaindeCheck(limit);
            
        } 






    }
}