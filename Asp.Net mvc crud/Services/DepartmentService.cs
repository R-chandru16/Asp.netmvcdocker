using Asp.net_student.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.net_student.Services
{
    public class DepartmentService : IDepartmentRepo<Department>
    {

        private readonly CollegeContext _context;


        public DepartmentService(CollegeContext context)
        {
            _context = context;
        }

        public bool checkdepartment(int id)
        {
            var result = _context.Departments.FirstOrDefault(e => e.Id == id);
            if (result != null)
            {
                return true;

            }
            else
            {
                return false;
            }
        }




    }
}
