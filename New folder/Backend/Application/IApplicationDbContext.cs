using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public interface IApplicationDbContext
    {
        DbSet<Assessment> assessments { get; }
        DbSet<Questions> questions { get; }
        Task SaveChangesAsync();

    }
}
