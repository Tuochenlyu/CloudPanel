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
    
    public partial class Plans_Organization
    {
        public int OrgPlanID { get; set; }
        public string OrgPlanName { get; set; }
        public int ProductID { get; set; }
        public string ResellerCode { get; set; }
        public int MaxUsers { get; set; }
        public int MaxDomains { get; set; }
        public int MaxExchangeMailboxes { get; set; }
        public int MaxExchangeContacts { get; set; }
        public int MaxExchangeDistLists { get; set; }
        public int MaxExchangePublicFolders { get; set; }
        public int MaxExchangeMailPublicFolders { get; set; }
        public int MaxExchangeKeepDeletedItems { get; set; }
        public Nullable<int> MaxExchangeActivesyncPolicies { get; set; }
        public int MaxTerminalServerUsers { get; set; }
        public Nullable<int> MaxExchangeResourceMailboxes { get; set; }
    }
}
