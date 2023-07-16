using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Core.Courses.Commands
{
    public record CreateCourseCommand(CreateCourseDto input):IRequest<int>;
    public class CreateCourseHandler : IRequestHandler<CreateCourseCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;
       // IMapper _mapper;

        public CreateCourseHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;           
        }

        public async Task<int> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
        {
            var course = new Course
            {
                CourseName = request.input.CourseName,
                Price = request.input.Price
            };

            _unitOfWork.Courses.Add(course);
            await _unitOfWork.Complete(cancellationToken);

            return course.Id;

        }
    }
}
