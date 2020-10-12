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
        
    public class WelcomBackController: ControllerBase
    {
       PalindromicStuff p = new PalindromicStuff();
       WelcomBackController(){}
        
        [HttpGet("{decimals}")]
        public int Get(int decimals)
        {
            return p.PalindromeMin(decimals);
        } 

     







    }
}