using Asp.net_student.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.net_student.Services
{

        public interface LoginRepo<k>
        {
        bool Validate(k K);
      
        k Add(k k);
    }
    }
