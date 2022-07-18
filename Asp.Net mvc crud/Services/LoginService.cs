using Asp.net_student.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.net_student.Services
{

    public class LoginService: LoginRepo<Users>
    {
        private readonly CollegeContext _loginContext;
       

        public LoginService(CollegeContext loginContext)
        {
            _loginContext = loginContext;
        }

        public Users Add(Users k)
        {
            //_loginContext.users.Add(k);
            //_loginContext.SaveChanges();
            //return k;
            try
            {
                _loginContext.users.Add(k);
                _loginContext.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ducex)
            {
                Console.WriteLine(ducex.Message);
            }
            catch (DbUpdateException dbuex)
            {
                Console.WriteLine(dbuex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public bool Validate(Users users)
        {
            Users user = null;
            if (_loginContext.users.Where(e => e.Name== users.Name && e.Password==users.Password).Any())
            {
                user = _loginContext.users.FirstOrDefault(e => e.Name== users.Name && e.Password == users.Password);
                return true;
            }
            //if (_loginContext.users.Where(e => e.Email == users.Email &&
            //e.Password == users.Password).Any())
            //    return true;
            else
                return false;
        }
    }
}
