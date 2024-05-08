using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.IRepositories;
using Shared.Models;

namespace BlazorAutoCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _repository;

        public ProductsController(IProductRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<ActionResult<List<Product>>> Get()
        {
            return Ok(await _repository.Get());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Product>> Get(int id)
        {
            var model = await _repository.Get(id);
            if (model == null) { return NotFound(); }
            return Ok(model);
        }

        [HttpPost]
        public async Task<ActionResult<Product>> Post([FromBody] Product model)
        {
            var result = await _repository.Add(model);
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult<Product>> Put([FromBody] Product model)
        {
            var result = await _repository.Update(model);
            return Ok(result);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Product>> Delete(int id)
        {
            var result = await _repository.Delete(id);
            return Ok(result);
        }
    }
}
