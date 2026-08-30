using MediatR;

namespace VerticalExample.Features.Commands.Products.UpdateProduct
{
    public record UpdateProductCommand(int Id,string Name,string SKU,decimal Price):IRequest
    {
    }
}
