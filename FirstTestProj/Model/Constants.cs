//using Aspose.Words;

namespace DotNetFmsProj.Model
{
    public class Constants
    {
        public struct Roles
        {
            public const string None = "None";
            public const string SuperAdmin = "Super Admin";
            public const string SystemAdmin = "System Admin";
            public const string GroupAdmin = "Group Admin";
            public const string Supervisor = "Supervisor";
            public const string Person = "Person";
        }

        public struct Permissions
        {
            public const string None = "None";
            //public const string GroupSetup = "GROUP_SETUP";

            public const string ViewCollection = "VIEW_COLLECTION";
            public const string AddCollection = "ADD_COLLECTION";
            public const string UpdateCollection = "UPDATE_COLLECTION";
            public const string DeleteCollection = "DELETE_COLLECTION";
            public const string ManageCollection = "MANAGE_COLLECTION";
            public const string ViewDay = "VIEW_DAY";
            public const string AddDay = "ADD_DAY";
            public const string UpdateDay = "UPDATE_DAY";
            public const string DeleteDay = "DELETE_DAY";
            public const string ManageDay = "MANAGE_DAY";
            //public const string ImportDay = "IMPORT_DAY";
            public const string ManageExpense = "MANAGE_EXPENSE";
            //public const string ImportExpense = "IMPORT_EXPENSE";
            //public const string ViewUser = "VIEW_USER";
            //public const string AddUser = "ADD_USER";
            //public const string UpdateUser = "UPDATE_USER";
            //public const string DeleteUser = "DELETE_USER";
            //public const string BlockUser = "BLOCK_USER";
            //public const string UnblockUser = "UNBLOCK_USER";
            public const string ManageUser = "MANAGE_USER";
            public const string ManageRole = "MANAGE_ROLE";
            public const string ManageSetting = "MANAGE_SETTING";
            public const string ViewNotification = "VIEW_NOTIFICATION";
            public const string ManageGlobalSetting = "MANAGE_GLOBAL_SETTING";

        }

        public struct Modules
        {
            public const string Collection = "Collection";
            public const string Day = "Day";
            public const string Expenses = "Expenses";
            public const string Settings = "Settings";
        }

        /// <summary>
        /// CachingTypes
        /// </summary>
        public struct Cachingtypes
        {
            public const string MEMORY_CACHING_SERVICE = "MemoryCachingService";
            public const string REDIS_CACHING_SERVICE = "RedisCachingService";
        }

        /// <summary>
        /// CacheKeys
        /// </summary>
        public struct CacheKeys
        {
            public const string APP_TOKEN = "data:apptoken";
            public const string APPSETTINGS_LIST_KEY = "data:{0}:appsettingLists";
            public const string GROUPCONFIG_LIST_KEY = "data:{0}groupConfigLists";
            public const string APPLICATION_USER_DETAIL = "data:userToken:{0}:applicationUserDetail";
            public const string NOTIFICATION_TEMPLATES = "data:{0}:notificationTemplates";
        }

        /// <summary>
        /// AppSettings
        /// </summary>
        public struct AppSettings
        {
            /*WEB Authentication Cookie EXPIRY RELATED*/
            public const string COOKIE_EXPIRY_IN_MINUTES = "COOKIE_EXPIRY_IN_MINUTES";
            public const string NOTIFICATION_TMPT_TOKEN = "NOTIFICATION_TMPT_TOKEN";
            public const string ERROR_EMAIL_TO_ADDRESS = "ERROR_EMAIL_TO_ADDRESS";

            //Email Settigns
            public const string EMAIL_SMTP = "EMAIL_SMTP";
            public const string EMAIL_PORT = "EMAIL_PORT";
            public const string EMAIL_USER_NAME = "EMAIL_USER_NAME";
            public const string EMAIL_USER_PWD = "EMAIL_USER_PWD";

            public const string EMAIL_FROM_ADDRS = "EMAIL_FROM_ADDRS"; //NOT IN USE NOW

            public const string LEAVE_EMAIL_SENDER = "LEAVE_FROM_EMAIL_ADDRESS";
            public const string PAYSLIP_EMAIL_SENDER = "PAYSLIP_FROM_EMAIL_ADDRESS";

            public const string CC_FOR_LEAVE_ALERT = "CC_FOR_LEAVE_ALERT";
            public const string CC_FOR_CLAIM_ALERT = "CC_FOR_CLAIM_ALERT";
            public const string CC_FOR_PAYROLL_ALERT = "CC_FOR_PAYROLL_ALERT";
        }

        public struct AppMenus
        {
            public const string HOME = "HOME";
            public const string GROUP = "GROUP";
            public const string COLLECTION = "COLLECTION";
            public const string PERSON = "PERSON";
            public const string DAYS = "DAYS";
            public const string SETTINGS = "SETTINGS";
            public const string NOTIFICATION = "NOTIFICATION";
            public const string USER = "USER";
            public const string EXPENSE = "EXPENSE";
        }

        /// <summary>
        /// Operation Types
        /// </summary>
        public struct OperationTypes
        {
            public const string PASSWORD_SIGNUP_EMAIL = "PASSWORD_SIGNUP_EMAIL";
            public const string PASSWORD_RESET_EMAIL = "PASSWORD_RESET_EMAIL";
            public const string PAYSLIP_READY_NOTIFICATION = "PAYSLIP_READY_NOTIFICATION";
        }

        /// <summary>
        /// DeliveryModes
        /// </summary>
        public struct DeliveryModes
        {
            public const string EML = "EML";
        }


        /// <summary>
        /// Notification status
        /// </summary>
        public struct NotificationStatus
        {
            public const string PENDING = "Pending";
            public const string SENT = "Sent";
            public const string FAILED = "Failed";
        }

        /// <summary>
        /// List Names
        /// </summary>
        public struct ListNames
        {
            public const string Country = "Country";
            public const string CurrencyType = "CurrencyType";
            public const string States = "States";
            public const string Branches = "Branches";
            public const string Citizenship = "Citizenship";
            public const string MaritalStatus = "MaritalStatus";
            public const string Religion = "Religion";
            public const string Currency = "Currency";
            public const string Year = "Year";
            public const string Month = "Month";
            public const string DaySpeciality = "DaySpeciality";
            public const string YesNo = "YesNo";
            public const string DayTypes = "DayTypes";
            public const string Relationships = "Relationships";
            public const string NoOfInOutsTimeAllowed = "NoOfInOutsTimeAllowed";
            public const string VariableAmountBasedOn = "VariableAmountBasedOn";
            public const string PersonStatus = "PersonStatus";
            public const string ActiveDepartments = "ActiveDepartments";
            public const string DocumentType = "DocumentType";
            public const string Duration = "Duration";
            public const string DayStatus = "DayStatus";
            public const string CalenderYear = "CalenderYear";
            public const string AdvPaymentPaidThrough = "AdvPaymentPaidThrough";
            public const string PersonCode = "PersonCode";
            public const string ModeOfTransaction = "ModeOfTransaction";
            public const string SourceOrReason = "SourceOrReason";
            public const string TransactionStatus = "TransactionStatus";
        }

        public struct EditProfileButtons
        {
            public const string SAVE = "Save";
            public const string CLEAR = "Clear";
        }

        public struct DocumentTypes
        {
            public const string USER_PROFILE_PICTURE = "User_Profile_Picture";
            public const string GROUP_LOGO = "Group_Logo";
            public const string DAYPERSONPIC = "Day_Person_Pic";
            public const string COLLECTION_COIN = "Collection_Coins";
            public const string EXPENSE_SCREENSHOT = "Expense_ScreenShot";
        }

        public struct DocumentDirectory
        {
            public const string GROUP_DOCUMENT = "GroupDocuments";
            public const string PERSON_DOCUMENT = "PersonDocuments";
            public const string APP_USER_DOCUMENT = "AppUserDocuments";
            public const string Temporary = "Temp";
        }

        public struct FileExt
        {
            public const string DOC = "DOC";
            public const string PDF = "PDF";
        }

        public struct GroupSetUp
        {
            public const string DONE = "Done";
        }

        public struct CommonFiles
        {
            public const string DayFormat = "DayFormat";
            public const string PersonFormat = "PersonFormat";
            public const string LeaveFormat = "LeaveFormat";
            public const string ExpenseTemplate = "ExpenseTemplate";
        }

        public struct EncryptionDecryptionKeys
        {
            public const string PasswordHash = "P@@Sw0rd";
            public const string SaltKey = "S@LT&KEY";
            public const string VIKey = "@1B2c3D4e5F6g7H8";
        }

        public struct UserAsPerson
        {
            public const string Yes = "Yes";
            public const string No = "No";
        }

        public struct SubmitOrRecall
        {
            public const string Submit = "Submit";
            public const string Recall = "Recall";
        }

        public struct PayslipFormat
        {
            public const string Format1 = "Format1";
            public const string Format2 = "Format2";
            public const string NonSGFormat = "NonSGFormat"; //Non Singapore Region - Indonesia 

            //For India
            public const string IndiaFormat = "IndiaFormat";
        }
    }
}
