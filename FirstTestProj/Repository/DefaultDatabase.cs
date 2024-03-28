using DotNetFmsProj.IRepository;
using DotNetFmsProj.Shared;

namespace DotNetFmsProj.Repository
{
    public class DefaultDatabase : BaseDatabase, IDefaultDatabase
    {
        private string _connString;

        override public string connString
        {
            get
            {
                if (string.IsNullOrEmpty(_connString))
                {
                    try
                    {
                        _connString = CurrencyCollectionAppSettings.DefaultDbConnectionString;
                    }
                    catch
                    {
                        throw;
                    }
                }
                return _connString;
            }
        }
    }
}
