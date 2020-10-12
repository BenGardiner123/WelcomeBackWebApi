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
        
        [HttpGet("{decimals}")]
        public int Get(int decimals)
        {
            PalindromicStuff p = new PalindromicStuff();
            return p.PalindromeMin(decimals);
        } 

     







    }
}