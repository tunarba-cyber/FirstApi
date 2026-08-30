using MediatR;

namespace VerticalExample.Features.Queries.Product.GetProductById
{
    public record GetProductByIdQuery(int Id) : IRequest<GetProductByIdResponse>
    {
    }
    
}
