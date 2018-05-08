// <auto-generated />

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;

namespace Plugins.ProxyClasses
{
    [ExcludeFromCodeCoverage]
    [EntityLogicalName("ccc_eventasset")]
    [GeneratedCode("XrmToolkit", "4.0")]
    [DataContract(Name = "Entity", Namespace = "http://schemas.microsoft.com/xrm/2011/Contracts")]
    public class EventAsset : BaseProxyClass
    {
        public enum eStatus
        {
            /// <summary>
            ///     <para>Active</para>
            ///     <para>Value = 0</para>
            /// </summary>
            [Description("Active")] Active = 0,

            /// <summary>
            ///     <para>Inactive</para>
            ///     <para>Value = 1</para>
            /// </summary>
            [Description("Inactive")] Inactive = 1
        }

        public enum eStatusReason
        {
            /// <summary>
            ///     <para>Active</para>
            ///     <para>Value = 1</para>
            /// </summary>
            [Description("Active")] Active_Active = 1,

            /// <summary>
            ///     <para>Inactive</para>
            ///     <para>Value = 2</para>
            /// </summary>
            [Description("Inactive")] Inactive_Inactive = 2
        }

        public new const string LogicalName = "ccc_eventasset";
        public const int ObjectTypeCode = 10008;
        public const string PrimaryIdAttribute = "ccc_eventassetid";
        public const string PrimaryNameAttribute = "ccc_name";
        private static readonly Dictionary<string, eTextOptions> _textOptions;
        private static readonly Dictionary<string, eNumberOptions> _numberOptions;
        private static readonly Dictionary<string, string> _errorStrings;

        static EventAsset()
        {
            RegisterProxyType(typeof(EventAsset), "ccc_eventasset");
            _textOptions = new Dictionary<string, eTextOptions>();
            _numberOptions = new Dictionary<string, eNumberOptions>();
            _errorStrings = new Dictionary<string, string>();
            TextError =
                "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
            NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
        }

        public EventAsset() : base(new Entity("ccc_eventasset"))
        {
        }

        public EventAsset(Entity original) : base(original)
        {
        }

        /// <summary>
        ///     Action to perform when the string value is greater than the allowed length.
        ///     <para>This is the default for any string attribute in this Entity</para>
        /// </summary>
        public static eTextOptions TextOptions { get; set; }

        /// <summary>
        ///     Action to perform when the number value is greater or less than the allowed value.
        ///     <para>This is the default for any int, decimal, double, or money attribute in this Entity</para>
        /// </summary>
        public static eNumberOptions NumberOptions { get; set; }

        /// <summary>
        ///     <para>
        ///         Default error string is: The value for attribute '{0}' cannot be longer than {3} characters. The length of
        ///         the value is {2} characters.
        ///     </para>
        ///     <para>You may use the following parameters</para>
        ///     <para>{0} = Attribute Name</para>
        ///     <para>{1} = Value</para>
        ///     <para>{2} = Length</para>
        ///     <para>{3} = Max Length</para>
        /// </summary>
        public static string TextError { get; set; }

        /// <summary>
        ///     <para>Default error string is: The value for attribute '{0}' must be between {2} and {3}. The value is {1}.</para>
        ///     <para>You may use the following parameters</para>
        ///     <para>{0} = Attribute Name</para>
        ///     <para>{1} = Value</para>
        ///     <para>{2} = Min Value</para>
        ///     <para>{3} = Max Value</para>
        /// </summary>
        public static string NumberError { get; set; }

        /// <summary>
        ///     <para>Logical Name: createdonbehalfbyyominame</para>
        ///     <para>Max Length: 100 characters</para>
        /// </summary>
        [AttributeLogicalName("createdonbehalfbyyominame")]
        public string CreatedOnBehalfByYomiName => GetPropertyValue<string>("createdonbehalfbyyominame");

        /// <summary>
        ///     <para>Logical Name: owneridname</para>
        ///     <para>Max Length: 100 characters</para>
        /// </summary>
        [AttributeLogicalName("owneridname")]
        public string OwnerIdName => GetPropertyValue<string>("owneridname");

        /// <summary>
        ///     <para>Logical Name: modifiedbyyominame</para>
        ///     <para>Max Length: 100 characters</para>
        /// </summary>
        [AttributeLogicalName("modifiedbyyominame")]
        public string ModifiedByYomiName => GetPropertyValue<string>("modifiedbyyominame");

        /// <summary>
        ///     <para>Logical Name: createdbyyominame</para>
        ///     <para>Max Length: 100 characters</para>
        /// </summary>
        [AttributeLogicalName("createdbyyominame")]
        public string CreatedByYomiName => GetPropertyValue<string>("createdbyyominame");

        /// <summary>
        ///     <para>Logical Name: modifiedbyname</para>
        ///     <para>Max Length: 100 characters</para>
        /// </summary>
        [AttributeLogicalName("modifiedbyname")]
        public string ModifiedByName => GetPropertyValue<string>("modifiedbyname");

        /// <summary>
        ///     <para>Logical Name: owneridtype</para>
        /// </summary>
        [AttributeLogicalName("owneridtype")]
        public string OwnerIdType
        {
            get => GetPropertyValue<string>("owneridtype");
            set => SetPropertyValue("owneridtype", value, "OwnerIdType");
        }

        /// <summary>
        ///     <para>Logical Name: owneridyominame</para>
        ///     <para>Max Length: 100 characters</para>
        /// </summary>
        [AttributeLogicalName("owneridyominame")]
        public string OwnerIdYomiName => GetPropertyValue<string>("owneridyominame");

        /// <summary>
        ///     <para>Logical Name: modifiedonbehalfbyyominame</para>
        ///     <para>Max Length: 100 characters</para>
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfbyyominame")]
        public string ModifiedOnBehalfByYomiName => GetPropertyValue<string>("modifiedonbehalfbyyominame");

        /// <summary>
        ///     <para>Logical Name: createdbyname</para>
        ///     <para>Max Length: 100 characters</para>
        /// </summary>
        [AttributeLogicalName("createdbyname")]
        public string CreatedByName => GetPropertyValue<string>("createdbyname");

        /// <summary>
        ///     <para>Logical Name: createdonbehalfbyname</para>
        ///     <para>Max Length: 100 characters</para>
        /// </summary>
        [AttributeLogicalName("createdonbehalfbyname")]
        public string CreatedOnBehalfByName => GetPropertyValue<string>("createdonbehalfbyname");

        /// <summary>
        ///     <para>Logical Name: modifiedonbehalfbyname</para>
        ///     <para>Max Length: 100 characters</para>
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfbyname")]
        public string ModifiedOnBehalfByName => GetPropertyValue<string>("modifiedonbehalfbyname");

        /// <summary>
        ///     <para>Logical Name: createdby</para>
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy => GetPropertyValue<EntityReference>("createdby");

        /// <summary>
        ///     <para>Logical Name: createdonbehalfby</para>
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedBy_Delegate => GetPropertyValue<EntityReference>("createdonbehalfby");

        /// <summary>
        ///     <para>Logical Name: createdon</para>
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn => GetPropertyValue<DateTime?>("createdon");

        /// <summary>
        ///     <para>Key Property (Uniqueidentifier)</para>
        ///     <para>Logical Name: ccc_eventassetid</para>
        /// </summary>
        [AttributeLogicalName("ccc_eventassetid")]
        public Guid EventAssetId
        {
            get => Id;
            set
            {
                Id = value;
                SetPropertyValue("ccc_eventassetid", value, "EventAssetId");
            }
        }

        /// <summary>
        ///     <para>Logical Name: importsequencenumber</para>
        ///     <para>Minimum Value: -2147483648</para>
        ///     <para>Maximum Value: 2147483647</para>
        /// </summary>
        [AttributeLogicalName("importsequencenumber")]
        public int? ImportSequenceNumber
        {
            get => GetPropertyValue<int?>("importsequencenumber");
            set => SetPropertyValue("importsequencenumber", value, -2147483648, 2147483647, "ImportSequenceNumber");
        }

        /// <summary>
        ///     <para>Logical Name: modifiedby</para>
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy => GetPropertyValue<EntityReference>("modifiedby");

        /// <summary>
        ///     <para>Logical Name: modifiedonbehalfby</para>
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedBy_Delegate => GetPropertyValue<EntityReference>("modifiedonbehalfby");

        /// <summary>
        ///     <para>Logical Name: modifiedon</para>
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn => GetPropertyValue<DateTime?>("modifiedon");

        /// <summary>
        ///     <para>Logical Name: ccc_name</para>
        ///     <para>Max Length: 100 characters</para>
        /// </summary>
        [AttributeLogicalName("ccc_name")]
        public string Name
        {
            get => GetPropertyValue<string>("ccc_name");
            set => SetPropertyValue("ccc_name", value, 100, "Name");
        }

        /// <summary>
        ///     <para>Logical Name: ownerid</para>
        /// </summary>
        [AttributeLogicalName("ownerid")]
        public EntityReference Owner
        {
            get => GetPropertyValue<EntityReference>("ownerid");
            set => SetPropertyValue("ownerid", value, "Owner");
        }

        /// <summary>
        ///     <para>Logical Name: owningbusinessunit</para>
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit => GetPropertyValue<EntityReference>("owningbusinessunit");

        /// <summary>
        ///     <para>Logical Name: owningteam</para>
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam => GetPropertyValue<EntityReference>("owningteam");

        /// <summary>
        ///     <para>Logical Name: owninguser</para>
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser => GetPropertyValue<EntityReference>("owninguser");

        /// <summary>
        ///     <para>Logical Name: overriddencreatedon</para>
        /// </summary>
        [AttributeLogicalName("overriddencreatedon")]
        public DateTime? RecordCreatedOn
        {
            get => GetPropertyValue<DateTime?>("overriddencreatedon");
            set => SetPropertyValue("overriddencreatedon", value, "RecordCreatedOn");
        }

        /// <summary>
        ///     Logical Name: statecode
        /// </summary>
        [AttributeLogicalName("statecode")]
        public eStatus? Status
        {
            get
            {
                if (Status_OptionSetValue != null) return (eStatus) Status_OptionSetValue.Value;
                return null;
            }
            set
            {
                if (value != null) Status_OptionSetValue = new OptionSetValue((int) value);
                else Status_OptionSetValue = null;
            }
        }

        /// <summary>
        ///     <para>Logical Name: statecode</para>
        /// </summary>
        [AttributeLogicalName("statecode")]
        public OptionSetValue Status_OptionSetValue
        {
            get => GetPropertyValue<OptionSetValue>("statecode");
            set => SetPropertyValue("statecode", value, "Status_OptionSetValue");
        }

        /// <summary>
        ///     Logical Name: statuscode
        /// </summary>
        [AttributeLogicalName("statuscode")]
        public eStatusReason? StatusReason
        {
            get
            {
                if (StatusReason_OptionSetValue != null) return (eStatusReason) StatusReason_OptionSetValue.Value;
                return null;
            }
            set
            {
                if (value != null) StatusReason_OptionSetValue = new OptionSetValue((int) value);
                else StatusReason_OptionSetValue = null;
            }
        }

        /// <summary>
        ///     <para>Logical Name: statuscode</para>
        /// </summary>
        [AttributeLogicalName("statuscode")]
        public OptionSetValue StatusReason_OptionSetValue
        {
            get => GetPropertyValue<OptionSetValue>("statuscode");
            set => SetPropertyValue("statuscode", value, "StatusReason_OptionSetValue");
        }

        /// <summary>
        ///     <para>Logical Name: timezoneruleversionnumber</para>
        ///     <para>Minimum Value: -1</para>
        ///     <para>Maximum Value: 2147483647</para>
        /// </summary>
        [AttributeLogicalName("timezoneruleversionnumber")]
        public int? TimeZoneRuleVersionNumber
        {
            get => GetPropertyValue<int?>("timezoneruleversionnumber");
            set => SetPropertyValue("timezoneruleversionnumber", value, -1, 2147483647, "TimeZoneRuleVersionNumber");
        }

        /// <summary>
        ///     <para>Logical Name: utcconversiontimezonecode</para>
        ///     <para>Minimum Value: -1</para>
        ///     <para>Maximum Value: 2147483647</para>
        /// </summary>
        [AttributeLogicalName("utcconversiontimezonecode")]
        public int? UTCConversionTimeZoneCode
        {
            get => GetPropertyValue<int?>("utcconversiontimezonecode");
            set => SetPropertyValue("utcconversiontimezonecode", value, -1, 2147483647, "UTCConversionTimeZoneCode");
        }

        /// <summary>
        ///     <para>Logical Name: versionnumber</para>
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public int? VersionNumber => GetPropertyValue<int?>("versionnumber");

        public static string GetLogicalName()
        {
            return GetLogicalName<EventAsset>();
        }

        /// <summary>
        ///     Use this to set an action and error string when a value is greater than the allowed length
        /// </summary>
        /// <param name="logicalName">Name of Attribute</param>
        /// <param name="options">Action to perform when the value is greater than the allowed length</param>
        /// <param name="errorString">
        ///     Optional: Error to throw if the eTextOptions == ThrowError
        ///     <para>If nothing is specified then the 'TextError' string is used.</para>
        ///     <para>You may use the following parameters:</para>
        ///     <para>{0} = Attribute Logical Name</para>
        ///     <para>{1} = Value</para>
        ///     <para>{2} = Length</para>
        ///     <para>{3} = Max Length</para>
        /// </param>
        public static void SetTextOptions(string logicalName, eTextOptions options, string errorString = null)
        {
            if (_textOptions.ContainsKey(logicalName)) _textOptions[logicalName] = options;
            else _textOptions.Add(logicalName, options);
            if (!string.IsNullOrEmpty(errorString))
                if (_errorStrings.ContainsKey(logicalName)) _errorStrings[logicalName] = errorString;
                else _errorStrings.Add(logicalName, errorString);
            else if (_errorStrings.ContainsKey(logicalName)) _errorStrings.Remove(logicalName);
        }

        protected override eTextOptions GetTextOptions(string logicalName)
        {
            if (_textOptions.ContainsKey(logicalName)) return _textOptions[logicalName];
            return TextOptions;
        }

        /// <summary>
        ///     Use this to set an action and error string when a value is greater or less than the allowed value
        /// </summary>
        /// <param name="logicalName">Name of Attribute</param>
        /// <param name="options">Action to perform when the value is greater or less than the allowed value</param>
        /// <param name="errorString">
        ///     Optional: Error to throw if the eNumberOptions == ThrowError
        ///     <para>If nothing is specified then the 'NumberError' string is used.</para>
        ///     <para>You may use the following parameters:</para>
        ///     <para>{0} = Attribute Logical Name</para>
        ///     <para>{1} = Value</para>
        ///     <para>{2} = Min Value</para>
        ///     <para>{3} = Max Value</para>
        /// </param>
        public static void SetNumberOptions(string logicalName, eNumberOptions options, string errorString = null)
        {
            if (_numberOptions.ContainsKey(logicalName)) _numberOptions[logicalName] = options;
            else _numberOptions.Add(logicalName, options);
            if (!string.IsNullOrEmpty(errorString))
                if (_errorStrings.ContainsKey(logicalName)) _errorStrings[logicalName] = errorString;
                else _errorStrings.Add(logicalName, errorString);
            else if (_errorStrings.ContainsKey(logicalName)) _errorStrings.Remove(logicalName);
        }

        protected override eNumberOptions GetNumberOptions(string logicalName)
        {
            if (_numberOptions.ContainsKey(logicalName)) return _numberOptions[logicalName];
            return NumberOptions;
        }

        protected override string GetErrorString(string attributeName, eErrorType defaultErrorType)
        {
            if (_errorStrings.ContainsKey(attributeName))
                return _errorStrings[attributeName];
            return defaultErrorType == eErrorType.Text ? TextError : NumberError;
        }

        /// <summary>
        ///     Retrieves the current value's text in the user's language.
        /// </summary>
        /// <param name="Service">CRM Organization Service</param>
        /// <returns></returns>
        public string Status_Text(IOrganizationService Service)
        {
            return Status_OptionSetValue.GetOptionSetText(Service, this, "statecode");
        }

        /// <summary>
        ///     Retrieves the current value's text in the user's language.
        /// </summary>
        /// <param name="AttributeMetadata">
        ///     The attribute metadata previously retrieved using the 'GetAttributeMetadata' extension
        ///     method on the IOrganizationService object.
        /// </param>
        /// <returns></returns>
        public string Status_Text(EnumAttributeMetadata AttributeMetadata)
        {
            return AttributeMetadata.GetOptionSetText(Status_OptionSetValue.Value);
        }

        /// <summary>
        ///     Retrieves the current value's text in the user's language.
        /// </summary>
        /// <param name="Service">CRM Organization Service</param>
        /// <returns></returns>
        public string StatusReason_Text(IOrganizationService Service)
        {
            return StatusReason_OptionSetValue.GetOptionSetText(Service, this, "statuscode");
        }

        /// <summary>
        ///     Retrieves the current value's text in the user's language.
        /// </summary>
        /// <param name="AttributeMetadata">
        ///     The attribute metadata previously retrieved using the 'GetAttributeMetadata' extension
        ///     method on the IOrganizationService object.
        /// </param>
        /// <returns></returns>
        public string StatusReason_Text(EnumAttributeMetadata AttributeMetadata)
        {
            return AttributeMetadata.GetOptionSetText(StatusReason_OptionSetValue.Value);
        }


        /// <summary>
        ///     <para>
        ///         <b>Entity ()</b>
        ///     </para>
        ///     <para>Schema Name: ccc_eventasset_AsyncOperations</para>
        /// </summary>
        public List<Entity> GetSystemJobs(IOrganizationService Service, params string[] Columns)
        {
            return GetRelatedOneToManyEntities(Service, Id, "asyncoperation", "regardingobjectid", Columns);
        }

        /// <summary>
        ///     <para>
        ///         <b>Entity ()</b>
        ///     </para>
        ///     <para>Schema Name: ccc_eventasset_AsyncOperations</para>
        /// </summary>
        public List<Entity> GetSystemJobs(IOrganizationService Service, ColumnSet Columns)
        {
            return GetRelatedOneToManyEntities(Service, Id, "asyncoperation", "regardingobjectid", Columns);
        }

        /// <summary>
        ///     <para>
        ///         <b>Entity ()</b>
        ///     </para>
        ///     <para>Schema Name: ccc_eventasset_BulkDeleteFailures</para>
        /// </summary>
        public List<Entity> GetBulkDeleteFailures(IOrganizationService Service, params string[] Columns)
        {
            return GetRelatedOneToManyEntities(Service, Id, "bulkdeletefailure", "regardingobjectid", Columns);
        }

        /// <summary>
        ///     <para>
        ///         <b>Entity ()</b>
        ///     </para>
        ///     <para>Schema Name: ccc_eventasset_BulkDeleteFailures</para>
        /// </summary>
        public List<Entity> GetBulkDeleteFailures(IOrganizationService Service, ColumnSet Columns)
        {
            return GetRelatedOneToManyEntities(Service, Id, "bulkdeletefailure", "regardingobjectid", Columns);
        }

        /// <summary>
        ///     <para>
        ///         <b>Entity ()</b>
        ///     </para>
        ///     <para>Schema Name: ccc_eventasset_MailboxTrackingFolders</para>
        /// </summary>
        public List<Entity> GetMailboxAutoTrackingFolders(IOrganizationService Service, params string[] Columns)
        {
            return GetRelatedOneToManyEntities(Service, Id, "mailboxtrackingfolder", "regardingobjectid", Columns);
        }

        /// <summary>
        ///     <para>
        ///         <b>Entity ()</b>
        ///     </para>
        ///     <para>Schema Name: ccc_eventasset_MailboxTrackingFolders</para>
        /// </summary>
        public List<Entity> GetMailboxAutoTrackingFolders(IOrganizationService Service, ColumnSet Columns)
        {
            return GetRelatedOneToManyEntities(Service, Id, "mailboxtrackingfolder", "regardingobjectid", Columns);
        }

        /// <summary>
        ///     <para>
        ///         <b>Entity ()</b>
        ///     </para>
        ///     <para>Schema Name: ccc_eventasset_PrincipalObjectAttributeAccesses</para>
        /// </summary>
        public List<Entity> GetFieldSharing(IOrganizationService Service, params string[] Columns)
        {
            return GetRelatedOneToManyEntities(Service, Id, "principalobjectattributeaccess", "objectid", Columns);
        }

        /// <summary>
        ///     <para>
        ///         <b>Entity ()</b>
        ///     </para>
        ///     <para>Schema Name: ccc_eventasset_PrincipalObjectAttributeAccesses</para>
        /// </summary>
        public List<Entity> GetFieldSharing(IOrganizationService Service, ColumnSet Columns)
        {
            return GetRelatedOneToManyEntities(Service, Id, "principalobjectattributeaccess", "objectid", Columns);
        }

        /// <summary>
        ///     <para>
        ///         <b>Entity ()</b>
        ///     </para>
        ///     <para>Schema Name: ccc_eventasset_ProcessSession</para>
        /// </summary>
        public List<Entity> GetProcessSessions(IOrganizationService Service, params string[] Columns)
        {
            return GetRelatedOneToManyEntities(Service, Id, "processsession", "regardingobjectid", Columns);
        }

        /// <summary>
        ///     <para>
        ///         <b>Entity ()</b>
        ///     </para>
        ///     <para>Schema Name: ccc_eventasset_ProcessSession</para>
        /// </summary>
        public List<Entity> GetProcessSessions(IOrganizationService Service, ColumnSet Columns)
        {
            return GetRelatedOneToManyEntities(Service, Id, "processsession", "regardingobjectid", Columns);
        }

        /// <summary>
        ///     <para>
        ///         <b>Entity ()</b>
        ///     </para>
        ///     <para>Schema Name: ccc_eventasset_SyncErrors</para>
        /// </summary>
        public List<Entity> GetSyncErrors(IOrganizationService Service, params string[] Columns)
        {
            return GetRelatedOneToManyEntities(Service, Id, "syncerror", "regardingobjectid", Columns);
        }

        /// <summary>
        ///     <para>
        ///         <b>Entity ()</b>
        ///     </para>
        ///     <para>Schema Name: ccc_eventasset_SyncErrors</para>
        /// </summary>
        public List<Entity> GetSyncErrors(IOrganizationService Service, ColumnSet Columns)
        {
            return GetRelatedOneToManyEntities(Service, Id, "syncerror", "regardingobjectid", Columns);
        }

        /// <summary>
        ///     <para>
        ///         <b>Entity ()</b>
        ///     </para>
        ///     <para>Schema Name: ccc_eventasset_UserEntityInstanceDatas</para>
        /// </summary>
        public List<Entity> GetUserEntityInstanceData(IOrganizationService Service, params string[] Columns)
        {
            return GetRelatedOneToManyEntities(Service, Id, "userentityinstancedata", "objectid", Columns);
        }

        /// <summary>
        ///     <para>
        ///         <b>Entity ()</b>
        ///     </para>
        ///     <para>Schema Name: ccc_eventasset_UserEntityInstanceDatas</para>
        /// </summary>
        public List<Entity> GetUserEntityInstanceData(IOrganizationService Service, ColumnSet Columns)
        {
            return GetRelatedOneToManyEntities(Service, Id, "userentityinstancedata", "objectid", Columns);
        }


        /// <summary>
        ///     <para>Related Entity: <b>Event</b></para>
        ///     <para>N:N Relationship</para>
        ///     <para>Schema Name: ccc_ccc_event_ccc_eventasset</para>
        /// </summary>
        public List<Event> GetEvents(IOrganizationService Service, params string[] Columns)
        {
            return GetRelatedManyToManyEntities<Event>(Service, this, "ccc_eventasset", "ccc_eventassetid", "ccc_event",
                "ccc_eventid", "ccc_ccc_event_ccc_eventasset", "ccc_eventassetid", "ccc_eventid", Columns);
        }

        public List<Event> GetEvents(IOrganizationService Service, ColumnSet Columns)
        {
            return GetRelatedManyToManyEntities<Event>(Service, this, "ccc_eventasset", "ccc_eventassetid", "ccc_event",
                "ccc_eventid", "ccc_ccc_event_ccc_eventasset", "ccc_eventassetid", "ccc_eventid", Columns);
        }

        public void RelateEvents(IOrganizationService Service, params Entity[] Items)
        {
            Service.RelateEntities(this, "ccc_ccc_event_ccc_eventasset", Items);
        }

        public void RelateEvents(IOrganizationService Service, params EntityReference[] Items)
        {
            Service.RelateEntities(this, "ccc_ccc_event_ccc_eventasset", Items);
        }

        public void UnRelateEvents(IOrganizationService Service, params Entity[] Items)
        {
            Service.UnRelateEntities(this, "ccc_ccc_event_ccc_eventasset", Items);
        }

        public void UnRelateEvents(IOrganizationService Service, params EntityReference[] Items)
        {
            Service.UnRelateEntities(this, "ccc_ccc_event_ccc_eventasset", Items);
        }

        public void SetState(IOrganizationService Service, eStatus State, eStatusReason Status)
        {
            Service.SetState(this, (int) State, (int) Status);
        }

        public async Task SetStateAsync(IOrganizationService Service, eStatus State, eStatusReason Status)
        {
            await Service.SetStateAsync(this, (int) State, (int) Status);
        }


        public static class Properties
        {
            /// <summary>
            ///     <para>createdonbehalfbyyominame</para>
            ///     <para>createdonbehalfbyyominame</para>
            /// </summary>
            public const string CreatedOnBehalfByYomiName = "createdonbehalfbyyominame";

            /// <summary>
            ///     <para>owneridname</para>
            ///     <para>owneridname</para>
            /// </summary>
            public const string OwnerIdName = "owneridname";

            /// <summary>
            ///     <para>modifiedbyyominame</para>
            ///     <para>modifiedbyyominame</para>
            /// </summary>
            public const string ModifiedByYomiName = "modifiedbyyominame";

            /// <summary>
            ///     <para>createdbyyominame</para>
            ///     <para>createdbyyominame</para>
            /// </summary>
            public const string CreatedByYomiName = "createdbyyominame";

            /// <summary>
            ///     <para>modifiedbyname</para>
            ///     <para>modifiedbyname</para>
            /// </summary>
            public const string ModifiedByName = "modifiedbyname";

            /// <summary>
            ///     <para>owneridtype</para>
            ///     <para>owneridtype</para>
            /// </summary>
            public const string OwnerIdType = "owneridtype";

            /// <summary>
            ///     <para>owneridyominame</para>
            ///     <para>owneridyominame</para>
            /// </summary>
            public const string OwnerIdYomiName = "owneridyominame";

            /// <summary>
            ///     <para>modifiedonbehalfbyyominame</para>
            ///     <para>modifiedonbehalfbyyominame</para>
            /// </summary>
            public const string ModifiedOnBehalfByYomiName = "modifiedonbehalfbyyominame";

            /// <summary>
            ///     <para>createdbyname</para>
            ///     <para>createdbyname</para>
            /// </summary>
            public const string CreatedByName = "createdbyname";

            /// <summary>
            ///     <para>createdonbehalfbyname</para>
            ///     <para>createdonbehalfbyname</para>
            /// </summary>
            public const string CreatedOnBehalfByName = "createdonbehalfbyname";

            /// <summary>
            ///     <para>modifiedonbehalfbyname</para>
            ///     <para>modifiedonbehalfbyname</para>
            /// </summary>
            public const string ModifiedOnBehalfByName = "modifiedonbehalfbyname";

            /// <summary>
            ///     <para>Created By</para>
            ///     <para>createdby</para>
            /// </summary>
            public const string CreatedBy = "createdby";

            /// <summary>
            ///     <para>Created By (Delegate)</para>
            ///     <para>createdonbehalfby</para>
            /// </summary>
            public const string CreatedBy_Delegate = "createdonbehalfby";

            /// <summary>
            ///     <para>Created On</para>
            ///     <para>createdon</para>
            /// </summary>
            public const string CreatedOn = "createdon";

            /// <summary>
            ///     <para>Event Asset</para>
            ///     <para>ccc_eventassetid</para>
            /// </summary>
            public const string EventAssetId = "ccc_eventassetid";

            /// <summary>
            ///     <para>Import Sequence Number</para>
            ///     <para>importsequencenumber</para>
            /// </summary>
            public const string ImportSequenceNumber = "importsequencenumber";

            /// <summary>
            ///     <para>Modified By</para>
            ///     <para>modifiedby</para>
            /// </summary>
            public const string ModifiedBy = "modifiedby";

            /// <summary>
            ///     <para>Modified By (Delegate)</para>
            ///     <para>modifiedonbehalfby</para>
            /// </summary>
            public const string ModifiedBy_Delegate = "modifiedonbehalfby";

            /// <summary>
            ///     <para>Modified On</para>
            ///     <para>modifiedon</para>
            /// </summary>
            public const string ModifiedOn = "modifiedon";

            /// <summary>
            ///     <para>Name</para>
            ///     <para>ccc_name</para>
            /// </summary>
            public const string Name = "ccc_name";

            /// <summary>
            ///     <para>Owner</para>
            ///     <para>ownerid</para>
            /// </summary>
            public const string Owner = "ownerid";

            /// <summary>
            ///     <para>Owning Business Unit</para>
            ///     <para>owningbusinessunit</para>
            /// </summary>
            public const string OwningBusinessUnit = "owningbusinessunit";

            /// <summary>
            ///     <para>Owning Team</para>
            ///     <para>owningteam</para>
            /// </summary>
            public const string OwningTeam = "owningteam";

            /// <summary>
            ///     <para>Owning User</para>
            ///     <para>owninguser</para>
            /// </summary>
            public const string OwningUser = "owninguser";

            /// <summary>
            ///     <para>Record Created On</para>
            ///     <para>overriddencreatedon</para>
            /// </summary>
            public const string RecordCreatedOn = "overriddencreatedon";

            /// <summary>
            ///     <para>Status</para>
            ///     <para>statecode</para>
            /// </summary>
            public const string Status = "statecode";

            /// <summary>
            ///     <para>Status Reason</para>
            ///     <para>statuscode</para>
            /// </summary>
            public const string StatusReason = "statuscode";

            /// <summary>
            ///     <para>Time Zone Rule Version Number</para>
            ///     <para>timezoneruleversionnumber</para>
            /// </summary>
            public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

            /// <summary>
            ///     <para>UTC Conversion Time Zone Code</para>
            ///     <para>utcconversiontimezonecode</para>
            /// </summary>
            public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

            /// <summary>
            ///     <para>Version Number</para>
            ///     <para>versionnumber</para>
            /// </summary>
            public const string VersionNumber = "versionnumber";
        }
    }
}