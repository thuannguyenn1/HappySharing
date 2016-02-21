using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace JobTips.Core.Utility
{
    public class EncryptHelper
    {
        public static string GenerateToken()
        {
            DateTime datetime=new DateTime();
            string data = (datetime.Year.ToString()
                          + datetime.Month.ToString()
                          + datetime.Day.ToString()
                          + datetime.Millisecond.ToString()
                          + datetime.Second.ToString()
                          + datetime.Hour.ToString()
                          + datetime.Ticks.ToString());

            return GetSHA1HashData(data);
        }

        public static string GetSHA1HashData(string data)
        {
            SHA1 sha1 = SHA1.Create();
            
            byte[] hashData = sha1.ComputeHash(Encoding.Default.GetBytes(data));

            StringBuilder returnValue = new StringBuilder();

            foreach (byte t in hashData)
            {
                returnValue.Append(t.ToString());
            }

            return returnValue.ToString();
        }

        public static bool ValidateSHA1HashData(string inputData, string storedHashData)
        {
            string getHashInputData = GetSHA1HashData(inputData);

            if (String.CompareOrdinal(getHashInputData, storedHashData) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
