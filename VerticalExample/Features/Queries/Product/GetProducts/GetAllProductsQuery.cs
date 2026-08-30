using MediatR;

namespace VerticalExample.Features.Queries.Product.GetProducts
{
    public record GetAllProductsQuery(int page,int pageSize):IRequest<GetAllProductsResponse>
    {
    }
}
