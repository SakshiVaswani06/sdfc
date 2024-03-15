using Application.DTO;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CQRS.Command
{
    public class EditQuestions : IRequest<string>
    {
        public int Id { get; set; }
        public int AssessmentId { get; set; }
        public QuesDto? quedto { get; set; }
    }
    public class UpdateHandler : IRequestHandler<EditQuestions, string>
    {
        private readonly IApplicationDbContext _context;
        public UpdateHandler(IApplicationDbContext context)
        {
            _context = context; 
        }
        public async Task<string> Handle(EditQuestions request, CancellationToken cancellationToken)
        {
            var details = await _context.questions.FindAsync(request.Id);
            
            if (details != null)
            {
                details.Question = request.quedto?.Question;
                details.QuestionType = request.quedto?.QuestionType;
                details.AssessmentId = request.AssessmentId;

                await _context.SaveChangesAsync();
                return "Questions Updated";
            }
            else
            {
                return "Update Failed...Please try again!!";
            }

        }
    }
}
