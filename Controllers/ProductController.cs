using CQRSExample.CQRS.Commands;
using CQRSExample.CQRS.Queries;
using CQRSExample.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CQRSExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : Controller
    {
        private readonly IMediator mediator;
        public ProductController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var query = new GetProductByIdQueryRequest() { Id = id };
            return Ok(await mediator.Send(query));
        }

        [HttpGet()]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllProductQueryRequest();
            return Ok(await mediator.Send(query));
        }

        [HttpPost()]
        public async Task<IActionResult> Post(CreateProductCommand createCommand)
        {
            return Ok(await mediator.Send(createCommand));
        }

        [HttpDelete()]
        public async Task<IActionResult> Delete(DeleteProductCommand deleteCommand)
        {
            return Ok(await mediator.Send(deleteCommand));
        }

        [HttpPut()]
        public async Task<IActionResult> Update(UpdateProductCommand updateCommand)
        {
            return Ok(await mediator.Send(updateCommand));
        }
    }
}
