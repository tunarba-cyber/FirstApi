using MediatR;

namespace VerticalExample.Features.Commands.Products.CreateProduct
{
    public static class CreateProductEndpoint
    {
        public static void MapEndpoints(this IEndpointRouteBuilder app)
        {
            app.MapPost("/products", async (IMediator mediator, CreateProductCommand command) =>
            {
                await mediator.Send(command);
                return Results.Created();
            }).WithTags("products");
        }
    }
}
