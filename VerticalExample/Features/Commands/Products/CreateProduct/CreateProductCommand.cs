using MediatR;

namespace VerticalExample.Features.Commands.Products.CreateProduct
{
    public record CreateProductCommand(string Name,string SKU,decimal Price):IRequest
    {
    }
}
