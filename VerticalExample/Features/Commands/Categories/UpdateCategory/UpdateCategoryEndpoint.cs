using MediatR;

namespace VerticalExample.Features.Commands.Categories.UpdateCategory
{
    public static class UpdateCategoryEndpoint
    {
        public static void MapEndpoints(this IEndpointRouteBuilder app)
        {
            app.MapPut("/categories/{id:int}", async (IMediator mediator, int id, CategoryRequest request) =>
            {
                await mediator.Send(new UpdateCategoryCommand(id, request.Name));
                return Results.NoContent();
            }).WithTags("categories");
        }
    }
}
