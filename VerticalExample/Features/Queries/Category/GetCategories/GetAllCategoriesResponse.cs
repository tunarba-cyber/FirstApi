namespace VerticalExample.Features.Queries.Category.GetCategories
{
    public record GetAllCategoriesResponse(int totalCount,IReadOnlyCollection<GetCategoryItemResponse> categories)
    {
    }
}
