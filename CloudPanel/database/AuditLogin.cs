//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CloudPanel.database
{
    using System;
    using System.Collections.Generic;
    
    public partial class AuditLogin
    {
        public int ID { get; set; }
        public string IPAddress { get; set; }
        public string Username { get; set; }
        public bool LoginStatus { get; set; }
        public System.DateTime AuditTimeStamp { get; set; }
    }
}
