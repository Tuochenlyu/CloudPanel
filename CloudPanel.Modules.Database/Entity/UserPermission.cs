//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CloudPanel.Modules.Database.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserPermission
    {
        public int UserID { get; set; }
        public bool EnableExchange { get; set; }
        public bool DisableExchange { get; set; }
        public bool AddDomain { get; set; }
        public bool DeleteDomain { get; set; }
        public bool ModifyAcceptedDomain { get; set; }
        public bool ImportUsers { get; set; }
    }
}