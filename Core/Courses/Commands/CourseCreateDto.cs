using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Courses.Commands
{
    public class CreateCourseDto
    {
        public int Id { get; set; }

        public string CourseName { get; set; }

        public decimal Price { get; set; }
    }
}
