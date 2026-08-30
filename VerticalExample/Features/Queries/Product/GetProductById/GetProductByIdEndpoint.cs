using MediatR;

namespace VerticalExample.Features.Queries.Product.GetProductById
{
    public static class GetProductByIdEndpoint
    {
        public static void MapEndpoints(this IEndpointRouteBuilder app)
        {
            app.MapGet("/products/{id:int}", async (IMediator mediator, int id) =>
            {
                var result = await mediator.Send(new GetProductByIdQuery(id));
                return result is null ? Results.NotFound() : Results.Ok(result);
            }).WithTags("products");
        }
    }
}