﻿using DJ_WebDesignCore.Entites.Business;
using DJ_WebDesignCore.Enums.StudentActiveManagerEnums;

namespace DJ_WebDesignCore.DTOs.StudentManagerDTOs.StudentStatisticalDTOs
{
    public class StudentLADTO
    {
        public int? StudentLAId { get; set; }
        public string? StudentLAName { get; set; }
        public string? StudentLASdt { get; set; }
        public IEnumerable<StudentCourse>? StudentCourses { get; set; }
        public int? EmployeeLAId { get; set; }
        public string? EmployeeLAName { get; set; }
        public ActiveStatus? IsActive { get; set; }

    }
}
