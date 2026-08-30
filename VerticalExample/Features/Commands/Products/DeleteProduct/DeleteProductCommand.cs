using MediatR;

namespace VerticalExample.Features.Commands.Products.DeleteProduct
{
    public record DeleteProductCommand(int Id):IRequest
    {
    }
}
