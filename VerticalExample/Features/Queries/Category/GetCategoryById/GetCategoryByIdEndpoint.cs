using MediatR;

namespace VerticalExample.Features.Queries.Category.GetCategoryById
{
    public static class GetCategoryByIdEndpoint
    {
        public static void MapEndpoints(this IEndpointRouteBuilder app)
        {
            app.MapGet("/categories/{id:int}", async (IMediator mediator, int id) =>
            {
                var result = await mediator.Send(new GetCategoryByIdQuery(id));
                return result is null ? Results.NotFound() : Results.Ok(result);
            }).WithTags("categories");
        }
    }
}
