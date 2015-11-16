<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="listOfProspects.aspx.cs" Inherits="ProspectsWebApp.listOfProspects" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Sticky footer wrap -->
    <div id="wrap">
        <!-- Container -->

        <div id="container">
            <!-- Header -->
            <div id="header" class="header">
                <div id="branding">
                    <a href="#">
                        <h1 id="site-name">Prospects</h1>
                    </a>
                </div>

                <div class="header-content header-content-first">
                    <div class="header-column icon">
                        <i class="icon-time"></i>
                    </div>
                    <div class="header-column">
                    </div>
                </div>

                <div class="header-content">
                    <div class="header-column icon">
                        <i class="icon-home"></i>
                        <br>
                        <i class="icon-comment"></i>
                    </div>
                    <div class="header-column">
                    </div>
                </div>
                <div id="user-tools">
                    <span class="user-links">
                        <i class="icon-home"></i>
                        <asp:Label ID="lblUser" runat="server" CssClass="btn-high bold"></asp:Label>
                        <i class="icon-lock" style="color: #ffffff;"></i>
                        <asp:HyperLink runat="server" ID="hypUser" NavigateUrl="../default.aspx?id=lg" Text="Logout"></asp:HyperLink>
                    </span>
                </div>
            </div>

            <!-- END Header -->


            <div class="suit-columns two-columns">
                <div id="suit-center" class="suit-column">
                    <ul class="breadcrumb">
                        <li>
                            <a href="#"></a>
                            <span class="divider"><span class="alert-info">» List of Prospects</span></span>
                        </li>
                        <li class="active"></li>
                    </ul>

                    <!-- Content -->
                    <div id="content" class="flex row-fluid">
                        <div id="content-main">
                            <div class="inner-center-column">
                                <div class="module" id="changelist">
                                    <div class="toolbar-content clearfix">
                                        <div class="object-tools">
                                        </div>
                                        <div id="toolbar" class="clearfix">
                                        </div>

                                    </div>
                                    <div>
                                        <div id="divResults" runat="server" style="display: block;" class="results">
                                            <div class="breadcrumb">
                                                <span class="alert-info"></span>
                                                <br />
                                                <div class="form-horizontal" style="padding-top: 20px;">
                                                    <asp:ValidationSummary runat="server" ID="valSum" DisplayMode="List" ShowSummary="True" ShowMessageBox="False" ForeColor="Red" />
                                                    <div>
                                                        <asp:Label runat="server" ID="lblMsg" CssClass="alert-danger"></asp:Label>
                                                    </div>
                                                </div>
                                                <div class="two-columns">
                                                    <div class="left-column"></div>
                                                    <div class="right-column">
                                                        <div style="display: block;" class="results">
                                                            <div class="breadcrumb">
                                                                <span class="alert-info"></span>

                                                                <div class="form-horizontal" style="padding-top: 10px;">

                                                                    <div class="two-columns">
                                                                        <div class="left-column">
                                                                            <%-- Add Prospects Start --%>
                                                                            <div id="diAdd" runat="server" style="display: block;">
                                                                                <div class="container" style="width: 40%; text-align: left; margin-top: 15%;">
                                                                                    <div class="well" style="background-color: #5295b0;">
                                                                                        <h2 style="color: #ffffff;">Add Prospect</h2>
                                                                                    </div>
                                                                                    <div class="well" style="padding-top: 0;">
                                                                                        <br />
                                                                                        <div class="form-horizontal">
                                                                                            <div class="form-group">
                                                                                               
                                                                                                <div class="col-sm-4">
                                                                                                    <span class="label"> Company</span>
                                                                                                    <asp:TextBox ID="txtCompany"   CssClass="input-large" runat="server"></asp:TextBox>
                                                                                                   
                                                                                                </div>
                                                                                           
                                                                                            <br />
                                                                                            <div class="row">
                                                                                                <div class="col-sm-4">
                                                                                                    <span class="label"> Contact Name</span>
                                                                                                    <asp:TextBox ID="txtContactName" CssClass="input-large" runat="server"></asp:TextBox>
                                                                                                </div>
                                                                                            </div>
                                                                                                 </div>
                                                                                        </div>
                                                                                        <br />
                                                                                        <div>
                                                                                            <asp:LinkButton runat="server" ID="btnLogin" CausesValidation="True" class="btn btn-info"  >Logon</asp:LinkButton>
                                                                                            <asp:LinkButton runat="server" ID="btnCancel"   class="btn btn-info">Cancel</asp:LinkButton>
                                                                                        </div>
                                                                                        <br />
                                                                                        <div style="display: none;" id="divMsg" runat="server"><span style="color: red">Invalid credentials. Please try again!</span></div>
                                                                                        <div class="alert-info">
                                                                                            Un-authorized use is prohibited.
                                                                                        </div>
                                                                                    </div>

                                                                                </div>
                                                                            </div>
                                                                            
                                                                            <%-- Add Prospects End --%>
                                                                        </div>
                                                                        <div class="right-column">

                                                                            <asp:GridView ID="gvProspects" runat="server" Width="100%" DataKeyNames="Srno" AutoGenerateColumns="False" HeaderStyle-CssClass="visible-desktop" CssClass="table table-striped table-bordered table-hover table-condensed table-mptt" GridLines="None"
                                                                                CellPadding="0" border="0" AllowPaging="False" EmptyDataText="No records has been added."
                                                                                OnRowDataBound="gvProspects_OnRowDataBound" OnRowEditing="gvProspects_OnRowEditing" OnRowCancelingEdit="gvProspects_OnRowCancelingEdit"
                                                                                OnRowUpdating="gvProspects_OnRowUpdating" OnRowDeleting="gvProspects_OnRowDeleting">
                                                                                <AlternatingRowStyle CssClass="row2" />
                                                                                <RowStyle CssClass="row1" />
                                                                                <HeaderStyle CssClass="sortable" />
                                                                                <Columns>
                                                                                    <asp:TemplateField HeaderText="Select" ItemStyle-Width="40">
                                                                                        <HeaderTemplate>
                                                                                            <strong>Select</strong>
                                                                                        </HeaderTemplate>
                                                                                        <ItemTemplate>
                                                                                            <asp:CheckBox ID="chkSelect" runat="server" />
                                                                                        </ItemTemplate>
                                                                                    </asp:TemplateField>
                                                                                </Columns>
                                                                            </asp:GridView>

                                                                        </div>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                        </div>

                                                    </div>

                                                    <div id="grid" runat="server">
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!-- END Content -->
                    </div>
                </div>
                <div id="suit-left" class="suit-column">
                    <div class="left-nav" id="left-nav" style="margin-left: 15px;">
                        <ul>
                            <li class="alert-info">
                                <asp:HyperLink runat="server" CssClass="user-links" ID="hypHome" NavigateUrl="#" Text="Home"></asp:HyperLink>
                            </li>
                            <li class="alert-info">
                                <a href="#" class="user-links">View Output Xmls</a>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
            <!-- Sticky footer push -->
            <div id="push"></div>
        </div>
    </div>
</asp:Content>
