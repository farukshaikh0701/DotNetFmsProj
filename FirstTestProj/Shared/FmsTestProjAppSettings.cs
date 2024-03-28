using Microsoft.Extensions.Configuration;
using System.IO;

namespace DotNetFmsProj.Shared
{
    public static class CurrencyCollectionAppSettings
    {
        public static string Application { get; }
        public static string Client { get; }
        public static string DefaultDbConnectionString { get; }
        public static string LoggingConnectionString { get; }
        public static string CachingMode { get; }
        public static string AssetDirectory { get; }
        public static string PhysicalPathDirectory { get; }
        public static string DayFormatFilePath { get; set; }
        public static string CollectionGallery { get; set; }
        public static string DayPersonImages { get; set; }
        public static string PersonFormatFilePath { get; set; }

        //For India
        public static string PersonFormatFilePathIndia { get; set; }

        //INCORP 465
        public static string PersonPayItemFilePathIndia { get; set; }


        public static string LeaveImportFormatFilePath { get; set; }
        public static string ExpenseTemplateFile { get; set; }
        public static string CurrencyConversionApiBaseUrl { get; set; }
        public static string CurrencyConversionApiPath { get; set; }
        public static string CurrencyConversionApiAccessKey { get; set; }

        static CurrencyCollectionAppSettings()
        {
            var builder = new ConfigurationBuilder()
                         .SetBasePath(Directory.GetCurrentDirectory())
                         .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                         .AddEnvironmentVariables();

            var config = builder.Build();

            //DefaultDbConnectionString = config["ConnectionStrings:DefaultDbConnectionString"];
            DefaultDbConnectionString = config["ConnectionStrings:FMSConnectionString"];
            //LoggingConnectionString = config["ConnectionStrings:LoggingConnectionString"];
            CachingMode = config["ConnectionStrings:CachingMode"];
            AssetDirectory = config["ConnectionStrings:AssetDirectory"];
            PhysicalPathDirectory = config["currencyCollectionAppSettings:PhysicalPathDirectory"];
            Application = config["ConnectionStrings:Application"];
            Client = config["ConnectionStrings:Client"];
            CollectionGallery = config["ConnectionStrings:CollectionGallery"];
            DayPersonImages = config["ConnectionStrings:DayPersonImages"];
            DayFormatFilePath = config["ConnectionStrings:DayFormatFilePath"];
            LeaveImportFormatFilePath = config["ConnectionStrings:LeaveImportFormatFilePath"];
            ExpenseTemplateFile = config["ConnectionStrings:ExpenseTemplateFile"];
            PersonFormatFilePath = config["ConnectionStrings:PersonFormatFilePath"];

            //For India
            PersonFormatFilePathIndia = config["ConnectionStrings:PersonFormatFilePathIndia"];

            //INCORP 465
            PersonPayItemFilePathIndia = config["ConnectionStrings:PersonPayItemFilePathIndia"];

            CurrencyConversionApiBaseUrl = config["ConnectionStrings:CurrencyConversionApiBaseUrl"];
            CurrencyConversionApiPath = config["ConnectionStrings:CurrencyConversionApiPath"];
            CurrencyConversionApiAccessKey = config["ConnectionStrings:CurrencyConversionApiAccessKey"];
        }

    }
}
