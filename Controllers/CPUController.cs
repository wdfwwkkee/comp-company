using comp_company.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace comp_company.Controllers
{
    public class CPUController : ControllerBase
    {
        [HttpGet]
        [Route("All")]
        public IActionResult GetAll()
        {
            CompContext compContext = new CompContext();
            return Ok(compContext.Cpus);
        }

        [HttpPut]
        [Route("Add")]
        public IActionResult Add(Cpu cpu)
        {
            CompContext compContext = new CompContext();
            compContext.Cpus.Add(cpu);
            compContext.SaveChanges();
            return Ok(cpu);
        }
        [HttpGet]
        [Route("GetById")]
        public IActionResult GetId(int Id)
        {
            CompContext compContext = new CompContext();
            Cpu? cpu = compContext.Cpus.FirstOrDefault(x => x.Id == Id);
            if (cpu == null) { return NotFound(); }
            return Ok();
        }
        [HttpPost]
        [Route("Update")]
        public IActionResult Update(Cpu cpu)
        {
            CompContext compContext = new CompContext(); 
            compContext.Cpus.Update(cpu);
            return Ok(cpu);
        }
        [HttpDelete]
        [Route("Delete")]
        public IActionResult Delete(int Id)
        {
            CompContext compContext = new CompContext();
            Cpu? cpu = compContext.Cpus.FirstOrDefault(x => x.Id == Id);
            if (Id == null) { return NotFound(); }
            compContext.Cpus.Remove(cpu);
            compContext.SaveChanges();
            return Ok();
        }

    }
}
