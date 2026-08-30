using MediatR;

namespace VerticalExample.Features.Queries.Product.GetProducts
{
    public static class GetProductsEndpoint
    {
        public static void MapEndpoints(this IEndpointRouteBuilder app)
        {
            app.MapGet("/products", async (IMediator mediator, int page = 1, int pageSize = int.MaxValue) =>
            {
                if (page < 1 || pageSize < 1)
                {
                    return Results.BadRequest("page and pageSize must be positive.");
                }

                return Results.Ok(await mediator.Send(new GetAllProductsQuery(page, pageSize)));
            }).WithTags("products");
        }
    }
}