using Microsoft.AspNetCore.Mvc;
using Svyaznoi.Context;
using Svyaznoi.Context.Contracts.Models;

namespace Svyaznoi.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RabotaController : ControllerBase
    {
        private readonly IContext context1;
        public RabotaController(IContext context1)
        {
            this.context1 = context1;
        }
        [HttpGet] //localhost:111224/group
        public IActionResult GetAllPlatelshik()
        {
            var postavshiklist = context1.Rabota.ToList();
            return Ok(postavshiklist);
        }
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var postavshiklist = context1.Rabota.FirstOrDefault(x => x.Id == id);
            return Ok(postavshiklist);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var group2 = context1.Rabota.FirstOrDefault(x => x.Id == id);
            if (group2 != null)
            {
                context1.Rabota.Remove(group2);
            }
            return Ok();
        }
        [HttpPost]
        public IActionResult Create(Rabota model)
        {
            var item2 = new Rabota
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
                Ispolnitel = model.Ispolnitel,
                Price = model.Price,
                CreatedAT = DateTime.Now,
                CreatedBy = "Я",
                UpdatedAt = DateTime.Now,
                UpdatedBy = "Я богатырь!"
            };
            context1.Rabota.Add(item2);
            context1.SaveChanges();
            return Ok(item2);
        }
        [HttpPut("{id}")]
        public IActionResult Edit(Guid Id, Rabota model)
        {
            var group2 = context1.Rabota.FirstOrDefault(x => x.Id == Id);
            if (group2 != null)
            {
                return NotFound();
            }
            group2.Name = model.Name;
            group2.Ispolnitel = model.Ispolnitel;
            group2.Price = model.Price;
            group2.UpdatedAt = DateTime.Now;
            context1.SaveChanges();

            return Ok(group2);
        }
    }
}
