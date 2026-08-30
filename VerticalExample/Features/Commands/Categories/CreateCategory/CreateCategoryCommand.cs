using MediatR;

namespace VerticalExample.Features.Commands.Categories.CreateCategory
{
    public record CreateCategoryCommand(string Name):IRequest
    {
    }
}
