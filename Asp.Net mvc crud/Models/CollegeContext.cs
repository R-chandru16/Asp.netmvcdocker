using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.net_student.Models
{
    public class CollegeContext : DbContext
    {
        public CollegeContext()
        {
        }

        public CollegeContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Users> users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>().HasData(new Users()
            {
                Email = "demo@gmail.com",
                Name="demo",
                Password = "demo"
            });

            modelBuilder.Entity<Department>().HasData(new Department()
            {
                Id = 101,
                Name = "Doctor"
            });

            modelBuilder.Entity<Department>().HasData(new Department()
            {
                Id = 102,
                Name = "Engineer"
            });
            modelBuilder.Entity<Department>().HasData(new Department()
            {
                Id = 103,
                Name = "Lawyer"
            });
            modelBuilder.Entity<Department>().HasData(new Department()
            {
                Id = 104,
                Name = "Business Admin"
            });
            modelBuilder.Entity<Department>().HasData(new Department()
            {
                Id = 105,
                Name = "Economics"
            });
            modelBuilder.Entity<Department>().HasData(new Department()
            {
                Id = 106,
                Name = "Physical Therapy"
            });
            modelBuilder.Entity<Department>().HasData(new Department()
            {
                Id = 107,
                Name = "Statistics"
            });
            modelBuilder.Entity<Department>().HasData(new Department()
            {
                Id = 108,
                Name = "Journalism"
            });
            modelBuilder.Entity<Department>().HasData(new Department()
            {
                Id = 109,
                Name = "Artist"
            });
            modelBuilder.Entity<Department>().HasData(new Department()
            {
                Id = 110,
                Name = "Actor"
            });
          
            modelBuilder.Entity<Student>().HasData(new Student()
            {
                Id = 1,
                Name = "Tim",
                Age = 21,
                Gender="Male",
                Email="aaa@gmail.com",
                password="aaa",
                EnrollmentDate="2022-01-01",
                Phone=9876543212,
                country="india",
                DepartmentId = 101
            });
            modelBuilder.Entity<Student>().HasData(new Student()
            {
                Id = 2,
                Name = "jim",
                Age = 22,
                Gender = "Female",
                Email = "bbb@gmail.com",
                password="password",
                EnrollmentDate = "2022-01-02",
                Phone = 9876543219,
                country = "india",
                DepartmentId = 101


            });
            //  protected override void OnModelCreating(ModelBuilder modelBuilder)
            //{
            //    modelBuilder.Entity<Student>().ToTable("Students");
            //    modelBuilder.Entity<Department>().ToTable("Departments");

            //}
        }
    }
}


    


