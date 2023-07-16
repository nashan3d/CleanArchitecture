using Core;
using Core.Repositries;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CourseDbContext _context;
        public UnitOfWork(CourseDbContext context)
        {
            _context = context;
            Courses  = new CourseRepository(context);
        }

        public ICourseRepository Courses { get; private set; }

        public async Task<int> Complete(CancellationToken cancellationToken)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
