using MediatR;

namespace VerticalExample.Features.Commands.Products.UpdateProduct
{
    public static class UpdateProductEndpoint
    {
        public static void MapEndpoints(this IEndpointRouteBuilder app)
        {
            app.MapPut("/products/{id:int}", async (IMediator mediator, int id, ProductRequest request) =>
            {
                await mediator.Send(new UpdateProductCommand(id, request.Name, request.SKU, request.Price));
                return Results.NoContent();
            }).WithTags("products");
        }
    }

    
}