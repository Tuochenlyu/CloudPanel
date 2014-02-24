﻿using CloudPanel.Modules.Base.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CloudPanel.cpcontrols
{
    public partial class alertmessage : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        public void SetMessage(AlertType alertType, string message)
        {
            switch (alertType)
            {
                case AlertType.SUCCESS:
                    alertMessageDiv.Attributes["class"] = "alert alert-success";
                    lbErrorType.Text = "SUCCESS!";
                    break;
                case AlertType.WARNING:
                    alertMessageDiv.Attributes["class"] = "alert alert-warning";
                    lbErrorType.Text = "WARNING!";
                    break;
                case AlertType.ERROR:
                    alertMessageDiv.Attributes["class"] = "alert alert-danger";
                    lbErrorType.Text = "DANGER!";
                    break;
                default:
                    alertMessageDiv.Attributes["class"] = "alert alert-info";
                    lbErrorType.Text = "INFO!";
                    break;
            }

            // Set message
            litMessage.Text = message;

            // Show
            alertMessageDiv.Style.Remove("display");
        }

        public void HideMessage()
        {
            alertMessageDiv.Style.Add("display", "none");
        }
    }
}