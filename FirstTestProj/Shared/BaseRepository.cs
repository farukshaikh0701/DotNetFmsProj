using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetFmsProj.Shared
{
    public class BaseRepository
    {
        /// <summary>
        /// The outparamete r_ size
        /// </summary>
        protected const int OUTPARAMETER_SIZE = -1;

        /// <summary>
        /// The outparameter value for boolean 
        /// </summary>
        protected const bool OUTPARAMETER_VALUE_BOOL = false;

        /// <summary>
        /// Gets the string value.
        /// </summary>
        /// <param name="dataReader">The data reader.</param>
        /// <param name="columnName">Name of the column.</param>
        /// <returns></returns>
        protected string GetStringValue(IDataReader dataReader, string columnName)
        {
            //Retreive the column from the data reader
            object value = dataReader[columnName];

            string valueToReturn = string.Empty;

            //If the retrieved value is not null then cast it to the correct type
            if (!(value is DBNull))
            {
                valueToReturn = value.ToString();
            }

            return valueToReturn;

        }

        /// <summary>
        /// Gets the byte[] value.
        /// </summary>
        /// <param name="dataReader">The data reader.</param>
        /// <param name="columnName">Name of the column.</param>
        /// <returns></returns>
        protected byte[] GetByteValue(IDataReader dataReader, string columnName)
        {
            //Retreive the column from the data reader
            object value = dataReader[columnName];

            byte[] valueToReturn = null;

            //If the retrieved value is not null then cast it to the correct type
            if (!(value is DBNull))
            {
                valueToReturn = ((byte[])value);
            }

            return valueToReturn;

        }

        /// <summary>
        /// Gets the Int32 value.
        /// </summary>
        /// <param name="dataReader"></param>
        /// <param name="columnName"></param>
        /// <returns></returns>
        protected Int32 GetIntValue(IDataReader dataReader, string columnName)
        {
            //Retreive the column from the data reader
            object value = dataReader[columnName];

            Int32 valueToReturn = -1;

            //If the retrieved value is not null then cast it to the correct type
            if (!(value is DBNull))
            {
                valueToReturn = Convert.ToInt32(value);
            }

            return valueToReturn;
        }

        /// <summary>
        /// Gets the integer value.
        /// </summary>
        /// <param name="dataReader">The data reader.</param>
        /// <param name="columnName">Name of the column.</param>
        /// <returns></returns>
        protected Int32? GetIntegerValue(IDataReader dataReader, string columnName)
        {
            //Retreive the column from the data reader
            object value = dataReader[columnName];

            Int32? valueToReturn = null;

            //If the retrieved value is not null then cast it to the correct type
            if (!(value is DBNull))
            {
                valueToReturn = Convert.ToInt32(value);
            }

            return valueToReturn;
        }

        /// <summary>
        /// Gets the integer value.
        /// </summary>
        /// <param name="dataReader">The data reader.</param>
        /// <param name="columnName">Name of the column.</param>
        /// <returns></returns>
        protected Int32 GetInt32Value(IDataReader dataReader, string columnName)
        {
            //Retreive the column from the data reader
            object value = dataReader[columnName];

            Int32 valueToReturn = -1;

            //If the retrieved value is not null then cast it to the correct type
            if (!(value is DBNull))
            {
                valueToReturn = Convert.ToInt32(value);
            }

            return valueToReturn;
        }

        /// <summary>
        /// To return the Int64 value
        /// </summary>
        /// <param name="dataReader"></param>
        /// <param name="columnName"></param>
        /// <returns></returns>
        protected Int64? GetInt64Value(IDataReader dataReader, string columnName)
        {

            //Retreive the column from the data reader
            object value = dataReader[columnName];
            Int64? valueToReturn = null;
            //If the retrieved value is not null then cast it to the correct type
            if (!(value is DBNull))
            {
                //valueToReturn = (Int64?)value;
                valueToReturn = Convert.ToInt64(value);
            }
            return valueToReturn;
        }

        /// <summary>
        /// Gets the integer value.
        /// </summary>
        /// <param name="dataReader">The data reader.</param>
        /// <param name="columnName">Name of the column.</param>
        /// <returns></returns>
        protected Int16? GetSmallIntegerValue(IDataReader dataReader, string columnName)
        {
            //Retreive the column from the data reader
            object value = dataReader[columnName];

            Int16? valueToReturn = null;

            //If the retrieved value is not null then cast it to the correct type
            if (!(value is DBNull))
            {
                valueToReturn = (Int16?)value;
            }

            return valueToReturn;
        }

        /// <summary>
        /// Gets the date value.
        /// </summary>
        /// <param name="dataReader">The data reader.</param>
        /// <param name="columnName">Name of the column.</param>
        /// <returns></returns>
        protected DateTime? GetDateValue(IDataReader dataReader, string columnName)
        {
            //Retreive the column from the data reader
            object value = dataReader[columnName];

            DateTime? valueToReturn = null;

            //If the retrieved value is not null then cast it to the correct type
            if (!(value is DBNull))
            {
                valueToReturn = (DateTime?)value;
            }

            return valueToReturn;

        }

        /// <summary>
        /// Gets the date value.
        /// </summary>
        /// <param name="dataReader">The data reader.</param>
        /// <param name="columnName">Name of the column.</param>
        /// <returns></returns>
        protected DateTimeOffset? GetDateTimeOffsetValue(IDataReader dataReader, string columnName)
        {
            //Retreive the column from the data reader
            object value = dataReader[columnName];

            DateTimeOffset? valueToReturn = null;

            //If the retrieved value is not null then cast it to the correct type
            if (!(value is DBNull))
            {
                valueToReturn = (DateTimeOffset?)value;
            }

            return valueToReturn;
        }

        /// <summary>
        /// Gets the date value.
        /// </summary>
        /// <param name="dataReader">The data reader.</param>
        /// <param name="columnName">Name of the column.</param>
        /// <returns></returns>
        protected DateTime? GetTimeValue(IDataReader dataReader, string columnName)
        {
            //Retreive the column from the data reader
            object value = dataReader[columnName];

            DateTime? valueToReturn = null;

            //If the retrieved value is not null then cast it to the correct type
            if (!(value is DBNull))
            {
                valueToReturn = DateTime.Parse(value.ToString());
            }

            return valueToReturn;

        }

        /// <summary>
        /// Gets the bool value.
        /// </summary>
        /// <param name="dataReader">The data reader.</param>
        /// <param name="columnName">Name of the column.</param>
        /// <returns></returns>
        protected bool GetBoolValue(IDataReader dataReader, string columnName)
        {
            //Retreive the column from the data reader
            object value = dataReader[columnName];

            bool valueToReturn = false;

            //If the retrieved value is not null then cast it to the correct type
            if (!(value is DBNull))
            {
                valueToReturn = (bool)value;
            }

            return valueToReturn;

        }

        /// <summary>
        /// Gets the decimal value.
        /// </summary>
        /// <param name="dataReader">The data reader.</param>
        /// <param name="columnName">Name of the column.</param>
        /// <returns></returns>
        protected decimal? GetDecimalValue(IDataReader dataReader, string columnName)
        {
            //Retreive the column from the data reader
            object value = dataReader[columnName];

            decimal? valueToReturn = null;

            //If the retrieved value is not null then cast it to the correct type
            if (!(value is DBNull))
            {
                valueToReturn = (decimal?)value;
            }

            return valueToReturn;

        }

        /// <summary>
        /// Gets the float value.
        /// </summary>
        /// <param name="dataReader">The data reader.</param>
        /// <param name="columnName">Name of the column.</param>
        /// <returns></returns>
        protected float GetFloatValue(IDataReader dataReader, string columnName)
        {
            //Retreive the column from the data reader
            object value = dataReader[columnName];

            float valueToReturn = 0;

            //If the retrieved value is not null then cast it to the correct type
            if (!(value is DBNull))
            {
                try
                {
                    valueToReturn = (float)Convert.ToDouble(value);
                }
                catch
                {
                    valueToReturn = 0;
                }
            }

            return valueToReturn;
        }

        /// <summary>
        /// Gets the long value.
        /// </summary>
        /// <param name="dataReader">The data reader.</param>
        /// <param name="columnName">Name of the column.</param>
        /// <returns></returns>
        protected long? GetLongValue(IDataReader dataReader, string columnName)
        {
            //Retreive the column from the data reader
            object value = dataReader[columnName];

            long? valueToReturn = null;

            //If the retrieved value is not null then cast it to the correct type
            if (!(value is DBNull))
            {
                valueToReturn = (long?)value;
            }

            return valueToReturn;
        }

        /// <summary>
        /// Gets the guid value.
        /// </summary>
        /// <param name="dataReader">The data reader.</param>
        /// <param name="columnName">Name of the column.</param>
        /// <returns></returns>
        protected Guid GetGuidValue(IDataReader dataReader, string columnName)
        {
            //Retreive the column from the data reader
            object value = dataReader[columnName];

            Guid valueToReturn = Guid.Empty;

            //If the retrieved value is not null then cast it to the correct type
            if (!(value is DBNull))
            {
                valueToReturn = (Guid)value;
            }

            return valueToReturn;
        }

        /// <summary>
        /// Get the Bool value from Small int
        /// </summary>
        /// <param name="dataReader">The data reader.</param>
        /// <param name="columnName">Name of the column.</param>
        /// <returns>It returns the Boolvalue</returns>
        protected bool GetSmallIntBoolValue(IDataReader dataReader, string columnName)
        {
            //Retreive the column from the data reader
            object value = dataReader[columnName];
            bool valueToReturn = false;


            //If the retrieved value is not null then cast it to the correct type
            if (!(value is DBNull))
            {
                if ((Int16?)value == 1) { valueToReturn = true; }
            }
            return valueToReturn;
        }

        /// <summary>
        /// Encrypts entered string
        /// </summary>
        /// <param name="toEncrypt"></param>
        /// <param name="useHashing"></param>
        /// <returns></returns>
        //public static string Encrypt(string toEncrypt, bool useHashing)
        //{
        //    byte[] keyArray;
        //    byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);

        //    if (useHashing)
        //    {
        //        MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
        //        keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes("Secret@Key"));

        //        hashmd5.Clear();
        //    }
        //    else
        //        keyArray = UTF8Encoding.UTF8.GetBytes("Secret@Key");

        //    TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
        //    tdes.Key = keyArray;
        //    tdes.Mode = CipherMode.ECB;
        //    tdes.Padding = PaddingMode.PKCS7;

        //    ICryptoTransform cTransform = tdes.CreateEncryptor();
        //    byte[] resultArray =
        //      cTransform.TransformFinalBlock(toEncryptArray, 0,
        //      toEncryptArray.Length);
        //    tdes.Clear();
        //    return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        //}
    }
}
