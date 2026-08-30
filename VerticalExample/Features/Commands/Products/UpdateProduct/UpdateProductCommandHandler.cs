using Azure.Core;
using MediatR;
using Microsoft.EntityFrameworkCore;
using VerticalExample.Models;
using VerticatExample.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace VerticalExample.Features.Commands.Products.UpdateProduct
{
    public class UpdateProductCommandHandler:IRequestHandler<UpdateProductCommand>
    {
        private readonly IAppDbContext _context;

        public UpdateProductCommandHandler(IAppDbContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            bool result = await _context.Products.AnyAsync(p => p.Name == request.Name && p.Id != request.Id);
            if (result is true)
            {
                throw new Exception("Already exists");
            }
            Product? existed = await _context.Products.FirstOrDefaultAsync(p => p.Id == request.Id);
            if (existed is null) throw new Exception("Not found");

            existed.Name = request.Name;
            existed.SKU = request.SKU;
            existed.Price = request.Price;

            await _context.SaveChangesAsync();
        }

        
    }
}
