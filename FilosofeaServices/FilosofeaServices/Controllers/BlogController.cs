using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

using FilosofeaDomain.ServiceInterfaces;
using FilosofeaDomain.DomainInterfaces;

namespace FilosofeaServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";

        }
        [HttpGet("GetEntradas")]
        public IEnumerable<IEntrada> GetEntradas(int idUser)
        {
            DateTime desde = DateTime.Now.AddYears(-1);
            DateTime hasta = DateTime.Now;

            var result = _blogService.getEntradas(idUser, desde, hasta, null);

            return result;
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
