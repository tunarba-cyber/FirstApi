using MediatR;
using Microsoft.EntityFrameworkCore;
using VerticalExample.Models;
using VerticatExample.Data;

namespace VerticalExample.Features.Commands.Categories.UpdateCategory
{
    public class UpdateCategoryCommandHandler:IRequestHandler<UpdateCategoryCommand>
    {
        private readonly IAppDbContext _context;

        public UpdateCategoryCommandHandler(IAppDbContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            bool result = await _context.Categories.AnyAsync(c => c.Name == request.Name && c.Id != request.Id);
            if (result is true)
            {
                throw new Exception("Already exists");
            }
            Category? existed = await _context.Categories.FirstOrDefaultAsync(c => c.Id == request.Id);
            if (existed is null) throw new Exception("Not found");

            existed.Name = request.Name;

            await _context.SaveChangesAsync();
        }
    }
}
