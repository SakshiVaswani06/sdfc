using Application.DTO;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.CQRS.Queries
{
    public class GetData : IRequest<List<AssDto>> { }

    public class GetHandler : IRequestHandler<GetData, List<AssDto>>
    {
        private readonly IApplicationDbContext _context;     

        public GetHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<AssDto>> Handle(GetData request, CancellationToken cancellationToken)
        {
            var assessments = await _context.assessments
                .Select(a => new AssDto
                {
                    Id = a.Id,
                    AssessmentName = a.AssessmentName
                })
                .ToListAsync();

            return assessments;
        }
    }
} 