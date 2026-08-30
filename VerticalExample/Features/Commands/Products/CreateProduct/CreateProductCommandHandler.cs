using MediatR;
using Microsoft.EntityFrameworkCore;
using VerticalExample.Models;
using VerticatExample.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace VerticalExample.Features.Commands.Products.CreateProduct
{
    public class CreateProductCommandHandler:IRequestHandler<CreateProductCommand>
    {
        private readonly IAppDbContext _context;

        public CreateProductCommandHandler(IAppDbContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            bool result = await _context.Products.AnyAsync(p => p.Name == request.Name);
            if (result == true) throw new Exception("Already exists");
            _context.Products.Add(new()
            {
                Name = request.Name,
                SKU = request.SKU,
                Price = request.Price
            });
            await _context.SaveChangesAsync();
        }

        
    }
}
