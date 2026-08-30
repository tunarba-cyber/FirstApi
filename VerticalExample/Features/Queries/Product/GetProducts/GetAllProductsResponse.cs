namespace VerticalExample.Features.Queries.Product.GetProducts
{
    public record GetAllProductsResponse(int totalCount,IReadOnlyCollection<GetProductItemResponse> products)
    {
    }
}
