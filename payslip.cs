//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutomatedSalaryProcessingSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class payslip
    {
        public int id { get; set; }
        public int employeeID { get; set; }
        public Nullable<int> salaryid { get; set; }
    
        public virtual employee employee { get; set; }
        public virtual Salary Salary { get; set; }
    }
}