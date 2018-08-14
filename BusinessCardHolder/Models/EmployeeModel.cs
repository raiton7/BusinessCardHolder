using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessCardHolder.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public string PhoneNumber { get; set; }
        public string MobilePhoneNumber { get; set; }

        public CompanyModel Company { get; set; }
    }
}
