using Osiyy.Cqrs.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Osiyy.Cqrs
{
    public class GetStudentByIdQueryHandler
    {
        private readonly StudentContext _context;
        public GetStudentByIdQueryHandler(StudentContext context)
        {
            _context = context;

        }

        public GetStudentByIdQueryResult Handle(GetStudentByIdQuery query)
        {
            var student = _context.Set<Student>().Find(query.Id);
            return new GetStudentByIdQueryResult
            {
                Age=student.Age,
                Name=student.Name,
                Surname=student.Surname
            };
        }

    }
}
