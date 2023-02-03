﻿// <auto-generated />
using System;
using DJ_WebDesignCore.DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DJWebDesignCore.Migrations
{
    [DbContext(typeof(LAContext))]
    partial class LAContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DJ_WebDesignCore.Entites.Business.Holiday", b =>
                {
                    b.Property<int>("HolidayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HolidayId"));

                    b.Property<DateTime?>("CloseTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DateDiff")
                        .HasColumnType("int");

                    b.Property<int?>("EmployeeComfirmId")
                        .HasColumnType("int");

                    b.Property<string>("HolidayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("OpenTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("StudentLAId")
                        .HasColumnType("int");

                    b.HasKey("HolidayId");

                    b.HasIndex("EmployeeComfirmId");

                    b.HasIndex("StudentLAId");

                    b.ToTable("holidays");
                });

            modelBuilder.Entity("DJ_WebDesignCore.Entites.Business.Reserve", b =>
                {
                    b.Property<int>("ReserveId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReserveId"));

                    b.Property<DateTime?>("CloseTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DateDiff")
                        .HasColumnType("int");

                    b.Property<int?>("EmployeeComfirmId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("OpenTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReserveReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StudentLAId")
                        .HasColumnType("int");

                    b.HasKey("ReserveId");

                    b.HasIndex("EmployeeComfirmId");

                    b.HasIndex("StudentLAId");

                    b.ToTable("reserves");
                });

            modelBuilder.Entity("DJ_WebDesignCore.Entites.Business.UnauthorizedAbsences", b =>
                {
                    b.Property<int>("UnauthorizedAbsencesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UnauthorizedAbsencesId"));

                    b.Property<int?>("EmployeeComfirmId")
                        .HasColumnType("int");

                    b.Property<int?>("StudentLAId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UnauthorizedAbsencesDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UnauthorizedAbsencesName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UnauthorizedAbsencesId");

                    b.HasIndex("EmployeeComfirmId");

                    b.HasIndex("StudentLAId");

                    b.ToTable("unauthorizedAbsences");
                });

            modelBuilder.Entity("DJ_WebDesignCore.Entites.Courses.CourseLA", b =>
                {
                    b.Property<int>("CourseLAId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseLAId"));

                    b.Property<string>("CourseLACode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseLAName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("CourseLAPrice")
                        .HasColumnType("float");

                    b.HasKey("CourseLAId");

                    b.ToTable("courses");
                });

            modelBuilder.Entity("DJ_WebDesignCore.Entites.Employee.EmployeeLA", b =>
                {
                    b.Property<int>("EmployeeLAId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeLAId"));

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EmployeeLABirthDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmployeeLAName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EmployeeRoleId")
                        .HasColumnType("int");

                    b.Property<int?>("EmployeeStatusId")
                        .HasColumnType("int");

                    b.Property<string>("FacebookUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GenderId")
                        .HasColumnType("int");

                    b.Property<string>("NumberPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkyUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeLAId");

                    b.HasIndex("AddressId");

                    b.HasIndex("EmployeeRoleId");

                    b.HasIndex("EmployeeStatusId");

                    b.ToTable("employeeLA");
                });

            modelBuilder.Entity("DJ_WebDesignCore.Entites.Employee.EmployeeRole", b =>
                {
                    b.Property<int>("EmployeeRoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeRoleId"));

                    b.Property<string>("EmployeeRoleCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeRoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeRoleId");

                    b.ToTable("employeeRoles");
                });

            modelBuilder.Entity("DJ_WebDesignCore.Entites.Employee.StudentCourse", b =>
                {
                    b.Property<int>("StudentCourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentCourseId"));

                    b.Property<DateTime?>("CloseCourse")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CourseLAId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("OpenCourse")
                        .HasColumnType("datetime2");

                    b.Property<int?>("StudentLAId")
                        .HasColumnType("int");

                    b.HasKey("StudentCourseId");

                    b.HasIndex("CourseLAId");

                    b.HasIndex("StudentLAId");

                    b.ToTable("studentCourses");
                });

            modelBuilder.Entity("DJ_WebDesignCore.Entites.Properties.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddressId"));

                    b.Property<int>("CommuneId")
                        .HasColumnType("int");

                    b.Property<int>("DistrictId")
                        .HasColumnType("int");

                    b.Property<int>("ProvinceId")
                        .HasColumnType("int");

                    b.HasKey("AddressId");

                    b.ToTable("address");
                });

            modelBuilder.Entity("DJ_WebDesignCore.Entites.Properties.CourseStatus", b =>
                {
                    b.Property<int>("CourseStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseStatusId"));

                    b.Property<string>("CourseStatusCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseStatusName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseStatusId");

                    b.ToTable("courseStatuses");
                });

            modelBuilder.Entity("DJ_WebDesignCore.Entites.Properties.EmployeeStatus", b =>
                {
                    b.Property<int>("EmployeeStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeStatusId"));

                    b.Property<string>("EmployeeStatusCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeStatusName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeStatusId");

                    b.ToTable("employeeStatuses");
                });

            modelBuilder.Entity("DJ_WebDesignCore.Entites.Properties.Gender", b =>
                {
                    b.Property<int>("GenderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenderId"));

                    b.Property<string>("GenderCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GenderName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenderId");

                    b.ToTable("genders");
                });

            modelBuilder.Entity("DJ_WebDesignCore.Entites.Properties.StudentStatus", b =>
                {
                    b.Property<int>("StudentStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentStatusId"));

                    b.Property<string>("StudentStatusCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentStatusName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentStatusId");

                    b.ToTable("studentStatuses");
                });

            modelBuilder.Entity("DJ_WebDesignCore.Entites.Student.StudentLA", b =>
                {
                    b.Property<int>("StudentLAId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentLAId"));

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<int?>("GenderId")
                        .HasColumnType("int");

                    b.Property<int?>("SaleId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("StudentLABirthDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("StudentLAName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StudentStatusId")
                        .HasColumnType("int");

                    b.HasKey("StudentLAId");

                    b.HasIndex("AddressId");

                    b.HasIndex("GenderId");

                    b.HasIndex("SaleId");

                    b.HasIndex("StudentStatusId");

                    b.ToTable("students");
                });

            modelBuilder.Entity("DJ_WebDesignCore.Entites.Business.Holiday", b =>
                {
                    b.HasOne("DJ_WebDesignCore.Entites.Employee.EmployeeLA", "EmployeeComfirm")
                        .WithMany()
                        .HasForeignKey("EmployeeComfirmId");

                    b.HasOne("DJ_WebDesignCore.Entites.Student.StudentLA", "StudentLA")
                        .WithMany()
                        .HasForeignKey("StudentLAId");

                    b.Navigation("EmployeeComfirm");

                    b.Navigation("StudentLA");
                });

            modelBuilder.Entity("DJ_WebDesignCore.Entites.Business.Reserve", b =>
                {
                    b.HasOne("DJ_WebDesignCore.Entites.Employee.EmployeeLA", "EmployeeComfirm")
                        .WithMany()
                        .HasForeignKey("EmployeeComfirmId");

                    b.HasOne("DJ_WebDesignCore.Entites.Student.StudentLA", "StudentLA")
                        .WithMany()
                        .HasForeignKey("StudentLAId");

                    b.Navigation("EmployeeComfirm");

                    b.Navigation("StudentLA");
                });

            modelBuilder.Entity("DJ_WebDesignCore.Entites.Business.UnauthorizedAbsences", b =>
                {
                    b.HasOne("DJ_WebDesignCore.Entites.Employee.EmployeeLA", "EmployeeComfirm")
                        .WithMany()
                        .HasForeignKey("EmployeeComfirmId");

                    b.HasOne("DJ_WebDesignCore.Entites.Student.StudentLA", "StudentLA")
                        .WithMany()
                        .HasForeignKey("StudentLAId");

                    b.Navigation("EmployeeComfirm");

                    b.Navigation("StudentLA");
                });

            modelBuilder.Entity("DJ_WebDesignCore.Entites.Employee.EmployeeLA", b =>
                {
                    b.HasOne("DJ_WebDesignCore.Entites.Properties.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.HasOne("DJ_WebDesignCore.Entites.Employee.EmployeeRole", "EmployeeRole")
                        .WithMany()
                        .HasForeignKey("EmployeeRoleId");

                    b.HasOne("DJ_WebDesignCore.Entites.Properties.Gender", "Gender")
                        .WithMany()
                        .HasForeignKey("EmployeeRoleId");

                    b.HasOne("DJ_WebDesignCore.Entites.Properties.EmployeeStatus", "EmployeeStatus")
                        .WithMany()
                        .HasForeignKey("EmployeeStatusId");

                    b.Navigation("Address");

                    b.Navigation("EmployeeRole");

                    b.Navigation("EmployeeStatus");

                    b.Navigation("Gender");
                });

            modelBuilder.Entity("DJ_WebDesignCore.Entites.Employee.StudentCourse", b =>
                {
                    b.HasOne("DJ_WebDesignCore.Entites.Courses.CourseLA", "CourseLA")
                        .WithMany()
                        .HasForeignKey("CourseLAId");

                    b.HasOne("DJ_WebDesignCore.Entites.Student.StudentLA", "StudentLA")
                        .WithMany()
                        .HasForeignKey("StudentLAId");

                    b.Navigation("CourseLA");

                    b.Navigation("StudentLA");
                });

            modelBuilder.Entity("DJ_WebDesignCore.Entites.Student.StudentLA", b =>
                {
                    b.HasOne("DJ_WebDesignCore.Entites.Properties.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.HasOne("DJ_WebDesignCore.Entites.Properties.Gender", "Gender")
                        .WithMany()
                        .HasForeignKey("GenderId");

                    b.HasOne("DJ_WebDesignCore.Entites.Employee.EmployeeLA", "Sale")
                        .WithMany()
                        .HasForeignKey("SaleId");

                    b.HasOne("DJ_WebDesignCore.Entites.Properties.StudentStatus", "StudentStatus")
                        .WithMany()
                        .HasForeignKey("StudentStatusId");

                    b.Navigation("Address");

                    b.Navigation("Gender");

                    b.Navigation("Sale");

                    b.Navigation("StudentStatus");
                });
#pragma warning restore 612, 618
        }
    }
}
