using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Questions
    {
        public int Id {  get; set; }
        public string? Question {  get; set; }
        public string? QuestionType {  get; set; }
        public int AssessmentId { get; set; }
        public Assessment? assessments { get; set; }
    }
}
