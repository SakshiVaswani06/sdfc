using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO
{
    public class AssQuesDto
    {
        public string? AssessmentName { get; set; }
        public IList<QuesDto>? quedto { get; set; }
    }
}
