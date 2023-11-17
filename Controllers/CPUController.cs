using comp_company.Models;
using Microsoft.AspNetCore.Mvc;

namespace comp_company.Controllers
{
    public class CPUController : Controller
    {
        [HttpGet]
        [Route("All")]
        public IActionResult GetAll()
        {
            CompContext compContext = new CompContext();
            return Ok(compContext.Cpus);
        }
    }
}
