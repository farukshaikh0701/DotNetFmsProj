namespace DotNetFmsProj.Model
{
    public enum Role
    {
        None = 0,
        SuperAdmin = 1,
        GroupAdmin = 2,
        Supervisor = 3,
        Person = 4
    }

    public enum Entity
    {
        NONE = 0,
        USER = 1,
        GROUP_BIRTHDAYS_INFO = 2,
        GROUP_BASIC_INFO = 4,
        GROUP_EMAIL_SETUP = 5,
        PERSON_BASIC_INFO = 7,
        PERSON_DOCUMENT = 9,
        BIRTHDAYS_INFO = 11,
        BACKGROUND_EMAIL_JOB = 12,
        BACKGROUND_ATTENDANCE_SYNC_JOB = 13,
        BACKGROUND_PAYSLIP_EMAIL_JOB = 14,
        BACKGROUND_CURRENCY_EX_RATE_ADD_JOB = 16,
        BACKGROUND_LEAVE_REMINDER_EMAIL_JOB = 17,
        BACKGROUND_EXPENSE_SUMBIT_REMINDER_EMAIL_JOB = 18,
        EMAIL_SEND = 21
    }

    public enum EntityAction
    {
        View = 1,
        Save = 2,
        Update = 3,
        Delete = 4,
        Login = 5,
        Start = 6,
        End = 7,
        Sent = 8,
        AlreadyExecutedJob = 9
    }

    public enum NotificationPriority
    {
        Normal = 0,
        High = 1,
        Medium = 2,
        Low = 3
    }

    public enum AssetType
    {
        Image,
        Document
    }

    public enum FileType
    {
        Original = 1,
        Thumbnail = 2,
        Preview = 3,
    }

    public enum GroupPartialPage
    {
        Information = 1,
        Payroll = 2,
        Birthday = 3,
        EmailSetup = 4,
        Branches = 5
    }
    public enum CollectionPartialPage
    {
        Information = 1,
        Payroll = 2,
        Birthday = 3,
        EmailSetup = 4,
        Branches = 5
    }

    public enum PersonPartialPage
    {
        BasicInformation = 1,
        EmploymentSalary = 2,
        SalaryHistory = 3
    }

    public enum PayrollPartialPage
    {
        ProcessPayroll = 1,
        ReviewPersons = 2,
        ConfirmPayroll = 3
    }
    public enum BonusPartialPage
    {
        AddBonus = 1,
        FinalizePayment = 2,
    }
    public enum CPFPartialPage
    {
        GIRO = 1,
        IR8A = 2,
        CPF = 3
    }

    public enum PayrollReportsPartialPage
    {
        Payroll = 1,
        PaymentListing = 2,
        CPF = 3,
        PayItemsDetails = 4
    }

    public enum ExpensePartialPage
    {
        ExpenseDetails = 1,
        AddMileage = 2,
        AddPerDiem = 3,
        BulkExpenseDetails = 4
    }

    public enum ReportPartialPage
    {
        MyApprovals = 1,
        AllApprovals = 2
    }

    public enum AlertsPartialPage
    {
        WorkPermit = 1,
        ProbationCompletion = 2,
        MyAlerts = 3
    }

    public enum GlobalSettingsPartialPage
    {
        CommonDisplayFields = 1,
        CommonPayItem = 2,
        EmailTemplate = 3,
        ManageGroups = 4,
        ModuleAccess = 5
    }

    public enum SettingsPartialPage
    {
        GroupSettings = 1,
        DisplayFields = 2,
        Banks = 3
    }

}
