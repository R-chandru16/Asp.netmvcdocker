using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.net_student.Services
{
    public interface IDepartmentRepo<k>
    {
        bool checkdepartment(int id);
    }
}
