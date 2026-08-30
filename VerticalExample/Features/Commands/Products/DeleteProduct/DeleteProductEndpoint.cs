using MediatR;

namespace VerticalExample.Features.Commands.Products.DeleteProduct
{
    public static class DeleteProductEndpoint
    {
        public static void MapEndpoints(this IEndpointRouteBuilder app)
        {
            app.MapDelete("/products/{id:int}", async (IMediator mediator, int id) =>
            {
                await mediator.Send(new DeleteProductCommand(id));
                return Results.NoContent();
            }).WithTags("products");
        }
    }
}