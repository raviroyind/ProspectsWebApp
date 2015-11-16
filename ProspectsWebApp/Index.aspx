<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" EnableEventValidation="false" Inherits="ProspectsWebApp.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <script type="text/javascript">

        $(function () {
            $(".date-input").datepicker();
        });

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-lg-1"></div>
            <div class="col-lg-10">
                <div class="form-horizontal">
                    <div class="panel panel-default">
                        <div class="panel-heading">
                            <span>Search</span>
                        </div>
                        <div class="panel-body">
                            <div class="row pull-left">
                                <div class="col-md-2">
                                    <label>Search By:</label>
                                </div>
                                <div class="col-md-3">
                                    <asp:DropDownList runat="server" CssClass="form-control" ID="ddlSearcOn">
                                        <asp:ListItem Selected="True">Select</asp:ListItem>
                                        <asp:ListItem>Company</asp:ListItem>
                                        <asp:ListItem>ContactName</asp:ListItem>
                                        <asp:ListItem> ContactEmail</asp:ListItem>
                                        <asp:ListItem> ContactPhone</asp:ListItem>
                                        <asp:ListItem> ContactCity</asp:ListItem>
                                        <asp:ListItem> ContactState</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="col-md-3">
                                    <asp:TextBox runat="server" ID="txtSearch" Width="280" placeholder="Search..." CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="col-md-3">
                                    <asp:LinkButton ID="lnkBtnSearch"
                                        runat="server" CssClass="btn btn-default"
                                        OnClick="lnkBtnSearch_OnClick"><span aria-hidden="true" class="glyphicon glyphicon-search"></span> Search
                                    </asp:LinkButton>
                                </div>
                                <div class="col-md-1">
                                    <asp:LinkButton ID="lnkBtnResetSearch"
                                        runat="server" CssClass="btn btn-info"
                                        OnClick="lnkBtnResetSearch_OnClick"><span aria-hidden="true" class="glyphicon glyphicon-refresh"></span> Reset
                                    </asp:LinkButton>
                                </div>
                            </div>
                        </div>
                    </div>

                </div>

            </div>
            <div class="col-lg-1"></div>
        </div>

        <div class="row">
            <div class="col-lg-1"></div>
            <div class="col-lg-10">
                <asp:ValidationSummary runat="server" ID="valSum" DisplayMode="BulletList" ShowSummary="True" ShowMessageBox="False" ValidationGroup="edit" ForeColor="red" />
            </div>
            <div class="col-lg-1"></div>
        </div>


        <div class="row">

            <div class="col-lg-1"></div>
            <div class="col-lg-10">
                <asp:GridView ID="gvProspects" runat="server" Width="100%" AllowPaging="True" DataKeyNames="ProspectId"
                    PageSize="5" AutoGenerateColumns="False" ShowFooter="True" HeaderStyle-CssClass="visible-desktop"
                    CssClass="table table-striped table-bordered table-hover table-condensed"
                    GridLines="None"
                    CellPadding="0" border="0"
                    OnPageIndexChanging="gvProspects_OnPageIndexChanging"
                    OnSelectedIndexChanged="gvProspects_SelectedIndexChanged"
                    OnRowDataBound="gvProspects_RowDataBound"
                    OnRowEditing="gvProspects_OnRowEditing"
                    OnRowUpdating="gvProspects_OnRowUpdating"
                    OnRowCancelingEdit="gvProspects_OnRowCancelingEdit">

                    <HeaderStyle CssClass="header-column" />
                    <PagerSettings Mode="NumericFirstLast" Position="Top"></PagerSettings>
                    <PagerStyle CssClass="pagination-ys" />
                    <EmptyDataTemplate>
                    </EmptyDataTemplate>
                    <Columns>
                        <asp:TemplateField HeaderText="Prospect Id">
                            <HeaderStyle Font-Bold="True"></HeaderStyle>
                            <ItemTemplate>
                                <asp:Label ID="lblProspectId" runat="server" Text='<%# Eval("ProspectId")%>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:Label ID="lblProspectIdEdit" runat="server" Text='<%# Eval("ProspectId")%>'></asp:Label>
                            </EditItemTemplate>
                            <FooterTemplate>
                                <span></span>
                            </FooterTemplate>
                            <ItemStyle Wrap="False" HorizontalAlign="Center"></ItemStyle>
                            <HeaderStyle Wrap="False"></HeaderStyle>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Company">
                            <HeaderStyle Font-Bold="True"></HeaderStyle>
                            <ItemTemplate>
                                <asp:Label ID="lblCompany" runat="server" Text='<%# Eval("Company")%>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox runat="server" ID="txtCompanyEdit" Text='<%# Eval("Company")%>' CssClass="form-control" MaxLength="150"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator9" ErrorMessage="Contact Company is required!"
                                    Text="!" ForeColor="Red" ValidationGroup="edit" ControlToValidate="txtCompanyEdit" />
                            </EditItemTemplate>
                            <FooterTemplate>
                                <asp:TextBox runat="server" ID="txtCompanyAdd" CssClass="form-control" MaxLength="150"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator1" ErrorMessage="Contact Company is required!"
                                    Text="!" ForeColor="Red" ValidationGroup="add" ControlToValidate="txtCompanyAdd" />
                            </FooterTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Contact Name">
                            <HeaderStyle Font-Bold="True"></HeaderStyle>
                            <ItemTemplate>
                                <asp:Label ID="lblContactName" runat="server" Text='<%# Eval("ContactName")%>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox runat="server" ID="txtContactNameEdit" Text='<%# Eval("ContactName")%>' CssClass="form-control" MaxLength="150"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator10" ErrorMessage="Contact Name is required!"
                                    Text="!" ForeColor="Red" ValidationGroup="edit" ControlToValidate="txtContactNameEdit" />
                            </EditItemTemplate>
                            <FooterTemplate>
                                <asp:TextBox runat="server" ID="txtContactNameAdd" CssClass="form-control" MaxLength="150"></asp:TextBox>

                                <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator2" ErrorMessage="Contact Name is required!"
                                    Text="!" ForeColor="Red" ValidationGroup="add" ControlToValidate="txtContactNameAdd">
                                </asp:RequiredFieldValidator>

                            </FooterTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Email">
                            <HeaderStyle Font-Bold="True"></HeaderStyle>
                            <ItemTemplate>
                                <asp:Label ID="lblContactEmail" runat="server" Text='<%# Eval("ContactEmail")%>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox runat="server" ID="txtContactEmailEdit" Text='<%# Eval("ContactEmail")%>' CssClass="form-control" MaxLength="150"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator11" ErrorMessage="Contact Email is required!"
                                    Text="!" ForeColor="Red" ValidationGroup="edit" ControlToValidate="txtContactEmailEdit" />
                            </EditItemTemplate>
                            <FooterTemplate>
                                <asp:TextBox runat="server" ID="txtContactEmailAdd" CssClass="form-control" MaxLength="150"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator3" ErrorMessage="Contact Email is required!"
                                    Text="!" ForeColor="Red" ValidationGroup="add" ControlToValidate="txtContactEmailAdd">
                                </asp:RequiredFieldValidator>
                            </FooterTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Phone">
                            <HeaderStyle Font-Bold="True"></HeaderStyle>
                            <ItemTemplate>
                                <asp:Label ID="lblContactPhone" runat="server" Text='<%# Eval("ContactPhone")%>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox runat="server" ID="txtContactPhoneEdit" Text='<%# Eval("ContactPhone")%>' CssClass="form-control" MaxLength="150"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator12" ErrorMessage="Contact Phone is required!"
                                    Text="!" ForeColor="Red" ValidationGroup="edit" ControlToValidate="txtContactPhoneEdit" />
                            </EditItemTemplate>
                            <FooterTemplate>
                                <asp:TextBox runat="server" ID="txtContactPhoneAdd" CssClass="form-control" MaxLength="150"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator4" ErrorMessage="Contact Phone is required!"
                                    Text="!" ForeColor="Red" ValidationGroup="add" ControlToValidate="txtContactPhoneAdd">
                                </asp:RequiredFieldValidator>
                            </FooterTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="City">
                            <HeaderStyle Font-Bold="True"></HeaderStyle>
                            <ItemTemplate>
                                <asp:Label ID="lblContactCity" runat="server" Text='<%# Eval("ContactCity")%>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox runat="server" ID="txtContactCityEdit" Text='<%# Eval("ContactCity")%>' CssClass="form-control" MaxLength="150"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator13" ErrorMessage="Contact City is required!"
                                    Text="!" ForeColor="Red" ValidationGroup="edit" ControlToValidate="txtContactCityEdit" />
                            </EditItemTemplate>
                            <FooterTemplate>
                                <asp:TextBox runat="server" ID="txtContactCityAdd" CssClass="form-control" MaxLength="150"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator5" ErrorMessage="Contact City is required!"
                                    Text="!" ForeColor="Red" ValidationGroup="add" ControlToValidate="txtContactCityAdd">
                                </asp:RequiredFieldValidator>
                            </FooterTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="State">
                            <HeaderStyle Font-Bold="True" Width="120"></HeaderStyle>
                            <ItemTemplate>
                                <asp:Label ID="lblContactState" runat="server" Text='<%# Eval("ContactState")%>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>

                                <asp:DropDownList runat="server" ID="ddlStateEdit" CssClass="form-control"></asp:DropDownList>
                                <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator14" ErrorMessage="Please select State!"
                                    Text="!" ForeColor="Red" ValidationGroup="edit" InitialValue="Select" ControlToValidate="ddlStateEdit"></asp:RequiredFieldValidator>
                            </EditItemTemplate>
                            <FooterTemplate>
                                <asp:DropDownList runat="server" ID="ddlStateAdd" CssClass="form-control"></asp:DropDownList>
                                <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator7" ErrorMessage="Please select State!"
                                    Text="!" ForeColor="Red" ValidationGroup="add" InitialValue="Select" ControlToValidate="ddlStateAdd"></asp:RequiredFieldValidator>
                            </FooterTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Time Zone">
                            <HeaderStyle Font-Bold="True" Width="140"></HeaderStyle>
                            <ItemStyle Wrap="False"></ItemStyle>
                            <ItemTemplate>
                                <asp:Label ID="lblContactTimeZone" runat="server" Text='<%# Eval("ContactTimeZone")%>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:DropDownList runat="server" ID="ddlTimeZoneEdit" CssClass="form-control"></asp:DropDownList>
                            </EditItemTemplate>
                            <FooterTemplate>
                                <asp:DropDownList runat="server" ID="ddlTimeZoneAdd" CssClass="form-control"></asp:DropDownList>
                            </FooterTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Last Activity Date">
                            <HeaderStyle Font-Bold="True"></HeaderStyle>
                            <ItemStyle Wrap="False"></ItemStyle>
                            <ItemTemplate>
                                <asp:Label ID="lblLastActivityDate" runat="server" Text='<%# Eval("LastActivityDate", "{0:M-dd-yyyy}")%>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <div class="input-group" style="width: 150px;">
                                    <label class="input-group-btn" for="date-fld">
                                        <span class="btn btn-default">
                                            <span class="glyphicon glyphicon-calendar"></span>
                                        </span>
                                    </label>
                                    <asp:TextBox runat="server" ID="txtLastActivityDateEdit" Text='<%# Eval("LastActivityDate", "{0:M-dd-yyyy}")%>' CssClass="form-control date-input" Width="120"></asp:TextBox>
                                </div>
                                <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator15" ErrorMessage="Please select Last Activity Date!"
                                    Text="!" ForeColor="Red" ValidationGroup="edit" ControlToValidate="txtLastActivityDateEdit" />

                            </EditItemTemplate>
                            <FooterTemplate>
                                <div class="input-group" style="width: 150px;">
                                    <label class="input-group-btn" for="date-fld">
                                        <span class="btn btn-default">
                                            <span class="glyphicon glyphicon-calendar"></span>
                                        </span>
                                    </label>
                                    <asp:TextBox runat="server" ID="txtLastActivityDateAdd" CssClass="form-control date-input" Width="120"></asp:TextBox>
                                </div>
                                <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator16" ErrorMessage="Please select Last Activity Date!"
                                    Text="!" ForeColor="Red" ValidationGroup="add" ControlToValidate="txtLastActivityDateAdd" />
                            </FooterTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Created By">
                            <HeaderStyle Font-Bold="True"></HeaderStyle>
                            <ItemTemplate>
                                <asp:Label ID="lblCreatedBy" runat="server" Text='<%# Eval("CreatedByUserId")%>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                            </EditItemTemplate>
                            <FooterTemplate>
                                <asp:LinkButton ID="btnAdd" runat="server" CssClass="btn btn-success"
                                    CausesValidation="True" ValidationGroup="add" OnClick="btnAddProspect_OnClick">
                                <span aria-hidden="true" class="glyphicon glyphicon-plus-sign"></span>
                                Add
                                </asp:LinkButton>
                            </FooterTemplate>
                            <ItemStyle Wrap="False" HorizontalAlign="Center"></ItemStyle>
                            <HeaderStyle Wrap="False"></HeaderStyle>
                        </asp:TemplateField>

                        <asp:CommandField ButtonType="Image" EditImageUrl="~/CSS/edit.png" HeaderText="Edit/ Select"
                            EditText="Edit" ShowEditButton="true" CancelImageUrl="~/CSS/cancel.png" CancelText="Cancel"
                            UpdateImageUrl="~/CSS/Save.png" ValidationGroup="edit" CausesValidation="True" UpdateText="Save"
                            ShowDeleteButton="False" ItemStyle-Width="100"
                            SelectText="Select" SelectImageUrl="~/css/select.png" ShowSelectButton="True" />
                    </Columns>
                    <SelectedRowStyle BackColor="#a6e1ec"></SelectedRowStyle>
                </asp:GridView>
            </div>
            <div class="col-lg-1"></div>
        </div>
        <div class="row">
            <div class="col-lg-1"></div>
            <div class="col-lg-10">
                <asp:ValidationSummary runat="server" ID="ValidationSummary1" DisplayMode="BulletList" ShowSummary="True" ShowMessageBox="False" ValidationGroup="add" ForeColor="red" />
            </div>
            <div class="col-lg-1"></div>
        </div>

        <div class="row">
            <div class="col-lg-1"></div>
            <div class="col-lg-10">
                <asp:ValidationSummary runat="server" ID="ValidationSummary3" DisplayMode="BulletList" ShowSummary="True" ShowMessageBox="False" ValidationGroup="edit2" ForeColor="red" />
            </div>
            <div class="col-lg-1"></div>
        </div>

        <div class="row">
            <div class="col-lg-1"></div>
            <div class="col-lg-10">
                <div class="col-lg-3 pull-left">
                <strong style="color: orangered; text-decoration: underline; text-underline: navy; ">Prospect Id :</strong>  <strong style="color: orangered;" id="spanProspectId" runat="server"></strong>
                </div>
                <asp:GridView ID="gvComments" runat="server" Width="100%" AllowPaging="False" DataKeyNames="ConversationId"
                    PageSize="5" AutoGenerateColumns="False" ShowFooter="True" HeaderStyle-CssClass="visible-desktop"
                    CssClass="table table-striped table-bordered table-hover table-condensed"
                    GridLines="None"
                    CellPadding="0" border="0"
                    OnRowEditing="gvComments_OnRowEditing"
                    OnRowUpdating="gvComments_OnRowUpdating"
                    OnRowCancelingEdit="gvComments_OnRowCancelingEdit" OnRowDataBound="gvComments_RowDataBound">
                    <HeaderStyle CssClass="header-column" />

                    <EmptyDataTemplate>
                        <span class="alert-info">Please select a Prospect row above to view conversatios.</span>
                    </EmptyDataTemplate>
                    <Columns>
                        <%-- ConversationId --%>
                        <asp:TemplateField HeaderText="Conversation Id">
                            <HeaderStyle Font-Bold="True"></HeaderStyle>
                            <ItemTemplate>
                                <asp:Label ID="lblConversationId" runat="server" Text='<%# Eval("ConversationId")%>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:Label ID="lblConversationIdEdit" runat="server" Text='<%# Eval("ConversationId")%>'></asp:Label>
                            </EditItemTemplate>
                            <FooterTemplate>
                                <span></span>
                            </FooterTemplate>
                            <ItemStyle Wrap="False" HorizontalAlign="Center"></ItemStyle>
                            <HeaderStyle Wrap="False"></HeaderStyle>
                        </asp:TemplateField>

                        <%-- ProspectComment --%>
                        <asp:TemplateField HeaderText="Prospect Comment">
                            <HeaderStyle Font-Bold="True"></HeaderStyle>
                            <ItemTemplate>
                                <textarea id="txtProspectComment" runat="server" class="form-control" rows="3" placeholder='<%# Eval("ProspectComment")%>'></textarea>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox runat="server" ID="txtProspectCommentEdit" TextMode="MultiLine" Rows="3" Text='<%# Eval("ProspectComment")%>' CssClass="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" ID="rq1" ErrorMessage="Prospect Comment is required!"
                                    Text="!" ForeColor="Red" ValidationGroup="edit2" ControlToValidate="txtProspectCommentEdit" />
                            </EditItemTemplate>
                            <FooterTemplate>
                                <asp:TextBox runat="server" ID="txtProspectCommentAdd" TextMode="MultiLine" Rows="3" CssClass="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" ID="rq2" ErrorMessage="Prospect Comment is required!"
                                    Text="!" ForeColor="Red" ValidationGroup="add2" ControlToValidate="txtProspectCommentAdd" />
                            </FooterTemplate>
                        </asp:TemplateField>

                        <%-- ProspectCommentType --%>
                        <asp:TemplateField HeaderText="Comment Type">
                            <HeaderStyle Font-Bold="True"></HeaderStyle>
                            <ItemTemplate>
                                <asp:HiddenField runat="server" ID="hidProspectCommentTypeId" Value='<%# Eval("ProspectCommentTypeID")%>'/>
                                <asp:Label ID="lblProspectCommentTypeId" runat="server"></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:DropDownList runat="server" ID="ddlProspectCommentTypeEdit" CssClass="form-control"></asp:DropDownList>
                                <asp:RequiredFieldValidator runat="server" ID="rq3" ErrorMessage="Please select State!"
                                    Text="!" ForeColor="Red" ValidationGroup="edit2" InitialValue="Select" ControlToValidate="ddlProspectCommentTypeEdit">
                                </asp:RequiredFieldValidator>
                            </EditItemTemplate>
                            <FooterTemplate>
                                <asp:DropDownList runat="server" ID="ddlProspectCommentTypeAdd" CssClass="form-control"></asp:DropDownList>
                                <asp:RequiredFieldValidator runat="server" ID="rq4" ErrorMessage="Please select Comment Type!"
                                    Text="!" ForeColor="Red" ValidationGroup="add2" InitialValue="Select" ControlToValidate="ddlProspectCommentTypeAdd">
                                </asp:RequiredFieldValidator>
                            </FooterTemplate>
                        </asp:TemplateField>

                        <%--  ProspectStage --%>
                        <asp:TemplateField HeaderText="Stage">
                            <HeaderStyle Font-Bold="True"></HeaderStyle>
                            <ItemTemplate>
                                <asp:HiddenField runat="server" ID="hidProspectStageID" Value='<%# Eval("ProspectStageID")%>'/>
                                <asp:Label ID="lblProspectStageID" runat="server"  ></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:DropDownList runat="server" ID="ddlProspectStageIDEdit" CssClass="form-control"></asp:DropDownList>
                                <asp:RequiredFieldValidator runat="server" ID="rq5" ErrorMessage="Please select Prospect Stage!"
                                    Text="!" ForeColor="Red" ValidationGroup="edit2" InitialValue="Select" ControlToValidate="ddlProspectStageIDEdit">
                                </asp:RequiredFieldValidator>
                            </EditItemTemplate>
                            <FooterTemplate>
                                <asp:DropDownList runat="server" ID="ddlProspectStageIDAdd" CssClass="form-control"></asp:DropDownList>
                                <asp:RequiredFieldValidator runat="server" ID="rq6" ErrorMessage="Please select Prospect Stage!"
                                    Text="!" ForeColor="Red" ValidationGroup="add2" InitialValue="Select" ControlToValidate="ddlProspectStageIDAdd">
                                </asp:RequiredFieldValidator>
                            </FooterTemplate>
                        </asp:TemplateField>

                        <%-- ProspectCommentSource --%>
                        <asp:TemplateField HeaderText="Comment Source">
                            <HeaderStyle Font-Bold="True"></HeaderStyle>
                            <ItemTemplate>
                                <asp:HiddenField runat="server" ID="hidCommentSources" Value='<%# Eval("ProspectCommentSourceID")%>'/>
                                <asp:Label ID="lblCommentSources" runat="server"></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:DropDownList runat="server" ID="ddlCommentSourcesEdit" CssClass="form-control"></asp:DropDownList>
                                <asp:RequiredFieldValidator runat="server" ID="rq7" ErrorMessage="Please select Comment Source!"
                                    Text="!" ForeColor="Red" ValidationGroup="edit2" InitialValue="Select" ControlToValidate="ddlCommentSourcesEdit">
                                </asp:RequiredFieldValidator>
                            </EditItemTemplate>
                            <FooterTemplate>
                                <asp:DropDownList runat="server" ID="ddlCommentSourcesAdd" CssClass="form-control"></asp:DropDownList>
                                <asp:RequiredFieldValidator runat="server" ID="rq8" ErrorMessage="Please select Comment Source!"
                                    Text="!" ForeColor="Red" ValidationGroup="add2" InitialValue="Select" ControlToValidate="ddlCommentSourcesAdd">
                                </asp:RequiredFieldValidator>
                            </FooterTemplate>
                        </asp:TemplateField>

                        <%-- LastActivityDate --%>

                        <asp:TemplateField HeaderText="Last Activity Date">
                            <HeaderStyle Font-Bold="True"></HeaderStyle>
                            <ItemStyle Wrap="False"></ItemStyle>
                            <ItemTemplate>
                                <asp:Label ID="lblLastActivityDate2" runat="server" Text='<%# Eval("LastActivityDate", "{0:M-dd-yyyy}")%>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <div class="input-group" style="width: 150px;">
                                    <label class="input-group-btn" for="date-fld">
                                        <span class="btn btn-default">
                                            <span class="glyphicon glyphicon-calendar"></span>
                                        </span>
                                    </label>
                                    <asp:TextBox runat="server" ID="txtLastActivityDate2Edit" Text='<%# Eval("LastActivityDate", "{0:M-dd-yyyy}")%>' CssClass="form-control date-input" Width="120"></asp:TextBox>
                                </div>
                                <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator15" ErrorMessage="Please select Last Activity Date!"
                                    Text="!" ForeColor="Red" ValidationGroup="edit2" ControlToValidate="txtLastActivityDate2Edit" />
                            </EditItemTemplate>
                            <FooterTemplate>
                                <div class="input-group" style="width: 150px;">
                                    <label class="input-group-btn" for="date-fld">
                                        <span class="btn btn-default">
                                            <span class="glyphicon glyphicon-calendar"></span>
                                        </span>
                                    </label>
                                    <asp:TextBox runat="server" ID="txtLastActivityDate2Add" CssClass="form-control date-input" Width="120"></asp:TextBox>
                                </div>
                                <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator16" ErrorMessage="Please select Last Activity Date!"
                                    Text="!" ForeColor="Red" ValidationGroup="add2" ControlToValidate="txtLastActivityDate2Add" />
                            </FooterTemplate>
                        </asp:TemplateField>

                        <%-- KeyPhrase --%>
                        <asp:TemplateField HeaderText="Key Phrase">
                            <HeaderStyle Font-Bold="True"></HeaderStyle>
                            <ItemTemplate>
                                <textarea id="txtKeyPhrase" runat="server" class="form-control" rows="3" placeholder='<%# Eval("KeyPhrase")%>'></textarea>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox runat="server" ID="txtKeyPhraseEdit" TextMode="MultiLine" Rows="3" Text='<%# Eval("KeyPhrase")%>' CssClass="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" ID="rqKeyPhraseEdit" ErrorMessage="Key Phrase is required!"
                                    Text="!" ForeColor="Red" ValidationGroup="edit2" ControlToValidate="txtKeyPhraseEdit" />
                            </EditItemTemplate>
                            <FooterTemplate>
                                <asp:TextBox runat="server" ID="txtKeyPhraseAdd" TextMode="MultiLine" Rows="3" CssClass="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" ID="rqKeyPhraseAdd" ErrorMessage="Key Phrase is required!"
                                    Text="!" ForeColor="Red" ValidationGroup="add2" ControlToValidate="txtKeyPhraseAdd" />
                            </FooterTemplate>
                        </asp:TemplateField>

                        <%-- CreatedByUserId --%>
                        <asp:TemplateField HeaderText="Created By">
                            <HeaderStyle Font-Bold="True"></HeaderStyle>
                            <ItemTemplate>
                                <asp:Label ID="lblCreatedBy" runat="server" Text='<%# Eval("CreatedByUserId")%>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                            </EditItemTemplate>
                            <FooterTemplate>
                                <asp:LinkButton ID="btnAddComments" runat="server" CssClass="btn btn-success"
                                    CausesValidation="True" ValidationGroup="add2" OnClick="btnAddComments_OnClick">
                                <span aria-hidden="true" class="glyphicon glyphicon-plus-sign"></span>
                                Add
                                </asp:LinkButton>
                            </FooterTemplate>
                            <ItemStyle Wrap="False" HorizontalAlign="Center"></ItemStyle>
                            <HeaderStyle Wrap="False"></HeaderStyle>
                        </asp:TemplateField>

                        <%-- Comman Field --%>
                        <asp:CommandField ButtonType="Image" EditImageUrl="~/CSS/edit.png" HeaderText="Edit"
                            EditText="Edit" ShowEditButton="true" CancelImageUrl="~/CSS/cancel.png" CancelText="Cancel"
                            UpdateImageUrl="~/CSS/Save.png" ValidationGroup="edit2" CausesValidation="True" UpdateText="Save"
                            ShowDeleteButton="False" ItemStyle-Width="80"
                             />
                    </Columns>
                </asp:GridView>
            </div>
            <div class="col-lg-1"></div>
        </div>
        <div class="row">
            <div class="col-lg-1"></div>
            <div class="col-lg-10">
                <asp:ValidationSummary runat="server" ID="ValidationSummary2" DisplayMode="BulletList" ShowSummary="True" ShowMessageBox="False" ValidationGroup="add2" ForeColor="red" />
            </div>
            <div class="col-lg-1"></div>
        </div>
    </div>

    <script type="text/javascript">
        $(document).ready(function () {
            $(".btn-default").click(function () {
                $(".collapse").collapse("toggle");
            });
        });

        function CleanForm() {

            document.forms[0].reset();

            for (var i = 0; i < window.Page_Validators.length; i++) {
                window.Page_Validators[i].style.visibility = "hidden";
            }
            HideValidationSummary();
            return false;
        }

        function HideValidationSummary() {
            if (typeof (window.Page_ValidationSummaries) != "undefined") { //hide the validation summaries
                for (var sums = 0; sums < window.Page_ValidationSummaries.length; sums++) {
                    var summary = window.Page_ValidationSummaries[sums];
                    summary.style.display = "none";
                }
            }

        }
    </script>

</asp:Content>
