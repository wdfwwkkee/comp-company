using comp_company.Models;
using Microsoft.AspNetCore.Mvc;

namespace comp_company.Controllers
{
    public class GPUController : ControllerBase
    {
        [HttpGet]
        [Route("All")]
        public IActionResult All()
        {
            CompContext compContext = new CompContext();
            return Ok(compContext.Gpus);
        }

        [HttpPut]
        [Route("Add")]
        public IActionResult Add(Gpu gpu)
        {
            CompContext compContext = new CompContext();
            compContext.Gpus.Add(gpu);
            compContext.SaveChanges();
            return Ok(gpu);
        }

        [HttpDelete]
        [Route("Delete")]
        public ActionResult Delete(int id)
        {
            CompContext compContext = new CompContext();
            Gpu? gpu = compContext.Gpus.FirstOrDefault(g => g.Id == id);
            
            if (id == null) { return NotFound(); }

            compContext.Gpus.Remove(gpu);
            compContext.SaveChanges();
            return Ok();
        }

        [HttpGet]
        [Route("GetById")]
        public IActionResult GetById(int id)
        {
            CompContext compContext = new CompContext();
            Gpu? gpu = compContext.Gpus.FirstOrDefault(g => g.Id == id);
            if (gpu == null) { return NotFound(); }
            return Ok();
        }

        [HttpPost]
        [Route("Update")]
        public IActionResult Update(Gpu gpu)
        {
            CompContext compContext = new CompContext();
            compContext.Gpus.Update(gpu);
            return Ok(gpu);
        }


    }
}
