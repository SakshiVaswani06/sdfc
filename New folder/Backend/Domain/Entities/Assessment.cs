﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Assessment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? AssessmentName { get; set; }
        public ICollection<Questions>? questions { get; set; }
    }
}
