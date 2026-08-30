//using MediatR;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using VerticalExample.Features.Commands.Products.CreateProduct;
//using VerticalExample.Features.Commands.Products.DeleteProduct;
//using VerticalExample.Features.Commands.Products.UpdateProduct;
//using VerticalExample.Features.Queries.Product.GetProductById;
//using VerticalExample.Features.Queries.Product.GetProducts;
//using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

//namespace VerticalExample.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ProductsController : ControllerBase
//    {
//        private readonly IMediator _mediator;

//        public ProductsController(IMediator mediator)
//        {
//            _mediator = mediator;
//        }
//        [HttpPost]
//        public async Task<IActionResult> Create([FromForm]CreateProductCommand command)
//        {
//            ;
//            await _mediator.Send(command);
//            return Created();
//        }


//        [HttpPut]
//        public async Task<IActionResult> Update( int? id, [FromForm] ProductRequest request)
//        {
            
//            await _mediator.Send(new UpdateProductCommand(id.Value,request.Name,request.SKU,request.Price));
//            return NoContent();
//        }
//        [HttpGet]
//        public async Task<IActionResult> Get(int page=1,int pageSize=int.MaxValue)
//        {

//            return Ok(await _mediator.Send(new GetAllProductsQuery(page,pageSize)));
//        }

//        [HttpGet("{id}")]
//        public async Task<IActionResult> Get(int? id) 
//        {
            
//            return Ok(await _mediator.Send(new GetProductByIdQuery(id.Value)));
//        }
//        [HttpDelete("{id}")]
//        public async Task<IActionResult> Delete(int? id) 
//        {
//            await _mediator.Send(new DeleteProductCommand(id.Value));
//            return NoContent();
//        }

        
//    }
//}
