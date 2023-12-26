using Microsoft.AspNetCore.Mvc;
using Svyaznoi.Context;
using Svyaznoi.Context.Contracts.Models;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

namespace Svyaznoi.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ZakazhikController : ControllerBase
    {
        private readonly IContext context1;
        public ZakazhikController(IContext context1)
        {
            this.context1 = context1;
        }

        [HttpGet] //localhost:111224/group
        public IActionResult GetAllNakladnaya()
        {
            var zakazhik = context1.Zakazhik.ToList();
            return Ok(zakazhik);
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var zakazhik = context1.Zakazhik.FirstOrDefault(x => x.Id == id);
            return Ok(zakazhik);
        }

        [HttpPost]
        public IActionResult Create(Zakazhik model)
        {
            var item = new Zakazhik
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
                Address = model.Address,
                Telefon = model.Telefon,
                CreatedAT = DateTime.Now,
                CreatedBy = "Я",
                UpdatedAt = DateTime.Now,
                UpdatedBy = "Я богатырь!"
            };
            context1.Zakazhik.Add(item);
            context1.SaveChanges();
            return Ok(item);
        }

        [HttpDelete("{id}")] 
        public IActionResult Delete(Guid id) 
        {
            var group = context1.Zakazhik.FirstOrDefault(x => x.Id == id);
            if (group != null)
            {
                context1.Zakazhik.Remove(group);
            }
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Edit(Guid Id, Zakazhik model)
        {
         var group = context1.Zakazhik.FirstOrDefault(x => x.Id == Id);
            if (group != null) 
            {
                return NotFound();
            }
            group.Name = model.Name;
            group.Address = model.Address;
            group.Telefon = model.Telefon;
            group.UpdatedAt = DateTime.Now;
            context1.SaveChanges();

            return Ok(group);
        }
    }
}
