﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloudPanel.Modules.Base.Plans
{
    public class MailboxPlanObject
    {
        public int MailboxPlanID { get; set; }

        public int MailboxSizeInMB { get; set; }

        public int MaxMailboxSizeInMB { get; set; }

        public int MaxSendInKB { get; set; }

        public int MaxReceiveInKB { get; set; }

        public int MaxRecipients { get; set; }

        public int MaxKeepDeletedItemsInDays { get; set; }

        public bool EnablePOP3 { get; set; }

        public bool EnableIMAP { get; set; }

        public bool EnableOWA { get; set; }

        public bool EnableMAPI { get; set; }

        public bool EnableAS { get; set; }

        public bool EnableECP { get; set; }

        public string MailboxPlanName { get; set; }

        public string MailboxPlanDescription { get; set; }

        public string Cost { get; set; }

        public string Price { get; set; }

        public string AdditionalGBPrice { get; set; }

        public string ResellerCode { get; set; }

        public string CompanyCode { get; set; }

    }
}
