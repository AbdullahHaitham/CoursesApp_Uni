//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoursesApp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student_Courses
    {
        public int Student_Id { get; set; }
        public int Course_id { get; set; }
        public System.DateTime Registration_Date { get; set; }
    
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}
