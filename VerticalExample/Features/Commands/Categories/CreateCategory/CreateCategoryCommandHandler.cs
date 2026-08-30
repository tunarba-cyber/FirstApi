using MediatR;
using Microsoft.EntityFrameworkCore;
using VerticalExample.Models;
using VerticatExample.Data;

namespace VerticalExample.Features.Commands.Categories.CreateCategory
{
    public class CreateCategoryCommandHandler:IRequestHandler<CreateCategoryCommand>
    {
        private readonly IAppDbContext _context;

        public CreateCategoryCommandHandler(IAppDbContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            bool result = await _context.Categories.AnyAsync(c => c.Name == request.Name);
            if (result == true) throw new Exception("Already exists");
            _context.Categories.Add(new()
            {
                Name = request.Name
            });
            await _context.SaveChangesAsync();
        }
    }
}
