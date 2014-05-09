using System;
using System.Collections.Generic;

namespace CloudPanel.Modules.Persistence.EntityFramework.Models
{
    public partial class Setting
    {
        public string BaseOU { get; set; }
        public string PrimaryDC { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string SuperAdmins { get; set; }
        public string BillingAdmins { get; set; }
        public string ExchangeFqdn { get; set; }
        public string ExchangePFServer { get; set; }
        public int ExchangeVersion { get; set; }
        public bool ExchangeSSLEnabled { get; set; }
        public string ExchangeConnectionType { get; set; }
        public int PasswordMinLength { get; set; }
        public int PasswordComplexityType { get; set; }
        public bool CitrixEnabled { get; set; }
        public bool PublicFolderEnabled { get; set; }
        public bool LyncEnabled { get; set; }
        public bool WebsiteEnabled { get; set; }
        public bool SQLEnabled { get; set; }
        public string CurrencySymbol { get; set; }
        public string CurrencyEnglishName { get; set; }
        public Nullable<bool> ResellersEnabled { get; set; }
        public string CompanysName { get; set; }
        public Nullable<bool> AllowCustomNameAttrib { get; set; }
        public Nullable<bool> ExchStats { get; set; }
        public Nullable<bool> IPBlockingEnabled { get; set; }
        public Nullable<int> IPBlockingFailedCount { get; set; }
        public Nullable<int> IPBlockingLockedMinutes { get; set; }
        public string ExchDatabases { get; set; }
        public string UsersOU { get; set; }
        public string BrandingLoginLogo { get; set; }
        public string BrandingCornerLogo { get; set; }
        public Nullable<bool> LockdownEnabled { get; set; }
        public string LyncFrontEnd { get; set; }
        public string LyncUserPool { get; set; }
        public string LyncMeetingUrl { get; set; }
        public string LyncDialinUrl { get; set; }
        public string CompanysLogo { get; set; }
        public Nullable<bool> SupportMailEnabled { get; set; }
        public string SupportMailAddress { get; set; }
        public string SupportMailServer { get; set; }
        public Nullable<int> SupportMailPort { get; set; }
        public string SupportMailUsername { get; set; }
        public string SupportMailPassword { get; set; }
        public string SupportMailFrom { get; set; }
        public int ID { get; set; }
    }
}