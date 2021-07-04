using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSEntity
{
    public class Company:Entity
    {
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string CompanyLogo { get; set; }
        public string CompanyType { get; set; }
        public string CompanyWebsite { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
