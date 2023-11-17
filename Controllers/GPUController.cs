using comp_company.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace comp_company.Controllers
{

    [ApiController]
    [Route("GPU")]
    public class GPUController : ControllerBase
    {
        [HttpGet]
        [Route("All")]
        public ActionResult All()
        {
            CompContext compContext = new CompContext();
            return Ok(compContext.Gpus);
        }

        [HttpDelete]
        [Route("Delete")]

        public ActionResult Delete()
        {
            return Ok();
        }
        

    }
}
