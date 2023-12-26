using Microsoft.AspNetCore.Mvc;
using Svyaznoi.Context;
using Svyaznoi.Context.Contracts.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Svyaznoi.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RabotnikController : ControllerBase
    {
        private readonly IContext context1;
        public RabotnikController(IContext context1)
        {
            this.context1 = context1;
        }
        [HttpGet] //localhost:111224/group
        public IActionResult GetAllPlatelshik()
        {
            var platelshiklist = context1.Rabotnik.ToList();
            return Ok(platelshiklist);
        }
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var platelshiklist = context1.Rabotnik.FirstOrDefault(x => x.Id == id);
            return Ok(platelshiklist);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var group1 = context1.Rabotnik.FirstOrDefault(x => x.Id == id);
            if (group1 != null)
            {
                context1.Rabotnik.Remove(group1);
            }
            return Ok();
        }
        [HttpPost]
        public IActionResult Create(Rabotnik model)
        {
            var item1 = new Rabotnik
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
                Adres = model.Adres,
                Index = model.Index,
                Email = model.Email,
                Number = model.Number,
                CreatedAT = DateTime.Now,
                CreatedBy = "Я",
                UpdatedAt = DateTime.Now,
                UpdatedBy = "Я богатырь!"
            };
            context1.Rabotnik.Add(item1);
            context1.SaveChanges();
            return Ok(item1);
        }
        [HttpPut("{id}")]
        public IActionResult Edit(Guid Id, Rabotnik model)
        {
            var group1 = context1.Rabotnik.FirstOrDefault(x => x.Id == Id);
            if (group1 != null)
            {
                return NotFound();
            }
            group1.Name = model.Name;
            group1.Adres = model.Adres;
            group1.Index = model.Index;
            group1.Email = model.Email;
            group1.Number = model.Number;
            group1.UpdatedAt = DateTime.Now;
            context1.SaveChanges();

            return Ok(group1);
        }
    }
}
