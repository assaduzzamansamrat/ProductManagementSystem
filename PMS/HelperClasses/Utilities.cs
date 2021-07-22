using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PMS.HelperClasses
{
    public static class Utilities
    {
        public static string GetIpAddress()
        {
            return System.Web.HttpContext.Current.Request.UserHostAddress;
        }
    }
}