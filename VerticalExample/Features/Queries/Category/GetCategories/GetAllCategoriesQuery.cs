using MediatR;

namespace VerticalExample.Features.Queries.Category.GetCategories
{
    public record GetAllCategoriesQuery(int page,int pageSize):IRequest<GetAllCategoriesResponse>
    {
    }
}
