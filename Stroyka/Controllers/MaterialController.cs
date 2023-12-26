using Microsoft.AspNetCore.Mvc;
using Svyaznoi.Context;
using Svyaznoi.Context.Contracts.Models;

namespace Svyaznoi.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MaterialController : ControllerBase
    {
        private readonly IContext context1;
        public MaterialController(IContext context1)
        {
            this.context1 = context1;
        }
        [HttpGet] //localhost:111224/group
        public IActionResult GetAllTovar()
        {
            var tovarlist = context1.Material.ToList();
            return Ok(tovarlist);
        }
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var tovarlist = context1.Material.FirstOrDefault(x => x.Id == id);
            return Ok(tovarlist);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var group3 = context1.Material.FirstOrDefault(x => x.Id == id);
            if (group3 != null)
            {
                context1.Material.Remove(group3);
            }
            return Ok();
        }
        [HttpPost]
        public IActionResult Create(Material model)
        {
            var item3 = new Material
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
                Edizmer= model.Edizmer,
                Value = model.Value,
                Price = model.Price,
                CreatedAT = DateTime.Now,
                CreatedBy = "Я",
                UpdatedAt = DateTime.Now,
                UpdatedBy = "Я богатырь!"
            };
            context1.Material.Add(item3);
            context1.SaveChanges();
            return Ok(item3);
        }
        [HttpPut("{id}")]
        public IActionResult Edit(Guid Id, Material model)
        {
            var group3 = context1.Material.FirstOrDefault(x => x.Id == Id);
            if (group3 != null)
            {
                return NotFound();
            }
            group3.Name = model.Name;
            group3.Edizmer= model.Edizmer;
            group3.Value= model.Value;
            group3.Price = model.Price;
            group3.UpdatedAt = DateTime.Now;
            context1.SaveChanges();

            return Ok(group3);
        }
    }
}
