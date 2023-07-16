using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositries
{
    public interface ICourseRepository : IRepository<Course>
    {
        Task<IEnumerable<Course>> GetTopSellingCourse(int count);
        Task<IEnumerable<Course>> GetCoursesWithAuthors(int pageIndex, int pageSize);
    }
}
