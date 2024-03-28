namespace DotNetFmsProj.Shared
{
    public enum ErrorCodes
    {
        NoError = 0,
        ValidationError = 1000,
        AuthenticationFailure = 10000,
        UserNotFound = 10001,
        InvalidToken = 10002,
        ERRORWHILESAVE = 10003,
        UserInactive = 10004,

        ForcefullyChangePassword = 5001,        
        ServerError = 50000,
        InvalidFileContent = 14001,
    }
}
