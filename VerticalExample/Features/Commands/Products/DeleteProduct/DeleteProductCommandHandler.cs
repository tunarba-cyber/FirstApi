using MediatR;
using Microsoft.EntityFrameworkCore;
using VerticalExample.Models;
using VerticatExample.Data;

namespace VerticalExample.Features.Commands.Products.DeleteProduct
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand>
    {
        private readonly IAppDbContext _context;

        public DeleteProductCommandHandler(IAppDbContext context)
        {
            _context = context;
        }
        public async Task Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            Product? existed = await _context.Products.FirstOrDefaultAsync(p => p.Id == request.Id);
            if (existed is null) throw new Exception("Not found");
            _context.Products.Remove(existed);
            await _context.SaveChangesAsync();
        }
    }
}
