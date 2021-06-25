using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using FilosofeaDomain.DomainInterfaces;
using FilosofeaDomain.ServiceInterfaces;

namespace FilosofeaServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FiloController : ControllerBase
    {
        private IFiloService _filoService;

        public FiloController(IFiloService filoService)
        {
            _filoService = filoService;
        }

        // GET: api/<QueryController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<QueryController>/5
        [HttpGet("GetAutor/{id}")]
        public IAutor GetAutor(long id)
        {
            return _filoService.getAutor(id);
        }

        // POST api/<QueryController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<QueryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<QueryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
