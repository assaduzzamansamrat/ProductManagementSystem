using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace PMS.HelperClasses
{
    public static class Utilities
    {
        public static string GetIpAddress()
        {
            return System.Web.HttpContext.Current.Request.UserHostAddress;
        }
        public static string GetPasswordHash(string data)
        {
            try
            {
                byte[] byteArray = Encoding.ASCII.GetBytes(data);
                MemoryStream stream = new MemoryStream(byteArray);
                var md5 = new MD5CryptoServiceProvider();
                var md5data = md5.ComputeHash(stream);
                string passwordHash = md5data.ToString();
                return passwordHash;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}