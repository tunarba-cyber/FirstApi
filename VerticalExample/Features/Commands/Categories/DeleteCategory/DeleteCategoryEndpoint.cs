using MediatR;

namespace VerticalExample.Features.Commands.Categories.DeleteCategory
{
    public static class DeleteCategoryEndpoint
    {
        public static void MapEndpoints(this IEndpointRouteBuilder app)
        {
            app.MapDelete("/categories/{id:int}", async (IMediator mediator, int id) =>
            {
                await mediator.Send(new DeleteCategoryCommand(id));
                return Results.NoContent();
            }).WithTags("categories");
        }
    }
}
