using Core.Repositries;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        public CourseRepository(CourseDbContext context) : base (context){ }
       
        public async Task<IEnumerable<Course>> GetCoursesWithAuthors(int pageIndex, int pageSize)
        {
            return await CourseContext.Courses.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
        }

        public async Task<IEnumerable<Course>> GetTopSellingCourse(int count)
        {
            return await CourseContext.Courses.OrderByDescending(x => x.Price).Take(count).ToListAsync();
        }


        public CourseDbContext CourseContext
        {
            get { return Context as CourseDbContext; }
        }
    }
}
