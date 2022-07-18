using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.net_student.Controllers
{
    public class BaseController<T> : Controller where T : class
    {

        public List<T> PaginatedResult(List<T> t, int page, int rowsPerPage)
        {
            @ViewBag.TotalRecords = t.Count;
            @ViewBag.CurrentPage = page;
            var skip = (page - 1) * rowsPerPage;
            var paginatedResult = t.Skip(skip).Take(rowsPerPage).ToList();
            return paginatedResult;
        }

    }
    //public class AgeAttribute : ValidationAttribute
    //{
    //    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    //    {
    //        if (value != null)
    //        {
    //            int age = Convert.ToInt32(value);
    //            if (age < 18)
    //            {
    //                return new ValidationResult("Age should not less than 18");
    //            }
    //        }
    //        return ValidationResult.Success;
    //    }
    //}
}