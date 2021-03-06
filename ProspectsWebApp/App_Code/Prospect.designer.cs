﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProspectsWebApp.App_Code
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ProspectDb")]
	public partial class ProspectDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertProspectCommentSource(ProspectCommentSource instance);
    partial void UpdateProspectCommentSource(ProspectCommentSource instance);
    partial void DeleteProspectCommentSource(ProspectCommentSource instance);
    partial void InsertProspectCommentType(ProspectCommentType instance);
    partial void UpdateProspectCommentType(ProspectCommentType instance);
    partial void DeleteProspectCommentType(ProspectCommentType instance);
    partial void InsertProspectConversation(ProspectConversation instance);
    partial void UpdateProspectConversation(ProspectConversation instance);
    partial void DeleteProspectConversation(ProspectConversation instance);
    partial void InsertProspectProspectStage(ProspectProspectStage instance);
    partial void UpdateProspectProspectStage(ProspectProspectStage instance);
    partial void DeleteProspectProspectStage(ProspectProspectStage instance);
    partial void InsertProspect(Prospect instance);
    partial void UpdateProspect(Prospect instance);
    partial void DeleteProspect(Prospect instance);
    #endregion
		
		public ProspectDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["ProspectDbConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ProspectDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProspectDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProspectDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProspectDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ProspectCommentSource> ProspectCommentSources
		{
			get
			{
				return this.GetTable<ProspectCommentSource>();
			}
		}
		
		public System.Data.Linq.Table<UserInfo> UserInfos
		{
			get
			{
				return this.GetTable<UserInfo>();
			}
		}
		
		public System.Data.Linq.Table<ProspectCommentType> ProspectCommentTypes
		{
			get
			{
				return this.GetTable<ProspectCommentType>();
			}
		}
		
		public System.Data.Linq.Table<ProspectConversation> ProspectConversations
		{
			get
			{
				return this.GetTable<ProspectConversation>();
			}
		}
		
		public System.Data.Linq.Table<ProspectProspectStage> ProspectProspectStages
		{
			get
			{
				return this.GetTable<ProspectProspectStage>();
			}
		}
		
		public System.Data.Linq.Table<Prospect> Prospects
		{
			get
			{
				return this.GetTable<Prospect>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ProspectCommentSources")]
	public partial class ProspectCommentSource : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ProspectCommentSourceID;
		
		private string _ProspectCommentSource1;
		
		private System.Nullable<System.DateTime> _LastActivityDate;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProspectCommentSourceIDChanging(int value);
    partial void OnProspectCommentSourceIDChanged();
    partial void OnProspectCommentSource1Changing(string value);
    partial void OnProspectCommentSource1Changed();
    partial void OnLastActivityDateChanging(System.Nullable<System.DateTime> value);
    partial void OnLastActivityDateChanged();
    #endregion
		
		public ProspectCommentSource()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProspectCommentSourceID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ProspectCommentSourceID
		{
			get
			{
				return this._ProspectCommentSourceID;
			}
			set
			{
				if ((this._ProspectCommentSourceID != value))
				{
					this.OnProspectCommentSourceIDChanging(value);
					this.SendPropertyChanging();
					this._ProspectCommentSourceID = value;
					this.SendPropertyChanged("ProspectCommentSourceID");
					this.OnProspectCommentSourceIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="ProspectCommentSource", Storage="_ProspectCommentSource1", DbType="NVarChar(50)")]
		public string ProspectCommentSource1
		{
			get
			{
				return this._ProspectCommentSource1;
			}
			set
			{
				if ((this._ProspectCommentSource1 != value))
				{
					this.OnProspectCommentSource1Changing(value);
					this.SendPropertyChanging();
					this._ProspectCommentSource1 = value;
					this.SendPropertyChanged("ProspectCommentSource1");
					this.OnProspectCommentSource1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastActivityDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> LastActivityDate
		{
			get
			{
				return this._LastActivityDate;
			}
			set
			{
				if ((this._LastActivityDate != value))
				{
					this.OnLastActivityDateChanging(value);
					this.SendPropertyChanging();
					this._LastActivityDate = value;
					this.SendPropertyChanged("LastActivityDate");
					this.OnLastActivityDateChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.UserInfo")]
	public partial class UserInfo
	{
		
		private int _UserNo;
		
		private System.Nullable<System.Guid> _UserId;
		
		private string _Email;
		
		private string _FirstName;
		
		private string _LastName;
		
		private string _CompanyName;
		
		private string _Address1;
		
		private string _Address2;
		
		private string _City;
		
		private string _State;
		
		private string _Zip;
		
		private string _Phone;
		
		private string _PhoneExt;
		
		private string _Fax;
		
		private string _RefCode;
		
		private string _RefferedFrom;
		
		private string _Industry;
		
		private string _PromoCode;
		
		private System.Nullable<System.DateTime> _CreateDate;
		
		private System.Nullable<System.DateTime> _AdEmailSentOn;
		
		private string _CustID;
		
		private string _Reseller;
		
		private string _MiddleInit;
		
		private string _Password;
		
		private string _AllowSecureFileUpload;
		
		private string _AllowACA;
		
		public UserInfo()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserNo", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int UserNo
		{
			get
			{
				return this._UserNo;
			}
			set
			{
				if ((this._UserNo != value))
				{
					this._UserNo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="UniqueIdentifier")]
		public System.Nullable<System.Guid> UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					this._UserId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(256)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this._Email = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="NVarChar(100)")]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this._FirstName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="NVarChar(100)")]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this._LastName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CompanyName", DbType="NVarChar(100)")]
		public string CompanyName
		{
			get
			{
				return this._CompanyName;
			}
			set
			{
				if ((this._CompanyName != value))
				{
					this._CompanyName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address1", DbType="NVarChar(100)")]
		public string Address1
		{
			get
			{
				return this._Address1;
			}
			set
			{
				if ((this._Address1 != value))
				{
					this._Address1 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address2", DbType="NVarChar(100)")]
		public string Address2
		{
			get
			{
				return this._Address2;
			}
			set
			{
				if ((this._Address2 != value))
				{
					this._Address2 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="NVarChar(60)")]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this._City = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_State", DbType="NVarChar(10)")]
		public string State
		{
			get
			{
				return this._State;
			}
			set
			{
				if ((this._State != value))
				{
					this._State = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Zip", DbType="NVarChar(10)")]
		public string Zip
		{
			get
			{
				return this._Zip;
			}
			set
			{
				if ((this._Zip != value))
				{
					this._Zip = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="NVarChar(20)")]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this._Phone = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneExt", DbType="NVarChar(10)")]
		public string PhoneExt
		{
			get
			{
				return this._PhoneExt;
			}
			set
			{
				if ((this._PhoneExt != value))
				{
					this._PhoneExt = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fax", DbType="NVarChar(20)")]
		public string Fax
		{
			get
			{
				return this._Fax;
			}
			set
			{
				if ((this._Fax != value))
				{
					this._Fax = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RefCode", DbType="NVarChar(50)")]
		public string RefCode
		{
			get
			{
				return this._RefCode;
			}
			set
			{
				if ((this._RefCode != value))
				{
					this._RefCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RefferedFrom", DbType="NChar(3)")]
		public string RefferedFrom
		{
			get
			{
				return this._RefferedFrom;
			}
			set
			{
				if ((this._RefferedFrom != value))
				{
					this._RefferedFrom = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Industry", DbType="NChar(3)")]
		public string Industry
		{
			get
			{
				return this._Industry;
			}
			set
			{
				if ((this._Industry != value))
				{
					this._Industry = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PromoCode", DbType="NChar(10)")]
		public string PromoCode
		{
			get
			{
				return this._PromoCode;
			}
			set
			{
				if ((this._PromoCode != value))
				{
					this._PromoCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreateDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreateDate
		{
			get
			{
				return this._CreateDate;
			}
			set
			{
				if ((this._CreateDate != value))
				{
					this._CreateDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AdEmailSentOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> AdEmailSentOn
		{
			get
			{
				return this._AdEmailSentOn;
			}
			set
			{
				if ((this._AdEmailSentOn != value))
				{
					this._AdEmailSentOn = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustID", DbType="NVarChar(5)")]
		public string CustID
		{
			get
			{
				return this._CustID;
			}
			set
			{
				if ((this._CustID != value))
				{
					this._CustID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Reseller", DbType="NVarChar(30)")]
		public string Reseller
		{
			get
			{
				return this._Reseller;
			}
			set
			{
				if ((this._Reseller != value))
				{
					this._Reseller = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MiddleInit", DbType="NVarChar(2)")]
		public string MiddleInit
		{
			get
			{
				return this._MiddleInit;
			}
			set
			{
				if ((this._MiddleInit != value))
				{
					this._MiddleInit = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(21)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this._Password = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AllowSecureFileUpload", DbType="VarChar(1)")]
		public string AllowSecureFileUpload
		{
			get
			{
				return this._AllowSecureFileUpload;
			}
			set
			{
				if ((this._AllowSecureFileUpload != value))
				{
					this._AllowSecureFileUpload = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AllowACA", DbType="VarChar(1)")]
		public string AllowACA
		{
			get
			{
				return this._AllowACA;
			}
			set
			{
				if ((this._AllowACA != value))
				{
					this._AllowACA = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ProspectCommentTypes")]
	public partial class ProspectCommentType : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ProspectCommentTypeID;
		
		private string _ProspectComment;
		
		private System.Nullable<System.DateTime> _LastActivityDate;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProspectCommentTypeIDChanging(int value);
    partial void OnProspectCommentTypeIDChanged();
    partial void OnProspectCommentChanging(string value);
    partial void OnProspectCommentChanged();
    partial void OnLastActivityDateChanging(System.Nullable<System.DateTime> value);
    partial void OnLastActivityDateChanged();
    #endregion
		
		public ProspectCommentType()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProspectCommentTypeID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ProspectCommentTypeID
		{
			get
			{
				return this._ProspectCommentTypeID;
			}
			set
			{
				if ((this._ProspectCommentTypeID != value))
				{
					this.OnProspectCommentTypeIDChanging(value);
					this.SendPropertyChanging();
					this._ProspectCommentTypeID = value;
					this.SendPropertyChanged("ProspectCommentTypeID");
					this.OnProspectCommentTypeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProspectComment", DbType="NVarChar(16)")]
		public string ProspectComment
		{
			get
			{
				return this._ProspectComment;
			}
			set
			{
				if ((this._ProspectComment != value))
				{
					this.OnProspectCommentChanging(value);
					this.SendPropertyChanging();
					this._ProspectComment = value;
					this.SendPropertyChanged("ProspectComment");
					this.OnProspectCommentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastActivityDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> LastActivityDate
		{
			get
			{
				return this._LastActivityDate;
			}
			set
			{
				if ((this._LastActivityDate != value))
				{
					this.OnLastActivityDateChanging(value);
					this.SendPropertyChanging();
					this._LastActivityDate = value;
					this.SendPropertyChanged("LastActivityDate");
					this.OnLastActivityDateChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ProspectConversations")]
	public partial class ProspectConversation : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ConversationId;
		
		private System.Nullable<int> _ProspectId;
		
		private string _ProspectComment;
		
		private System.Nullable<int> _ProspectCommentTypeID;
		
		private System.Nullable<int> _ProspectStageID;
		
		private System.Nullable<int> _ProspectCommentSourceID;
		
		private string _KeyPhrase;
		
		private System.Nullable<System.Guid> _CreatedByUserId;
		
		private System.Nullable<System.DateTime> _LastActivityDate;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnConversationIdChanging(int value);
    partial void OnConversationIdChanged();
    partial void OnProspectIdChanging(System.Nullable<int> value);
    partial void OnProspectIdChanged();
    partial void OnProspectCommentChanging(string value);
    partial void OnProspectCommentChanged();
    partial void OnProspectCommentTypeIDChanging(System.Nullable<int> value);
    partial void OnProspectCommentTypeIDChanged();
    partial void OnProspectStageIDChanging(System.Nullable<int> value);
    partial void OnProspectStageIDChanged();
    partial void OnProspectCommentSourceIDChanging(System.Nullable<int> value);
    partial void OnProspectCommentSourceIDChanged();
    partial void OnKeyPhraseChanging(string value);
    partial void OnKeyPhraseChanged();
    partial void OnCreatedByUserIdChanging(System.Nullable<System.Guid> value);
    partial void OnCreatedByUserIdChanged();
    partial void OnLastActivityDateChanging(System.Nullable<System.DateTime> value);
    partial void OnLastActivityDateChanged();
    #endregion
		
		public ProspectConversation()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ConversationId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ConversationId
		{
			get
			{
				return this._ConversationId;
			}
			set
			{
				if ((this._ConversationId != value))
				{
					this.OnConversationIdChanging(value);
					this.SendPropertyChanging();
					this._ConversationId = value;
					this.SendPropertyChanged("ConversationId");
					this.OnConversationIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProspectId", DbType="Int")]
		public System.Nullable<int> ProspectId
		{
			get
			{
				return this._ProspectId;
			}
			set
			{
				if ((this._ProspectId != value))
				{
					this.OnProspectIdChanging(value);
					this.SendPropertyChanging();
					this._ProspectId = value;
					this.SendPropertyChanged("ProspectId");
					this.OnProspectIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProspectComment", DbType="NVarChar(MAX)")]
		public string ProspectComment
		{
			get
			{
				return this._ProspectComment;
			}
			set
			{
				if ((this._ProspectComment != value))
				{
					this.OnProspectCommentChanging(value);
					this.SendPropertyChanging();
					this._ProspectComment = value;
					this.SendPropertyChanged("ProspectComment");
					this.OnProspectCommentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProspectCommentTypeID", DbType="Int")]
		public System.Nullable<int> ProspectCommentTypeID
		{
			get
			{
				return this._ProspectCommentTypeID;
			}
			set
			{
				if ((this._ProspectCommentTypeID != value))
				{
					this.OnProspectCommentTypeIDChanging(value);
					this.SendPropertyChanging();
					this._ProspectCommentTypeID = value;
					this.SendPropertyChanged("ProspectCommentTypeID");
					this.OnProspectCommentTypeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProspectStageID", DbType="Int")]
		public System.Nullable<int> ProspectStageID
		{
			get
			{
				return this._ProspectStageID;
			}
			set
			{
				if ((this._ProspectStageID != value))
				{
					this.OnProspectStageIDChanging(value);
					this.SendPropertyChanging();
					this._ProspectStageID = value;
					this.SendPropertyChanged("ProspectStageID");
					this.OnProspectStageIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProspectCommentSourceID", DbType="Int")]
		public System.Nullable<int> ProspectCommentSourceID
		{
			get
			{
				return this._ProspectCommentSourceID;
			}
			set
			{
				if ((this._ProspectCommentSourceID != value))
				{
					this.OnProspectCommentSourceIDChanging(value);
					this.SendPropertyChanging();
					this._ProspectCommentSourceID = value;
					this.SendPropertyChanged("ProspectCommentSourceID");
					this.OnProspectCommentSourceIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KeyPhrase", DbType="NVarChar(256)")]
		public string KeyPhrase
		{
			get
			{
				return this._KeyPhrase;
			}
			set
			{
				if ((this._KeyPhrase != value))
				{
					this.OnKeyPhraseChanging(value);
					this.SendPropertyChanging();
					this._KeyPhrase = value;
					this.SendPropertyChanged("KeyPhrase");
					this.OnKeyPhraseChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedByUserId", DbType="UniqueIdentifier")]
		public System.Nullable<System.Guid> CreatedByUserId
		{
			get
			{
				return this._CreatedByUserId;
			}
			set
			{
				if ((this._CreatedByUserId != value))
				{
					this.OnCreatedByUserIdChanging(value);
					this.SendPropertyChanging();
					this._CreatedByUserId = value;
					this.SendPropertyChanged("CreatedByUserId");
					this.OnCreatedByUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastActivityDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> LastActivityDate
		{
			get
			{
				return this._LastActivityDate;
			}
			set
			{
				if ((this._LastActivityDate != value))
				{
					this.OnLastActivityDateChanging(value);
					this.SendPropertyChanging();
					this._LastActivityDate = value;
					this.SendPropertyChanged("LastActivityDate");
					this.OnLastActivityDateChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ProspectProspectStages")]
	public partial class ProspectProspectStage : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ProspectStageID;
		
		private string _ProspectStage;
		
		private System.Nullable<int> _ProspectStageSequence;
		
		private System.Nullable<System.DateTime> _LastActivityDate;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProspectStageIDChanging(int value);
    partial void OnProspectStageIDChanged();
    partial void OnProspectStageChanging(string value);
    partial void OnProspectStageChanged();
    partial void OnProspectStageSequenceChanging(System.Nullable<int> value);
    partial void OnProspectStageSequenceChanged();
    partial void OnLastActivityDateChanging(System.Nullable<System.DateTime> value);
    partial void OnLastActivityDateChanged();
    #endregion
		
		public ProspectProspectStage()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProspectStageID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ProspectStageID
		{
			get
			{
				return this._ProspectStageID;
			}
			set
			{
				if ((this._ProspectStageID != value))
				{
					this.OnProspectStageIDChanging(value);
					this.SendPropertyChanging();
					this._ProspectStageID = value;
					this.SendPropertyChanged("ProspectStageID");
					this.OnProspectStageIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProspectStage", DbType="NVarChar(100)")]
		public string ProspectStage
		{
			get
			{
				return this._ProspectStage;
			}
			set
			{
				if ((this._ProspectStage != value))
				{
					this.OnProspectStageChanging(value);
					this.SendPropertyChanging();
					this._ProspectStage = value;
					this.SendPropertyChanged("ProspectStage");
					this.OnProspectStageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProspectStageSequence", DbType="Int")]
		public System.Nullable<int> ProspectStageSequence
		{
			get
			{
				return this._ProspectStageSequence;
			}
			set
			{
				if ((this._ProspectStageSequence != value))
				{
					this.OnProspectStageSequenceChanging(value);
					this.SendPropertyChanging();
					this._ProspectStageSequence = value;
					this.SendPropertyChanged("ProspectStageSequence");
					this.OnProspectStageSequenceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastActivityDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> LastActivityDate
		{
			get
			{
				return this._LastActivityDate;
			}
			set
			{
				if ((this._LastActivityDate != value))
				{
					this.OnLastActivityDateChanging(value);
					this.SendPropertyChanging();
					this._LastActivityDate = value;
					this.SendPropertyChanged("LastActivityDate");
					this.OnLastActivityDateChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Prospects")]
	public partial class Prospect : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ProspectId;
		
		private string _Company;
		
		private string _ContactName;
		
		private string _ContactEmail;
		
		private string _ContactPhone;
		
		private string _ContactCity;
		
		private string _ContactState;
		
		private string _ContactTimeZone;
		
		private System.Nullable<System.Guid> _CreatedByUserId;
		
		private System.Nullable<System.DateTime> _LastActivityDate;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProspectIdChanging(int value);
    partial void OnProspectIdChanged();
    partial void OnCompanyChanging(string value);
    partial void OnCompanyChanged();
    partial void OnContactNameChanging(string value);
    partial void OnContactNameChanged();
    partial void OnContactEmailChanging(string value);
    partial void OnContactEmailChanged();
    partial void OnContactPhoneChanging(string value);
    partial void OnContactPhoneChanged();
    partial void OnContactCityChanging(string value);
    partial void OnContactCityChanged();
    partial void OnContactStateChanging(string value);
    partial void OnContactStateChanged();
    partial void OnContactTimeZoneChanging(string value);
    partial void OnContactTimeZoneChanged();
    partial void OnCreatedByUserIdChanging(System.Nullable<System.Guid> value);
    partial void OnCreatedByUserIdChanged();
    partial void OnLastActivityDateChanging(System.Nullable<System.DateTime> value);
    partial void OnLastActivityDateChanged();
    #endregion
		
		public Prospect()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProspectId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ProspectId
		{
			get
			{
				return this._ProspectId;
			}
			set
			{
				if ((this._ProspectId != value))
				{
					this.OnProspectIdChanging(value);
					this.SendPropertyChanging();
					this._ProspectId = value;
					this.SendPropertyChanged("ProspectId");
					this.OnProspectIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Company", DbType="NVarChar(256)")]
		public string Company
		{
			get
			{
				return this._Company;
			}
			set
			{
				if ((this._Company != value))
				{
					this.OnCompanyChanging(value);
					this.SendPropertyChanging();
					this._Company = value;
					this.SendPropertyChanged("Company");
					this.OnCompanyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContactName", DbType="NVarChar(256)")]
		public string ContactName
		{
			get
			{
				return this._ContactName;
			}
			set
			{
				if ((this._ContactName != value))
				{
					this.OnContactNameChanging(value);
					this.SendPropertyChanging();
					this._ContactName = value;
					this.SendPropertyChanged("ContactName");
					this.OnContactNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContactEmail", DbType="NVarChar(256)")]
		public string ContactEmail
		{
			get
			{
				return this._ContactEmail;
			}
			set
			{
				if ((this._ContactEmail != value))
				{
					this.OnContactEmailChanging(value);
					this.SendPropertyChanging();
					this._ContactEmail = value;
					this.SendPropertyChanged("ContactEmail");
					this.OnContactEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContactPhone", DbType="NVarChar(16)")]
		public string ContactPhone
		{
			get
			{
				return this._ContactPhone;
			}
			set
			{
				if ((this._ContactPhone != value))
				{
					this.OnContactPhoneChanging(value);
					this.SendPropertyChanging();
					this._ContactPhone = value;
					this.SendPropertyChanged("ContactPhone");
					this.OnContactPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContactCity", DbType="NVarChar(50)")]
		public string ContactCity
		{
			get
			{
				return this._ContactCity;
			}
			set
			{
				if ((this._ContactCity != value))
				{
					this.OnContactCityChanging(value);
					this.SendPropertyChanging();
					this._ContactCity = value;
					this.SendPropertyChanged("ContactCity");
					this.OnContactCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContactState", DbType="NVarChar(2)")]
		public string ContactState
		{
			get
			{
				return this._ContactState;
			}
			set
			{
				if ((this._ContactState != value))
				{
					this.OnContactStateChanging(value);
					this.SendPropertyChanging();
					this._ContactState = value;
					this.SendPropertyChanged("ContactState");
					this.OnContactStateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContactTimeZone", DbType="NVarChar(50)")]
		public string ContactTimeZone
		{
			get
			{
				return this._ContactTimeZone;
			}
			set
			{
				if ((this._ContactTimeZone != value))
				{
					this.OnContactTimeZoneChanging(value);
					this.SendPropertyChanging();
					this._ContactTimeZone = value;
					this.SendPropertyChanged("ContactTimeZone");
					this.OnContactTimeZoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedByUserId", DbType="UniqueIdentifier")]
		public System.Nullable<System.Guid> CreatedByUserId
		{
			get
			{
				return this._CreatedByUserId;
			}
			set
			{
				if ((this._CreatedByUserId != value))
				{
					this.OnCreatedByUserIdChanging(value);
					this.SendPropertyChanging();
					this._CreatedByUserId = value;
					this.SendPropertyChanged("CreatedByUserId");
					this.OnCreatedByUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastActivityDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> LastActivityDate
		{
			get
			{
				return this._LastActivityDate;
			}
			set
			{
				if ((this._LastActivityDate != value))
				{
					this.OnLastActivityDateChanging(value);
					this.SendPropertyChanging();
					this._LastActivityDate = value;
					this.SendPropertyChanged("LastActivityDate");
					this.OnLastActivityDateChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
