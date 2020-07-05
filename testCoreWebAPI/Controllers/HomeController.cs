using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using testCoreWebAPI.Controllers.Base;
using testCoreWebAPI.Models;
using testCoreWebAPI.Models.DataBaseContext;
using testCoreWebAPI.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace testCoreWebAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : RESTfullController<Account, AccountService>
    {
        
    }
}
