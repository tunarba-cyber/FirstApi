using MediatR;
using Microsoft.EntityFrameworkCore;
using VerticatExample.Data;
using A = VerticalExample.Models;

namespace VerticalExample.Features.Queries.Category.GetCategoryById
{
    public class GetCategoryByIdQueryHandler:IRequestHandler<GetCategoryByIdQuery,GetCategoryByIdResponse?>
    {
        private readonly IAppDbContext _context;

        public GetCategoryByIdQueryHandler(IAppDbContext context)
        {
            _context = context;
        }

        public async Task<GetCategoryByIdResponse?> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            A.Category? category = await _context.Categories.FirstOrDefaultAsync(c => c.Id == request.Id);
            if (category is null) return null;
            return new(category.Id, category.Name);
        }
    }
}
