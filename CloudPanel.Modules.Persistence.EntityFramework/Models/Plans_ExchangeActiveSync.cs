using System;
using System.Collections.Generic;

namespace CloudPanel.Modules.Persistence.EntityFramework.Models
{
    public partial class Plans_ExchangeActiveSync
    {
        public int ASID { get; set; }
        public string CompanyCode { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public string ExchangeName { get; set; }
        public Nullable<bool> AllowNonProvisionableDevices { get; set; }
        public Nullable<int> RefreshIntervalInHours { get; set; }
        public Nullable<bool> RequirePassword { get; set; }
        public Nullable<bool> RequireAlphanumericPassword { get; set; }
        public Nullable<bool> EnablePasswordRecovery { get; set; }
        public Nullable<bool> RequireEncryptionOnDevice { get; set; }
        public Nullable<bool> RequireEncryptionOnStorageCard { get; set; }
        public Nullable<bool> AllowSimplePassword { get; set; }
        public Nullable<int> NumberOfFailedAttempted { get; set; }
        public Nullable<int> MinimumPasswordLength { get; set; }
        public Nullable<int> InactivityTimeoutInMinutes { get; set; }
        public Nullable<int> PasswordExpirationInDays { get; set; }
        public Nullable<int> EnforcePasswordHistory { get; set; }
        public string IncludePastCalendarItems { get; set; }
        public string IncludePastEmailItems { get; set; }
        public Nullable<int> LimitEmailSizeInKB { get; set; }
        public Nullable<bool> AllowDirectPushWhenRoaming { get; set; }
        public Nullable<bool> AllowHTMLEmail { get; set; }
        public Nullable<bool> AllowAttachmentsDownload { get; set; }
        public Nullable<int> MaximumAttachmentSizeInKB { get; set; }
        public Nullable<bool> AllowRemovableStorage { get; set; }
        public Nullable<bool> AllowCamera { get; set; }
        public Nullable<bool> AllowWiFi { get; set; }
        public Nullable<bool> AllowInfrared { get; set; }
        public Nullable<bool> AllowInternetSharing { get; set; }
        public Nullable<bool> AllowRemoteDesktop { get; set; }
        public Nullable<bool> AllowDesktopSync { get; set; }
        public string AllowBluetooth { get; set; }
        public Nullable<bool> AllowBrowser { get; set; }
        public Nullable<bool> AllowConsumerMail { get; set; }
        public Nullable<bool> IsEnterpriseCAL { get; set; }
        public Nullable<bool> AllowTextMessaging { get; set; }
        public Nullable<bool> AllowUnsignedApplications { get; set; }
        public Nullable<bool> AllowUnsignedInstallationPackages { get; set; }
    }
}
