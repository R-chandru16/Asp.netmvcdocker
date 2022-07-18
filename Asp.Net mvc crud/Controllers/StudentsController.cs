
using Asp.net_student.Models;
using Asp.net_student.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using System.Web.Mvc;
using System.Collections;


namespace Asp.net_student.Controllers
{

    public class StudentsController : BaseController<Student>
    {
        private readonly IRepo<Student> _repo;
        private readonly LoginRepo<Users> _loginRepo;
        private readonly IDepartmentRepo<Department>_departmentService;


        // private CollegeContext db = new CollegeContext();


        public StudentsController(IRepo<Student> repo, LoginRepo<Users> loginRepo, IDepartmentRepo<Department> departmentService)
        {

            _repo = repo;
            _loginRepo = loginRepo;
            _departmentService = departmentService;

        }
        public IActionResult Index(string search = null, int page = 1)
        {
            if (!string.IsNullOrEmpty(search))
            {
                var foundStudents = _repo.SearchStudents(search);
                return View(foundStudents);
            }


            var Students = _repo.GetAllStudents();

            var paginatedResult = PaginatedResult(Students, page, 5);

            return View(paginatedResult);

            //IEnumerable<Student> obj = (_repo.GetAll());
            //return View(obj); 
        }



        public IActionResult Details(int id)
        {
            
            return View(_repo.Get(id));
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student employee)
        {
            if (_departmentService.checkdepartment(employee.DepartmentId))
            {
                TempData["Name"] = employee.Name;
                TempData.Keep("Name");
                TempData["Email"] = employee.Email;
                TempData.Keep("Email");
                Users user = new Users()
                {
                    Email = employee.Email,
                    Password = employee.password,
                    Name = employee.Name,

                };

                _repo.Add(employee);
                _loginRepo.Add(user);
                TempData["AlertMessage"] = "Record created successfully";
                TempData["nochange"] = "no change happen";
                return RedirectToAction("Index");

            }
            else
            {
                TempData["Alertdepartment"] = "Entered Departmentid not exist";
                return RedirectToAction("create");
            }
        }
       
            public IActionResult Edit(int id)
        {
            return View(_repo.Get(id));
        }
        [HttpPost]
        public IActionResult Edit(int id, Student employee)
        {
            if (_departmentService.checkdepartment(employee.DepartmentId))
            {

                _repo.Update(employee);
                TempData["AlertMessage"] = "Record Edited successfully";
                return RedirectToAction("Index");

            }

            //else if (_repo!=null) {
            //    TempData["Alertmsg"] = "please edit it";


            //}
            else
            {
                TempData["Alertdepartment"] = "Entered Departmentid not exist";
                return RedirectToAction("edit");
            }

            

            
        }




        //public IActionResult Delete(int id)
        //{
        //    _repo.Delete(id);
        //    return RedirectToAction("Index","Students");
        //}
        public IActionResult Delete(int id)
        {
            Student st = _repo.Get(id);
            return View(st);

        }
        public IActionResult Deletestur(int id)
        {
            _repo.Delete(id);
            TempData["AlertMessage"] = "Record deleted successfully";
            return RedirectToAction("Index", "Students");
        }


    }
    }


   


 
    



