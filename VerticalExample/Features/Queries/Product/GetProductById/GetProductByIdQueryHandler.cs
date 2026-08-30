using MediatR;
using Microsoft.EntityFrameworkCore;
using VerticatExample.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using A = VerticalExample.Models;

namespace VerticalExample.Features.Queries.Product.GetProductById
{
    public class GetProductByIdQueryHandler:IRequestHandler<GetProductByIdQuery,GetProductByIdResponse>
    {
        private readonly IAppDbContext _context;

        public GetProductByIdQueryHandler(IAppDbContext context)
        {
            _context = context;
        }

        public async Task<GetProductByIdResponse> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            A.Product product = await _context.Products.FirstOrDefaultAsync(p => p.Id == request.Id);
            if (product is null) throw new Exception();
            return new(product.Id, product.Name, product.SKU, product.Price);
        }

        
    }
}