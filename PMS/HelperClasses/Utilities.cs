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
        public static string GetPasswordHash(string password)
        {
            try
            {
                var bytes = new UTF8Encoding().GetBytes(password);
                var hashBytes = System.Security.Cryptography.MD5.Create().ComputeHash(bytes);
                return Convert.ToBase64String(hashBytes);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}