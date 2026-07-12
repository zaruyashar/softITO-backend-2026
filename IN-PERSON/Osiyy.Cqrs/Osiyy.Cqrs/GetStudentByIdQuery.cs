using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Osiyy.Cqrs
{
    public class GetStudentByIdQuery
    {
        public int Id { get; set; }
        public GetStudentByIdQuery(int id)
        {
            Id = id;

        }
    }
}
