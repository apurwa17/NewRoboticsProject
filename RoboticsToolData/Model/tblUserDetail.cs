//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RoboticsToolData.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblUserDetail
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public Nullable<int> EmpID { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string PasswordSalt { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string PasswordHash { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    }
}