//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CloudPanel.data
{
    using System;
    using System.Collections.Generic;
    
    public partial class ResourceMailbox
    {
        public int ResourceID { get; set; }
        public string DisplayName { get; set; }
        public string CompanyCode { get; set; }
        public string UserPrincipalName { get; set; }
        public string PrimarySmtpAddress { get; set; }
        public string ResourceType { get; set; }
        public int MailboxPlan { get; set; }
        public int AdditionalMB { get; set; }
    }
}
