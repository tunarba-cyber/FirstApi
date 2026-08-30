using MediatR;

namespace VerticalExample.Features.Queries.Category.GetCategoryById
{
    public record GetCategoryByIdQuery(int Id) : IRequest<GetCategoryByIdResponse?>
    {
    }
}
