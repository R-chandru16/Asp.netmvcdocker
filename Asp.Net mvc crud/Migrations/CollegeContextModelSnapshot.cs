﻿// <auto-generated />
using Asp.net_student.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Asp.net_student.Migrations
{
    [DbContext(typeof(CollegeContext))]
    partial class CollegeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Asp.net_student.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 101,
                            Name = "Doctor"
                        },
                        new
                        {
                            Id = 102,
                            Name = "Engineer"
                        },
                        new
                        {
                            Id = 103,
                            Name = "Lawyer"
                        },
                        new
                        {
                            Id = 104,
                            Name = "Business Admin"
                        },
                        new
                        {
                            Id = 105,
                            Name = "Economics"
                        },
                        new
                        {
                            Id = 106,
                            Name = "Physical Therapy"
                        },
                        new
                        {
                            Id = 107,
                            Name = "Statistics"
                        },
                        new
                        {
                            Id = 108,
                            Name = "Journalism"
                        },
                        new
                        {
                            Id = 109,
                            Name = "Artist"
                        },
                        new
                        {
                            Id = 110,
                            Name = "Actor"
                        });
                });

            modelBuilder.Entity("Asp.net_student.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnrollmentDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Phone")
                        .HasColumnType("float");

                    b.Property<string>("country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 21,
                            DepartmentId = 101,
                            Email = "aaa@gmail.com",
                            EnrollmentDate = "2022-01-01",
                            Gender = "Male",
                            Name = "Tim",
                            Phone = 9876543212.0,
                            country = "india",
                            password = "aaa"
                        },
                        new
                        {
                            Id = 2,
                            Age = 22,
                            DepartmentId = 101,
                            Email = "bbb@gmail.com",
                            EnrollmentDate = "2022-01-02",
                            Gender = "Female",
                            Name = "jim",
                            Phone = 9876543219.0,
                            country = "india",
                            password = "password"
                        });
                });

            modelBuilder.Entity("Asp.net_student.Models.Users", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Email");

                    b.ToTable("users");

                    b.HasData(
                        new
                        {
                            Email = "demo@gmail.com",
                            Name = "demo",
                            Password = "demo"
                        });
                });

            modelBuilder.Entity("Asp.net_student.Models.Student", b =>
                {
                    b.HasOne("Asp.net_student.Models.Department", "Department")
                        .WithMany("Students")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Asp.net_student.Models.Department", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
