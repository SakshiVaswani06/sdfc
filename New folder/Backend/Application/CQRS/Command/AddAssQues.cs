using Application.DTO;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.CQRS.Command
{
    public class AddAssQues : IRequest<string>
    {
        public AssQuesDto? assQuesDto { get; set; }
    }
    public class AddHandler : IRequestHandler<AddAssQues, string>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;
        public AddHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<string> Handle(AddAssQues request, CancellationToken cancellationToken)
        {
            var existingAssessment = await _context.assessments
                .FirstOrDefaultAsync(a => a.AssessmentName == request.assQuesDto.AssessmentName);

            if (existingAssessment == null)
            {
                var newAssessment = _mapper.Map<Assessment>(request.assQuesDto);
                _context.assessments.Add(newAssessment);
                await _context.SaveChangesAsync();

                foreach (var quesDto in request.assQuesDto.quedto)
                {
                    var newQuestion = _mapper.Map<Questions>(quesDto);
                    newQuestion.AssessmentId = newAssessment.Id; 
                    _context.questions.Add(newQuestion);
                }
            }
            else
            {
                foreach (var quesDto in request.assQuesDto.quedto)
                {
                    var newQuestion = _mapper.Map<Questions>(quesDto);
                    newQuestion.AssessmentId = existingAssessment.Id; 
                    _context.questions.Add(newQuestion);
                }
            }
            await _context.SaveChangesAsync();

            return "Done";
        }
    }
}