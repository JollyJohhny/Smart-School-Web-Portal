//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class StudentAttendance
    {
        public int Id { get; set; }
        public Nullable<int> ClassAttendanceId { get; set; }
        public Nullable<int> StudentId { get; set; }
        public Nullable<int> Status { get; set; }
    
        public virtual ClassAttendance ClassAttendance { get; set; }
        public virtual Student Student { get; set; }
    }
}
