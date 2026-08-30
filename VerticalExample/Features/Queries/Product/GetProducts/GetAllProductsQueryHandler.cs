using MediatR;
using Microsoft.EntityFrameworkCore;
using VerticatExample.Data;

namespace VerticalExample.Features.Queries.Product.GetProducts
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, GetAllProductsResponse>
    {
        private readonly IAppDbContext _context;

        public GetAllProductsQueryHandler(IAppDbContext context)
        {
            _context = context;
        }
        public async Task<GetAllProductsResponse> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            int skipSize = (request.page-1)* request.pageSize;
            int totalCount = await _context.Products.CountAsync();
            if (skipSize>=totalCount)
            {
                throw new Exception("BAdRequest");
            }
            
            var products = await _context.Products
                .Skip(skipSize)
                .Take(request.pageSize)
                .Select(p => new GetProductItemResponse(p.Id, p.Name, p.Price))
                .ToListAsync();
            GetAllProductsResponse response = new(totalCount, products);
            return response;
        }
    }
}
