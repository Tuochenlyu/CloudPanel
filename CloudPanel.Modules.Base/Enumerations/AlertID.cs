﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloudPanel.Modules.Base.Enumerations
{
    public enum AlertID
    {
        FAILED_CREATE_OU,
        FAILED_CREATE_GROUP,
        USER_UNKNOWN,
        LOGIN_FAILED,
        RETRIEVE_GROUPS_FAILED,
        BRUTE_FORCE_BLOCKED,
        FAILED_RETRIEVE_AUDITS,
        FAILED,
        WARNING,
        SUCCESS,
        SUCCESS_NEW_RESELLER,
        SUCCESS_NEW_COMPANY,
        SUCCESS_UPDATE_RESELLER,
        SUCCESS_UPDATE_COMPANY
    }
}
