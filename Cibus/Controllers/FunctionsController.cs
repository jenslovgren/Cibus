using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cibus.Controllers
{

    [Authorize]
    public class FunctionsController : Controller
    {
        [HttpGet]
        [Route("main")]
        public IActionResult Main()
        {
            return View();
        }
    }
}