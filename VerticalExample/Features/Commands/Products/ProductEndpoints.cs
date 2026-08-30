using VerticalExample.Features.Commands.Products.CreateProduct;
using VerticalExample.Features.Commands.Products.DeleteProduct;
using VerticalExample.Features.Commands.Products.UpdateProduct;
using VerticalExample.Features.Queries.Product.GetProductById;
using VerticalExample.Features.Queries.Product.GetProducts;

namespace VerticalExample.Features.Commands.Products
{
    public static class ProductEndpoints
    {
        public static void MapProductEndpoints(this IEndpointRouteBuilder app)
        {
            CreateProductEndpoint.MapEndpoints(app);
            UpdateProductEndpoint.MapEndpoints(app);
            DeleteProductEndpoint.MapEndpoints(app);
            GetProductByIdEndpoint.MapEndpoints(app);
            GetProductsEndpoint.MapEndpoints(app);
        }
    }
}