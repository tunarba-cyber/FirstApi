using MediatR;
using Microsoft.EntityFrameworkCore;
using VerticatExample.Data;

namespace VerticalExample.Features.Queries.Category.GetCategories
{
    public class GetAllCategoriesQueryHandler : IRequestHandler<GetAllCategoriesQuery, GetAllCategoriesResponse>
    {
        private readonly IAppDbContext _context;

        public GetAllCategoriesQueryHandler(IAppDbContext context)
        {
            _context = context;
        }
        public async Task<GetAllCategoriesResponse> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
        {
            int skipSize = (request.page-1)* request.pageSize;
            int totalCount = await _context.Categories.CountAsync();

            var categories = await _context.Categories
                .Skip(skipSize)
                .Take(request.pageSize)
                .Select(c => new GetCategoryItemResponse(c.Id, c.Name))
                .ToListAsync();
            GetAllCategoriesResponse response = new(totalCount, categories);
            return response;
        }
    }
}
