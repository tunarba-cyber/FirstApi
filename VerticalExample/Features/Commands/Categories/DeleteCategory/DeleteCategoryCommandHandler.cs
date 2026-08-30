using MediatR;
using Microsoft.EntityFrameworkCore;
using VerticalExample.Models;
using VerticatExample.Data;

namespace VerticalExample.Features.Commands.Categories.DeleteCategory
{
    public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommand>
    {
        private readonly IAppDbContext _context;

        public DeleteCategoryCommandHandler(IAppDbContext context)
        {
            _context = context;
        }
        public async Task Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            Category? existed = await _context.Categories.FirstOrDefaultAsync(c => c.Id == request.Id);
            if (existed is null) throw new Exception("Not found");
            _context.Categories.Remove(existed);
            await _context.SaveChangesAsync();
        }
    }
}
