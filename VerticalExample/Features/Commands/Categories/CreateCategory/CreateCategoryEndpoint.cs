using MediatR;

namespace VerticalExample.Features.Commands.Categories.CreateCategory
{
    public static class CreateCategoryEndpoint
    {
        public static void MapEndpoints(this IEndpointRouteBuilder app)
        {
            app.MapPost("/categories", async (IMediator mediator, CreateCategoryCommand command) =>
            {
                await mediator.Send(command);
                return Results.Created();
            }).WithTags("categories");
        }
    }
}
