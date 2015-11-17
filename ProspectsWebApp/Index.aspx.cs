using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Linq.Expressions;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using ProspectsWebApp.App_Code;
using ProspectsWebApp;

namespace ProspectsWebApp
{
    public partial class Index : System.Web.UI.Page
    {
        //Hard coded User Id, replace with session variable.
        public static readonly Guid UserId = new Guid("CF7C8C10-F16B-4746-9F05-3195682CA327");

        public enum SearchOn
        {
          None,
          Company,
          ContactName,
          ContactEmail,
          ContactPhone,
          ContactCity,
          ContactState
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid(SearchOn.None);
                PopulateDropdowns();
            }
        }


        #region Functions...
        private void PopulateDropdowns()
        {
             
                var ddlState = (DropDownList) gvProspects.FooterRow.FindControl("ddlStateAdd");
                ddlState.DataSource = StateArray.States();
                ddlState.DataTextField = "Name";
                ddlState.DataValueField = "Abbreviations";
                ddlState.DataBind();

                ddlState.Items.Insert(0, "Select");


                var tzCollection = TimeZoneInfo.GetSystemTimeZones();

                var ddlTimeZoneAdd = (DropDownList) gvProspects.FooterRow.FindControl("ddlTimeZoneAdd");
                ddlTimeZoneAdd.DataSource = tzCollection;
                ddlTimeZoneAdd.DataTextField = "DisplayName";
                ddlTimeZoneAdd.DataValueField = "Id";
                ddlTimeZoneAdd.DataBind();

                ddlTimeZoneAdd.Items.Insert(0, "Select");
             
        }

        /// <summary>
        /// This method return a datatable with empty row.
        /// </summary>
        /// <returns></returns>
        public DataTable ReturnEmptyDataTable()
        {
            var dtProspect = new DataTable();

            var dcId = new DataColumn("ProspectId", typeof(System.Int32));
            dtProspect.Columns.Add(dcId);

            var dcCompany = new DataColumn("Company", typeof(System.String));
            dtProspect.Columns.Add(dcCompany);

            var dcContactName = new DataColumn("ContactName", typeof(System.String));
            dtProspect.Columns.Add(dcContactName);

            var dcContactEmail = new DataColumn("ContactEmail", typeof(System.String));
            dtProspect.Columns.Add(dcContactEmail);

            var dcContactPhone = new DataColumn("ContactPhone", typeof(System.String));
            dtProspect.Columns.Add(dcContactPhone);

            var dcContactCity = new DataColumn("ContactCity", typeof(System.String));
            dtProspect.Columns.Add(dcContactCity);

            var dcContactState = new DataColumn("ContactState", typeof(System.String));
            dtProspect.Columns.Add(dcContactState);

            var dcContactTimeZone = new DataColumn("ContactTimeZone", typeof(System.String));
            dtProspect.Columns.Add(dcContactTimeZone);

            var dcLastActivityDate = new DataColumn("LastActivityDate", typeof(System.String));
            dtProspect.Columns.Add(dcLastActivityDate);

            var dcCreatedByUserId = new DataColumn("CreatedByUserId", typeof(System.Guid));
            dtProspect.Columns.Add(dcCreatedByUserId);

            var datatRow = dtProspect.NewRow();

            dtProspect.Rows.Add(datatRow);
            return dtProspect;
        }
         
        private void BindGrid(SearchOn searchOn,string searchTerm=null,int startRowIndex=0, int maximumRows=0)
        {
            var dbContext = new ProspectDataContext();

            var listProspects = dbContext.Prospects.OrderBy(x => x.LastActivityDate).ToList();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                switch (searchOn)
                {
                   case SearchOn.Company:
                        listProspects = listProspects.Where(p => p.Company.ToLower().Contains(searchTerm)).ToList();
                        break;
                   case SearchOn.ContactEmail:
                        listProspects = listProspects.Where(p => p.ContactEmail.ToLower().Contains(searchTerm)).ToList();
                        break;
                   case SearchOn.ContactName:
                        listProspects = listProspects.Where(p => p.ContactName.ToLower().Contains(searchTerm)).ToList();
                        break;
                   case SearchOn.ContactPhone:
                        listProspects = listProspects.Where(p => p.ContactPhone.ToLower().Contains(searchTerm)).ToList();
                        break;
                   case SearchOn.ContactCity:
                        listProspects = listProspects.Where(p => p.ContactCity.ToLower().Contains(searchTerm)).ToList();
                        break;
                   case SearchOn.ContactState:
                        listProspects = listProspects.Where(p => p.ContactState.ToLower().Contains(searchTerm)).ToList();
                        break;
                }

            }

            gvProspects.DataSource = listProspects;
            gvProspects.DataBind();

            if (gvProspects.Rows.Count == 0)
            {
                gvProspects.DataSource = ReturnEmptyDataTable();
                gvProspects.DataBind();
                lblMsg.Text = "No records found";
            }
            else
            {
                lblMsg.Text = listProspects.Count + " records found.";
            }

            gvProspects.SelectedIndex = -1;
            divComments.Style.Add(HtmlTextWriterStyle.Display, "none");
        }

        #endregion Functions...

        #region Events...
        protected void gvProspects_OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            var dbContext = new ProspectDataContext();
            var prospects = dbContext.Prospects.OrderBy(x => x.LastActivityDate).ToList();

            gvProspects.DataSource = prospects;
            gvProspects.PageIndex = e.NewPageIndex;
            gvProspects.DataBind();

            PopulateDropdowns();
            gvProspects.SelectedIndex = -1;
            spanProspectId.InnerText = string.Empty;
            gvComments.DataSource = ReturnEmptyDataTableComments();
            gvComments.DataBind();
            divComments.Style.Add(HtmlTextWriterStyle.Display, "none");
            lblMsg.Text = string.Empty;
        }

        protected void btnAddProspect_OnClick(object sender, EventArgs e)
        {
           
            var txtCompanyAdd = (TextBox)gvProspects.FooterRow.FindControl("txtCompanyAdd");
            var txtContactNameAdd = (TextBox)gvProspects.FooterRow.FindControl("txtContactNameAdd");
            var txtContactEmailAdd = (TextBox)gvProspects.FooterRow.FindControl("txtContactEmailAdd");
            var txtContactPhoneAdd = (TextBox)gvProspects.FooterRow.FindControl("txtContactPhoneAdd");
            var txtContactCityAdd = (TextBox)gvProspects.FooterRow.FindControl("txtContactCityAdd");
            var ddlState = (DropDownList)gvProspects.FooterRow.FindControl("ddlStateAdd");
            var ddlContactTimeZoneAdd = (DropDownList)gvProspects.FooterRow.FindControl("ddlTimeZoneAdd");
            var txtLastActivityDateAdd = (TextBox)gvProspects.FooterRow.FindControl("txtLastActivityDateAdd");


            var dbContext = new ProspectDataContext();

            var dbProspect = new Prospect
            {
                Company = txtCompanyAdd.Text,
                ContactName = txtContactNameAdd.Text,
                ContactEmail = txtContactEmailAdd.Text,
                ContactPhone = txtContactPhoneAdd.Text,
                ContactCity = txtContactCityAdd.Text,
                ContactState = ddlState.SelectedValue,
                ContactTimeZone = ddlContactTimeZoneAdd.SelectedValue,
                LastActivityDate =Convert.ToDateTime(txtLastActivityDateAdd.Text),
                CreatedByUserId = UserId
            };

            dbContext.Prospects.InsertOnSubmit(dbProspect);
            dbContext.SubmitChanges();
            lblMsg.Text = "Prospect for Company: " + txtCompanyAdd.Text + " added.";

            BindGrid(SearchOn.None);
            PopulateDropdowns();

        }

        protected void gvProspects_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedRow = gvProspects.SelectedRow;

            var dataKey = gvProspects.DataKeys[selectedRow.RowIndex];
            if (dataKey == null) return;
            var id =  dataKey["ProspectId"].ToString();
            if (!String.IsNullOrEmpty(id))
                BindListOfProspects(Convert.ToInt32(id));

            lblMsg.Text = string.Empty;
        }

        protected void gvProspects_RowDataBound(object sender, GridViewRowEventArgs e)
        { 
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
               
                var lblCreatedBy = (Label)e.Row.FindControl("lblCreatedBy");

                if (lblCreatedBy != null )
                {
                    if (!string.IsNullOrEmpty(lblCreatedBy.Text))
                    {
                        var dbContext = new ProspectDataContext();
                        var userId = Guid.Parse(lblCreatedBy.Text);

                        var query = from c in dbContext.UserInfos
                            where c.UserId.Equals(userId)
                            select c.FirstName + " " + c.LastName;

                        lblCreatedBy.Text = query.First();
                    }
                }
            }

            if (e.Row.RowType == DataControlRowType.Footer)
            {
                var txtLastActivityDateAdd = (TextBox) e.Row.FindControl("txtLastActivityDateAdd");
                txtLastActivityDateAdd.Attributes.Add("datepicker", "datepicker();");
            }
        }
 
        protected void gvProspects_OnRowEditing(object sender, GridViewEditEventArgs e)
        {

            var lblContactState = (Label)gvProspects.Rows[e.NewEditIndex].FindControl("lblContactState");
            var lblContactTimeZone = (Label) gvProspects.Rows[e.NewEditIndex].FindControl("lblContactTimeZone");
            gvProspects.EditIndex = e.NewEditIndex;
            BindGrid(SearchOn.None);
           
            var row = gvProspects.Rows[e.NewEditIndex];
            var ddlState = (DropDownList)row.FindControl("ddlStateEdit");

            ddlState.DataSource = StateArray.States();
            ddlState.DataTextField = "Name";
            ddlState.DataValueField = "Abbreviations";
            ddlState.DataBind();

            ddlState.Items.Insert(0, "Select");

            
            ddlState.Items.FindByValue(lblContactState.Text).Selected = true;


            var tzCollection = TimeZoneInfo.GetSystemTimeZones();

            var ddlTimeZoneEdit = (DropDownList)row.FindControl("ddlTimeZoneEdit");
            ddlTimeZoneEdit.DataSource = tzCollection;
            ddlTimeZoneEdit.DataTextField = "DisplayName";
            ddlTimeZoneEdit.DataValueField = "Id";
            ddlTimeZoneEdit.DataBind();

            ddlTimeZoneEdit.Items.Insert(0, "Select");

            ddlTimeZoneEdit.Items.FindByValue(lblContactTimeZone.Text).Selected = true;
             
        }

        protected void gvProspects_OnRowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            var row = gvProspects.Rows[e.RowIndex];
            var prospectId =Convert.ToInt32(Convert.ToString(gvProspects.DataKeys[e.RowIndex].Values[0]));
            var company  = (row.FindControl("txtCompanyEdit") as TextBox).Text;
            var contactName  = (row.FindControl("txtContactNameEdit") as TextBox).Text;
            var contactEmail =(row.FindControl("txtContactEmailEdit") as TextBox).Text;
            var contactPhone  =(row.FindControl("txtContactPhoneEdit") as TextBox).Text;
            var contactCity  =(row.FindControl("txtContactCityEdit") as TextBox).Text;
            var contactState  =(row.FindControl("ddlStateEdit") as DropDownList).SelectedValue;
            var contactTimeZone =(row.FindControl("ddlTimeZoneEdit") as DropDownList).SelectedIndex==-1?"":(row.FindControl("ddlTimeZoneEdit") as DropDownList).SelectedValue;
            var createdByUserId = Guid.Parse("CF7C8C10-F16B-4746-9F05-3195682CA327");
            var lastActivityDate = (row.FindControl("txtLastActivityDateEdit") as TextBox).Text;
             
            using (var dataContext = new ProspectDataContext())
            { 
                var prospect = dataContext.Prospects.FirstOrDefault(p => p.ProspectId.Equals(prospectId));
                 
                if (prospect != null)
                {
                    prospect.Company = company;
                    prospect.ContactName = contactName;
                    prospect.ContactEmail = contactEmail;
                    prospect.ContactPhone = contactPhone;
                    prospect.ContactCity = contactCity;
                    prospect.ContactState = contactState;
                    prospect.ContactTimeZone = contactTimeZone;
                    prospect.CreatedByUserId = createdByUserId;
                    prospect.LastActivityDate = Convert.ToDateTime(lastActivityDate);
                 
                    try
                    {
                       
                        dataContext.SubmitChanges();
                    }
                    catch (DbEntityValidationException ex)
                    {
                        foreach (var eve in ex.EntityValidationErrors)
                        {
                            Console.WriteLine(
                                "Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                                eve.Entry.Entity.GetType().Name, eve.Entry.State);
                            foreach (var ve in eve.ValidationErrors)
                            {
                                Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                    ve.PropertyName, ve.ErrorMessage);
                            }
                        }
                    }
                }

            }
            gvProspects.EditIndex = -1;
            BindGrid(SearchOn.None);
            PopulateDropdowns();
        }

        protected void gvProspects_OnRowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvProspects.EditIndex = -1;
            BindGrid(SearchOn.Company);
            PopulateDropdowns();
        }

        #endregion Events...

        #region Search...
        protected void lnkBtnSearch_OnClick(object sender, EventArgs e)
        { 
            switch (ddlSearcOn.SelectedIndex)
            {
                case 1:
                    BindGrid(SearchOn.Company,txtSearch.Text.ToLower());
                    break;
                case 2:
                    BindGrid(SearchOn.ContactName, txtSearch.Text.ToLower());
                    break;
                case 3:
                    BindGrid(SearchOn.ContactEmail, txtSearch.Text.ToLower());
                    break;
                case 4:
                    BindGrid(SearchOn.ContactPhone, txtSearch.Text.ToLower());
                    break;
                case 5:
                    BindGrid(SearchOn.ContactCity, txtSearch.Text.ToLower());
                    break;
                case 6:
                    BindGrid(SearchOn.ContactState, txtSearch.Text.ToLower());
                    break;
            }
             
        }


        protected void lnkBtnResetSearch_OnClick(object sender, EventArgs e)
        {
            ddlSearcOn.SelectedIndex = 0;
            txtSearch.Text = string.Empty;
            txtSearch.Attributes.Add("placeholder", "Search...");
            BindGrid(SearchOn.None);
            PopulateDropdowns();
            divComments.Style.Add(HtmlTextWriterStyle.Display, "none");
            lblMsg.Text = string.Empty;
        }


        #endregion Search...

        #region Conversations...

        private void BindListOfProspects(int id)
        {
            var dbContext = new ProspectDataContext();
            gvComments.DataSource = dbContext.ProspectConversations.Where(p => p.ProspectId.Equals(id)).ToList();
            gvComments.DataBind();

            spanProspectId.InnerText = id.ToString();
            if (gvComments.Rows.Count == 0)
            {
                gvComments.DataSource = ReturnEmptyDataTableComments();
                gvComments.DataBind();
            }

            PopulateDropdownsProspectConversations();
            divComments.Style.Add(HtmlTextWriterStyle.Display, "block");

        }

        /// <summary>
        /// This method return a datatable with empty row.
        /// </summary>
        /// <returns></returns>
        public DataTable ReturnEmptyDataTableComments()
        {
            var dtProspect = new DataTable();

            var dcId = new DataColumn("ConversationId", typeof(System.Int32));
            dtProspect.Columns.Add(dcId);

            var dcProspectId = new DataColumn("ProspectId", typeof(System.Int32));
            dtProspect.Columns.Add(dcProspectId);

            var dcProspectComment = new DataColumn("ProspectComment", typeof(System.String));
            dtProspect.Columns.Add(dcProspectComment);

            var dcProspectCommentTypeId = new DataColumn("ProspectCommentTypeID", typeof(System.Int32));
            dtProspect.Columns.Add(dcProspectCommentTypeId);

            var dcProspectStageId = new DataColumn("ProspectStageID", typeof(System.Int32));
            dtProspect.Columns.Add(dcProspectStageId);

            var dcProspectCommentSourceId = new DataColumn("ProspectCommentSourceID", typeof(System.String));
            dtProspect.Columns.Add(dcProspectCommentSourceId);

            var dcKeyPhrase = new DataColumn("KeyPhrase", typeof(System.String));
            dtProspect.Columns.Add(dcKeyPhrase);

            var dcLastActivityDate = new DataColumn("LastActivityDate", typeof(System.String));
            dtProspect.Columns.Add(dcLastActivityDate);

            var dcCreatedByUserId = new DataColumn("CreatedByUserId", typeof(System.Guid));
            dtProspect.Columns.Add(dcCreatedByUserId);

            var datatRow = dtProspect.NewRow();

            dtProspect.Rows.Add(datatRow);
            return dtProspect;
        }

        protected void gvComments_OnRowEditing(object sender, GridViewEditEventArgs e)
        {
            var hidProspectCommentTypeId = (HiddenField)gvComments.Rows[e.NewEditIndex].FindControl("hidProspectCommentTypeId");
            var hidProspectStageId = (HiddenField)gvComments.Rows[e.NewEditIndex].FindControl("hidProspectStageID");
            var hidCommentSources = (HiddenField)gvComments.Rows[e.NewEditIndex].FindControl("hidCommentSources");

            gvComments.EditIndex = e.NewEditIndex;
            BindListOfProspects(Convert.ToInt32(spanProspectId.InnerText));

            var row = gvComments.Rows[e.NewEditIndex];

            var dbContext = new ProspectDataContext();

            #region  ProspectCommentType Dropdown...

            var ddlProspectCommentTypeEdit = (DropDownList)row.FindControl("ddlProspectCommentTypeEdit");

            ddlProspectCommentTypeEdit.DataSource = dbContext.ProspectCommentTypes.ToList();
            ddlProspectCommentTypeEdit.DataTextField = "ProspectComment";
            ddlProspectCommentTypeEdit.DataValueField = "ProspectCommentTypeID";
            ddlProspectCommentTypeEdit.DataBind();

            ddlProspectCommentTypeEdit.Items.Insert(0, "Select");

            ddlProspectCommentTypeEdit.Items.FindByValue(hidProspectCommentTypeId.Value).Selected = true;

            #endregion  ProspectCommentType Dropdown...

            #region ProspectStageType Dropdown...

            var ddlProspectStageIdEdit = (DropDownList)row.FindControl("ddlProspectStageIDEdit");

            ddlProspectStageIdEdit.DataSource = dbContext.ProspectProspectStages.ToList();
            ddlProspectStageIdEdit.DataTextField = "ProspectStage";
            ddlProspectStageIdEdit.DataValueField = "ProspectStageID";
            ddlProspectStageIdEdit.DataBind();

            ddlProspectStageIdEdit.Items.Insert(0, "Select");

            ddlProspectStageIdEdit.Items.FindByValue(hidProspectStageId.Value).Selected = true;

            #endregion ProspectStageType Dropdown...

            #region ProspectCommentSource Dropdown...

            var ddlCommentSourcesEdit = (DropDownList)row.FindControl("ddlCommentSourcesEdit");

            ddlCommentSourcesEdit.DataSource = dbContext.ProspectCommentSources.ToList();
            ddlCommentSourcesEdit.DataTextField = "ProspectCommentSource1";
            ddlCommentSourcesEdit.DataValueField = "ProspectCommentSourceID";
            ddlCommentSourcesEdit.DataBind();

            ddlCommentSourcesEdit.Items.Insert(0, "Select");

            ddlCommentSourcesEdit.Items.FindByValue(hidCommentSources.Value).Selected = true;

            #endregion ProspectCommentSource Dropdown...

        }

        protected void gvComments_OnRowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            var row = gvComments.Rows[e.RowIndex];
            var conversationId = Convert.ToInt32(Convert.ToString(gvComments.DataKeys[e.RowIndex].Values[0]));
            var prospectId = Convert.ToInt32(spanProspectId.InnerText);

            var prospectComment = (row.FindControl("txtProspectCommentEdit") as TextBox).Text;
            var prospectCommentType =Convert.ToInt32((row.FindControl("ddlProspectCommentTypeEdit") as DropDownList).SelectedValue);
            var prospectStage = Convert.ToInt32((row.FindControl("ddlProspectStageIDEdit") as DropDownList).SelectedValue);
            var commentSource = Convert.ToInt32((row.FindControl("ddlCommentSourcesEdit") as DropDownList).SelectedValue);
            var lastActivityDate2Edit = Convert.ToDateTime((row.FindControl("txtLastActivityDate2Edit") as TextBox).Text);
            var keyPhrase = (row.FindControl("txtKeyPhraseEdit") as TextBox).Text;

            using (var dataContext = new ProspectDataContext())
            {
                var conversation = dataContext.ProspectConversations.FirstOrDefault(p => p.ConversationId.Equals(conversationId));

                if (conversation != null)
                {
                    conversation.ProspectComment = prospectComment;
                    conversation.ProspectCommentTypeID = prospectCommentType;
                    conversation.ProspectStageID = prospectStage;
                    conversation.ProspectCommentSourceID = commentSource;
                    conversation.KeyPhrase = keyPhrase;
                    conversation.LastActivityDate = lastActivityDate2Edit;
                    conversation.CreatedByUserId = UserId;
                    

                    try
                    {
                        dataContext.SubmitChanges();
                    }
                    catch (DbEntityValidationException ex)
                    {
                        foreach (var eve in ex.EntityValidationErrors)
                        {
                            Console.WriteLine(
                                "Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                                eve.Entry.Entity.GetType().Name, eve.Entry.State);
                            foreach (var ve in eve.ValidationErrors)
                            {
                                Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                    ve.PropertyName, ve.ErrorMessage);
                            }
                        }
                    }
                }

            }
            gvComments.EditIndex = -1;
            BindListOfProspects(Convert.ToInt32(spanProspectId.InnerText));
            PopulateDropdownsProspectConversations();
        }

        protected void gvComments_OnRowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvComments.EditIndex = -1;
            BindListOfProspects(Convert.ToInt32(spanProspectId.InnerText));
            PopulateDropdownsProspectConversations();
        }

        protected void btnAddComments_OnClick(object sender, EventArgs e)
        {

            var txtProspectCommentAdd = (TextBox)gvComments.FooterRow.FindControl("txtProspectCommentAdd");
            var ddlProspectCommentTypeAdd = (DropDownList)gvComments.FooterRow.FindControl("ddlProspectCommentTypeAdd");
            var ddlProspectStageIdAdd = (DropDownList)gvComments.FooterRow.FindControl("ddlProspectStageIDAdd");
            var ddlCommentSourcesAdd = (DropDownList)gvComments.FooterRow.FindControl("ddlCommentSourcesAdd");
            var txtLastActivityDate2Add = (TextBox)gvComments.FooterRow.FindControl("txtLastActivityDate2Add");
            var txtKeyPhraseAdd = (TextBox)gvComments.FooterRow.FindControl("txtKeyPhraseAdd");
                            
            var dbContext = new ProspectDataContext();

            var dbProspectConversation = new ProspectConversation
            {
                ProspectId = Convert.ToInt32(spanProspectId.InnerText) ,
                ProspectComment = txtProspectCommentAdd.Text,
                ProspectCommentTypeID = Convert.ToInt32(ddlProspectCommentTypeAdd.SelectedValue),
                ProspectStageID = Convert.ToInt32(ddlProspectStageIdAdd.SelectedValue),
                ProspectCommentSourceID = Convert.ToInt32(ddlCommentSourcesAdd.SelectedValue),
                KeyPhrase = txtKeyPhraseAdd.Text,
                LastActivityDate = Convert.ToDateTime(txtLastActivityDate2Add.Text),
                CreatedByUserId = UserId
            };

            dbContext.ProspectConversations.InsertOnSubmit(dbProspectConversation);
            dbContext.SubmitChanges();

            BindListOfProspects(Convert.ToInt32(spanProspectId.InnerText));
            PopulateDropdownsProspectConversations();
            
        }

        private void PopulateDropdownsProspectConversations()
        {
            var dbContext = new ProspectDataContext();

            var ddlProspectCommentTypeAdd = (DropDownList)gvComments.FooterRow.FindControl("ddlProspectCommentTypeAdd");
            ddlProspectCommentTypeAdd.DataSource = dbContext.ProspectCommentTypes.ToList();
            ddlProspectCommentTypeAdd.DataTextField = "ProspectComment";
            ddlProspectCommentTypeAdd.DataValueField = "ProspectCommentTypeID";
            ddlProspectCommentTypeAdd.DataBind();

            ddlProspectCommentTypeAdd.Items.Insert(0, "Select");

            var ddlProspectStageIdAdd = (DropDownList)gvComments.FooterRow.FindControl("ddlProspectStageIDAdd");
            ddlProspectStageIdAdd.DataSource = dbContext.ProspectProspectStages.ToList();
            ddlProspectStageIdAdd.DataTextField = "ProspectStage";
            ddlProspectStageIdAdd.DataValueField = "ProspectStageID";
            ddlProspectStageIdAdd.DataBind();

            ddlProspectStageIdAdd.Items.Insert(0, "Select");


            var ddlCommentSourcesAdd = (DropDownList)gvComments.FooterRow.FindControl("ddlCommentSourcesAdd");
            ddlCommentSourcesAdd.DataSource = dbContext.ProspectCommentSources.ToList();
            ddlCommentSourcesAdd.DataTextField = "ProspectCommentSource1";
            ddlCommentSourcesAdd.DataValueField = "ProspectCommentSourceID";
            ddlCommentSourcesAdd.DataBind();

            ddlCommentSourcesAdd.Items.Insert(0, "Select");
        }

        protected void gvComments_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {

                var lblConversationId = (Label) e.Row.FindControl("lblConversationId");

                if (lblConversationId != null)
                {
                    
                    //Prospect Comment Div
                    var hidProspectComment = (HiddenField)e.Row.FindControl("hidProspectComment");

                    if (!string.IsNullOrEmpty(hidProspectComment.Value))
                    {
                        var hypProspectComment = (HyperLink)e.Row.FindControl("hypProspectComment");

                        if (hidProspectComment.Value.Length > 20)
                            hypProspectComment.Text = hidProspectComment.Value.Substring(0, 20);
                        else hypProspectComment.Text = hidProspectComment.Value;

                        var divProspectComment = (HtmlGenericControl)e.Row.FindControl("divProspectComment");
                        divProspectComment.InnerHtml = hidProspectComment.Value;

                        hypProspectComment.Attributes.Add("onclick",
                            "toggleDiv(" + divProspectComment.ClientID + "," + hypProspectComment.ClientID + ");");
                    }

                    //Key Phrase Div.
                    var hidKeyPhrase = (HiddenField)e.Row.FindControl("hidKeyPhrase");

                    if (!string.IsNullOrEmpty(hidKeyPhrase.Value))
                    {
                        var hypKeyPhrase = (HyperLink)e.Row.FindControl("hypKeyPhrase");
                         
                        if (hidKeyPhrase.Value.Length > 20)
                            hypKeyPhrase.Text = hidKeyPhrase.Value.Substring(0, 20);
                        else hypKeyPhrase.Text = hidKeyPhrase.Value;
                         
                        var divKeyPhrase = (HtmlGenericControl) e.Row.FindControl("divKeyPhrase");
                        divKeyPhrase.InnerHtml = hidKeyPhrase.Value;

                        hypKeyPhrase.Attributes.Add("onclick",
                            "toggleDiv(" + divKeyPhrase.ClientID + "," + hypKeyPhrase.ClientID + ");");
                    }

                }
                

                var dbContext = new ProspectDataContext();

                var lblCreatedBy = (Label)e.Row.FindControl("lblCreatedBy");

                if (lblCreatedBy != null && !string.IsNullOrEmpty(lblCreatedBy.Text))
                {
                    var userId = Guid.Parse(lblCreatedBy.Text);

                    var query = from c in dbContext.UserInfos
                                where c.UserId.Equals(userId)
                                select c.FirstName + " " + c.LastName;

                    lblCreatedBy.Text = query.First();
                }


                //CommentType
                var lblProspectCommentTypeId = (Label)e.Row.FindControl("lblProspectCommentTypeId");

                if (lblProspectCommentTypeId != null)
                {
                    var hidProspectCommentTypeId = (HiddenField) e.Row.FindControl("hidProspectCommentTypeId");
                    if (!string.IsNullOrEmpty(hidProspectCommentTypeId.Value))
                    {
                        var commentTypeid = Convert.ToInt32(hidProspectCommentTypeId.Value);

                        var prospectCommentType =
                            dbContext.ProspectCommentTypes.FirstOrDefault(
                                c => c.ProspectCommentTypeID.Equals(commentTypeid));

                        if (prospectCommentType != null)
                            lblProspectCommentTypeId.Text = prospectCommentType.ProspectComment;
                    }
                }

                //Prospect Stage
                var lblProspectStageId = (Label)e.Row.FindControl("lblProspectStageID");

                if (lblProspectStageId != null)
                {
                    var hidProspectStageId = (HiddenField) e.Row.FindControl("hidProspectStageID");
                    if (!string.IsNullOrEmpty(hidProspectStageId.Value))
                    {
                        var stageid = Convert.ToInt32(hidProspectStageId.Value);

                        var prospectStageType =
                            dbContext.ProspectProspectStages.FirstOrDefault(c => c.ProspectStageID.Equals(stageid));

                        if (prospectStageType != null)
                            lblProspectStageId.Text = prospectStageType.ProspectStage;
                    }
                }

                //Comment Source
                var lblCommentSources = (Label)e.Row.FindControl("lblCommentSources");

                if (lblCommentSources != null)
                {
                    var hidCommentSources = (HiddenField) e.Row.FindControl("hidCommentSources");
                    if (!string.IsNullOrEmpty(hidCommentSources.Value))
                    {
                        var commentSourceId = Convert.ToInt32(hidCommentSources.Value);

                        var commentSource =
                            dbContext.ProspectCommentSources.FirstOrDefault(
                                c => c.ProspectCommentSourceID.Equals(commentSourceId));

                        if (commentSource != null)
                            lblCommentSources.Text = commentSource.ProspectCommentSource1;
                    }
                }
                 
            }
        }

        protected void gvComments_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        #endregion Conversations...

        
    }
}