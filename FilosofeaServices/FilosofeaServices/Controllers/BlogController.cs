using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;

using FilosofeaDomain.ServiceInterfaces;
using FilosofeaDomain.DomainInterfaces;
using FilosofeaDomain.DTO.Request;

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
        [HttpPost("GetEntradas")]
        public IEnumerable<IEntrada> GetEntradas(int idUser, [FromBody] GetEntradasFilterRequest filterRequest)
        {
            var result = _blogService.getEntradas(idUser, filterRequest);

            return result;
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut]
        public void Put([FromBody] PutEntradaRequest putEntradaRequest)
        {
            _blogService.PutEntrada(putEntradaRequest);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
