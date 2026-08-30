using MediatR;

namespace VerticalExample.Features.Commands.Categories.DeleteCategory
{
    public record DeleteCategoryCommand(int Id):IRequest
    {
    }
}
