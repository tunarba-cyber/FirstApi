using MediatR;

namespace VerticalExample.Features.Queries.Category.GetCategories
{
    public static class GetCategoriesEndpoint
    {
        public static void MapEndpoints(this IEndpointRouteBuilder app)
        {
            app.MapGet("/categories", async (IMediator mediator, int page = 1, int pageSize = int.MaxValue) =>
            {
                if (page < 1 || pageSize < 1)
                {
                    return Results.BadRequest("page and pageSize must be positive.");
                }

                return Results.Ok(await mediator.Send(new GetAllCategoriesQuery(page, pageSize)));
            }).WithTags("categories");
        }
    }
}
