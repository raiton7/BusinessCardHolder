using System.Text.RegularExpressions;

namespace BusinessCardHolder.Models
{
    public class Validation
    {
        static public bool ValidateCompany(Company company, ref string errorText)
        {
            string nameRegex = @"([a-zA-Z'\s]+)([\w]*)([0-9]*)$";
            string nipAndPhoneNumberRegex = @"^([0-9]*)$";
            string nipRegex = @"[0-9]{3}[-]*[0-9]{2}[-]*[0-9]{2}[-]*[0-9]{3}$";
            string addressRegex = @"([a-zA-Z'\s]*)+([\w]*)+([0-9]*)$";
            string cityRegex = @"([a-zA-ZZĄĆĘÓŚŃŻŹąćęńóśżź]+[?:[\s-]a-zA-ZZĄĆĘÓŚŃŻŹąćęńóśżź]+)*$";
            string postCodeRegex = @"^[0-9][0-9][-][0-9][0-9][0-9]$";
            if (string.IsNullOrEmpty(company.Name) || (!Regex.Match(company.Name, nameRegex).Success) ||
                company.Name.Length > 500)
            {
                errorText = "name";
                return false;
            }
            if (string.IsNullOrEmpty(company.Nip) || (!Regex.Match(company.Nip, nipRegex).Success) ||
                company.Nip.Length > 16)
            {
                errorText = "nip";
                return false;
            }
            if (string.IsNullOrEmpty(company.Address) || (!Regex.Match(company.Address, addressRegex).Success))
            {
                errorText = "address";
                return false;
            }
            if (string.IsNullOrEmpty(company.City) || (!Regex.Match(company.City, cityRegex).Success) ||
                company.City.Length > 100)
            {
                errorText = "city";
                return false;
            }
            if (string.IsNullOrEmpty(company.PostCode) || (!Regex.Match(company.PostCode, postCodeRegex).Success) ||
                company.PostCode.Length > 8)
            {
                errorText = "postCode";
                return false;
            }
            if (string.IsNullOrEmpty(company.PhoneNumber) || (!Regex.Match(company.PhoneNumber, nipAndPhoneNumberRegex).Success) ||
                company.PhoneNumber.Length > 16)
            {
                errorText = "phone";
                return false;
            }

            return true;
        }

        static public bool ValidateEmployee(Employee employee, ref string errorText)
        {
            string firstNameLastNameJobTitleRegex = @"[A-Z]+([a-z]*)$";
            string phoneNumbersRegex = @"^([0-9]*)$";
            if (string.IsNullOrEmpty(employee.FirstName) || (!Regex.Match(employee.FirstName, firstNameLastNameJobTitleRegex).Success) ||
                employee.FirstName.Length > 100)
            {
                errorText = "firstName";
                return false;
            }
            if (string.IsNullOrEmpty(employee.LastName) || (!Regex.Match(employee.LastName, firstNameLastNameJobTitleRegex).Success) ||
                employee.LastName.Length > 100)
            {
                errorText = "lastName";
                return false;
            }
            if (string.IsNullOrEmpty(employee.JobTitle) || (!Regex.Match(employee.JobTitle, firstNameLastNameJobTitleRegex).Success) ||
                employee.JobTitle.Length > 200)
            {
                errorText = "jobTitle";
                return false;
            }
            if (string.IsNullOrEmpty(employee.PhoneNumber) || (!Regex.Match(employee.PhoneNumber, phoneNumbersRegex).Success) ||
                employee.PhoneNumber.Length > 16)
            {
                errorText = "phone";
                return false;
            }
            if (string.IsNullOrEmpty(employee.MobilePhoneNumber) || (!Regex.Match(employee.MobilePhoneNumber, phoneNumbersRegex).Success) ||
                employee.MobilePhoneNumber.Length > 16)
            {
                errorText = "mobile";
                return false;
            }

            return true;
        }
    }
}
