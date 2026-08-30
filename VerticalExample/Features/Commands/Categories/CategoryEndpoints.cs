using VerticalExample.Features.Commands.Categories.CreateCategory;
using VerticalExample.Features.Commands.Categories.DeleteCategory;
using VerticalExample.Features.Commands.Categories.UpdateCategory;
using VerticalExample.Features.Queries.Category.GetCategoryById;
using VerticalExample.Features.Queries.Category.GetCategories;

namespace VerticalExample.Features.Commands.Categories
{
    public static class CategoryEndpoints
    {
        public static void MapCategoryEndpoints(this IEndpointRouteBuilder app)
        {
            CreateCategoryEndpoint.MapEndpoints(app);
            UpdateCategoryEndpoint.MapEndpoints(app);
            DeleteCategoryEndpoint.MapEndpoints(app);
            GetCategoryByIdEndpoint.MapEndpoints(app);
            GetCategoriesEndpoint.MapEndpoints(app);
        }
    }
}
