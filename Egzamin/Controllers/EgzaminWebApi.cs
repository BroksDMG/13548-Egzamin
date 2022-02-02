using Egzamin.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EgzaminNrIndexu13548.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class EgzaminWebApi : ControllerBase
    {
        // GET: api/<EgzaminWebApi>
        [HttpGet]
        public List<EgzaminModel> GetEgzamin()
        {
            return new List<EgzaminModel>()
            {
                new EgzaminModel()
                {
                    Id= 1,
                    Title="AAAA",
                     Author= "BBBB",
                      Price= 100
                },
                new EgzaminModel()
                {   
                    Id= 2,
                    Title="CCC",
                     Author= "DDD",
                      Price= 50
                },
                new EgzaminModel()
                {
                    Id= 3,
                    Title="EEEE",
                     Author= "FFFF",
                      Price= 10
                }
            };
        }

        // DELETE api/<EgzaminWebApi>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id < 5 && id > 0)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
