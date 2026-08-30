using MediatR;

namespace VerticalExample.Features.Commands.Categories.UpdateCategory
{
    public record UpdateCategoryCommand(int Id,string Name):IRequest
    {
    }
}
