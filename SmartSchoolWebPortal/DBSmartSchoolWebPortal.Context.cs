﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmartSchoolWebPortal
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBSmartSchoolWebPortalEntities111 : DbContext
    {
        public DBSmartSchoolWebPortalEntities111()
            : base("name=DBSmartSchoolWebPortalEntities111")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<ClassAttendance> ClassAttendances { get; set; }
        public virtual DbSet<ClassTimeTable> ClassTimeTables { get; set; }
        public virtual DbSet<Complaint> Complaints { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Enrollment> Enrollments { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<ExamResult> ExamResults { get; set; }
        public virtual DbSet<HostelRequest> HostelRequests { get; set; }
        public virtual DbSet<Hostel> Hostels { get; set; }
        public virtual DbSet<Management> Managements { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Parent> Parents { get; set; }
        public virtual DbSet<RegisteredCourse> RegisteredCourses { get; set; }
        public virtual DbSet<RegisteredHostel> RegisteredHostels { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentAttendance> StudentAttendances { get; set; }
        public virtual DbSet<StudentFee> StudentFees { get; set; }
        public virtual DbSet<LeavesRequest> LeavesRequests { get; set; }
        public virtual DbSet<vw_Courses> vw_Courses { get; set; }
        public virtual DbSet<vw_Events> vw_Events { get; set; }
        public virtual DbSet<vw_hostels> vw_hostels { get; set; }
        public virtual DbSet<vw_News> vw_News { get; set; }
        public virtual DbSet<vw_RegisteredParents> vw_RegisteredParents { get; set; }
        public virtual DbSet<vw_RegisteredStudents> vw_RegisteredStudents { get; set; }
    }
}
