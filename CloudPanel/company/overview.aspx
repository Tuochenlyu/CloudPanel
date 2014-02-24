﻿<%@ Page Title="" Language="C#" MasterPageFile="~/CloudPanel.Master" AutoEventWireup="true" CodeBehind="overview.aspx.cs" Inherits="CloudPanel.company.overview" %>
<%@ Register Src="~/cpcontrols/alertmessage.ascx" TagPrefix="uc1" TagName="alertmessage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cphMainPanel" runat="server">
    <div class="pageheader">
        <h2><i class="fa fa-building-o"></i>Company Overview</h2>
    </div>

    <div class="contentpanel">

        <uc1:alertmessage runat="server" ID="alertmessage" />

        <div class="row">
        <div class="col-sm-6">
            <div class="panel panel-primary">
                <div class="panel-heading">
                    <div class="panel-btns">
                        <a href="#" class="panel-close">&times;</a>
                        <a href="#" class="minimize">&minus;</a>
                    </div>
                    <!-- panel-btns -->
                    <h3 class="panel-title">Company Details</h3>
                </div>
                <div class="panel-body">
                    <div class="form-group">
                        <label class="col-sm-3 control-label">Company Name</label>
                        <div class="col-sm-4">
                            <asp:Label ID="lbCompanyName" runat="server" Text="Compsys"></asp:Label>
                        </div>
                    </div>

                    <div class="form-group">
                        <label class="col-sm-3 control-label">Company Code</label>
                        <div class="col-sm-4">
                            <asp:Label ID="lbCompanyCode" runat="server" Text="COM"></asp:Label>
                        </div>
                    </div>

                    <div class="form-group">
                        <label class="col-sm-3 control-label">Contacts Name</label>
                        <div class="col-sm-4">
                            <asp:Label ID="lbContactsName" runat="server" Text="Jacob Dixon"></asp:Label>
                        </div>
                    </div>

                    <div class="form-group">
                        <label class="col-sm-3 control-label">Telephone</label>
                        <div class="col-sm-4">
                            <asp:Label ID="lbTelephone" runat="server" Text="(501) 758-6818"></asp:Label>
                        </div>
                    </div>

                    <div class="form-group">
                        <label class="col-sm-3 control-label">When Created</label>
                        <div class="col-sm-4">
                            <asp:Label ID="lbWhenCreated" runat="server" Text="1/2/2013"></asp:Label>
                        </div>
                    </div>

                    <div class="form-group">
                        <label class="col-sm-3 control-label">Current Plan</label>
                        <div class="col-sm-4">
                            <asp:DropDownList ID="ddlCurrentPlan" runat="server" CssClass="form-control chosen-select">

                            </asp:DropDownList>
                        </div>
                    </div>
                </div>
            </div>
            <!-- panel -->
        </div>
        <!-- col-sm-6 -->

        <div class="col-sm-6">
            <div class="panel panel-primary">
                <div class="panel-heading">
                    <div class="panel-btns">
                        <a href="#" class="panel-close">&times;</a>
                        <a href="#" class="minimize">&minus;</a>
                    </div>
                    <!-- panel-btns -->
                    <h3 class="panel-title">Product Details</h3>
                </div>
                <div class="panel-body">

                    <span class="sublabel">Users
                        <asp:Label ID="lbUsers" runat="server" Text="(60 / 100)"></asp:Label></span>
                    <div class="progress progress-sm">
                        <div style="width: 60%" aria-valuemax="100" aria-valuemin="0" aria-valuenow="40" role="progressbar" class="progress-bar progress-bar-primary" runat="server" id="Div1"></div>
                    </div>
                    <!-- progress -->

                    <span class="sublabel">Domains
                        <asp:Label ID="lbTotalMailboxes" runat="server" Text="(1 / 10)"></asp:Label></span>
                    <div class="progress progress-sm">
                        <div style="width: 10%" aria-valuemax="100" aria-valuemin="0" aria-valuenow="40" role="progressbar" class="progress-bar progress-bar-danger" runat="server" id="progBarMailboxes"></div>
                    </div>
                    <!-- progress -->

                    <span class="sublabel">Mailboxes
                        <asp:Label ID="lbTotalCitrixUsers" runat="server" Text="(30 / 100)"></asp:Label></span>
                    <div class="progress progress-sm">
                        <div style="width: 30%" aria-valuemax="100" aria-valuemin="0" aria-valuenow="40" role="progressbar" class="progress-bar progress-bar-warning" runat="server" id="progBarCitrix"></div>
                    </div>
                    <!-- progress -->

                    <span class="sublabel">Contacts
                        <asp:Label ID="lbTotalLyncUsers" runat="server" Text="(2 / 20)"></asp:Label></span>
                    <div class="progress progress-sm">
                        <div style="width: 10%" aria-valuemax="100" aria-valuemin="0" aria-valuenow="40" role="progressbar" class="progress-bar progress-bar-info" runat="server" id="progBarLync"></div>
                    </div>
                    <!-- progress -->

                    <span class="sublabel">Distribution Groups
                        <asp:Label ID="Label2" runat="server" Text="(5 / 10)"></asp:Label></span>
                    <div class="progress progress-sm">
                        <div style="width: 50%" aria-valuemax="100" aria-valuemin="0" aria-valuenow="40" role="progressbar" class="progress-bar progress-bar-success" runat="server" id="Div2"></div>
                    </div>
                    <!-- progress -->

                </div>
            </div>
            <!-- panel -->
        </div>
        <!-- col-sm-6 -->
        </div>

        <div class="row">

            <div class="col-md-6">
                <div class="panel panel-primary">
                    <div class="panel-heading">
                        <div class="panel-btns">
                            <a href="#" class="panel-close">&times;</a>
                            <a href="#" class="minimize">&minus;</a>
                        </div>
                        <!-- panel-btns -->
                        <h3 class="panel-title">Company Location</h3>
                    </div>
                    <div class="panel-body">
                        <div id="gmap-marker" style="height: 300px"></div>
                    </div>
                    <!-- col-md-6 -->
                </div>
            </div>
            

            <div class="col-sm-6">
                <div class="panel panel-default panel-alt widget-messaging">
                    <div class="panel-heading">
                        <h3 class="panel-title">Recent Actions</h3>
                    </div>
                    <div class="panel-body">
                        <ul>
                            <li>
                                <small class="pull-right">Dec 10</small>
                                <h4 class="sender">Enabled Mailbox</h4>
                                <small>Enabled mailbox for user jdixon@compsysar.com</small>
                            </li>
                            <li>
                                <small class="pull-right">Dec 9</small>
                                <h4 class="sender">Created User</h4>
                                <small>Created a new user jdixon@compsysar.com</small>
                            </li>
                        </ul>
                    </div>
                    <!-- panel-body -->
                </div>
                <!-- panel -->
            </div>

        </div>

    </div>
    <!-- contentpanel -->
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="cphJavascript" runat="server">
    <script src='<%= this.ResolveClientUrl("~/js/chosen.jquery.min.js") %>'></script>
    <script src="http://maps.google.com/maps/api/js?sensor=true"></script>
    <script src='<%= this.ResolveClientUrl("~/js/gmaps.js") %>'></script>
    <script type="text/javascript">

        jQuery(document).ready(function () {

            // Chosen Select
            jQuery(".chosen-select").chosen({ 'width': '100%', 'white-space': 'nowrap' });

            var map_marker = new GMaps({
                div: '#gmap-marker',
                lat: -12.043333,
                lng: -77.028333
            });

            map_marker.addMarker({
                lat: -12.043333,
                lng: -77.028333,
                click: function (e) {
                    alert('You clicked in this marker');
                }
            });

        });

    </script>
</asp:Content>