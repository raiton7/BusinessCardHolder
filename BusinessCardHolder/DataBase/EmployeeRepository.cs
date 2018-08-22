using System;
using System.Collections.Generic;
using System.Linq;
using BusinessCardHolder.Models;
using System.Text;
using System.Threading.Tasks;

namespace BusinessCardHolder.DataBase
{
    public class EmployeeRepository
    {
        private BusinessCardHolderContext businessCardHolderContext;

        public EmployeeRepository()
        {
            businessCardHolderContext = new BusinessCardHolderContext();
        }
        
        public void Add(Employee employee)
        {
            businessCardHolderContext.Employees.Add(employee);
            businessCardHolderContext.SaveChanges();
        }

        public void DeleteById(int id)
        {
            Employee employee = businessCardHolderContext.Employees.Find(id);
            businessCardHolderContext.Employees.Remove(employee);
            businessCardHolderContext.SaveChanges();
        }

        public void Update(Employee employee)
        {
            // eU - employeeUpdate
            Employee employeeUpdate = businessCardHolderContext.Employees.SingleOrDefault(eU => eU.Id == employee.Id);
            if (employeeUpdate != null)
            {
                employeeUpdate.CompanyId = employee.CompanyId;
                employeeUpdate.FirstName = employee.FirstName;
                employeeUpdate.LastName = employee.LastName;
                employeeUpdate.JobTitle = employee.JobTitle;
                employeeUpdate.PhoneNumber = employee.PhoneNumber;
                employeeUpdate.MobilePhoneNumber = employee.MobilePhoneNumber;
            }
            businessCardHolderContext.SaveChanges();
        }

        public Employee FindById(int id)
        {
            Employee employee = businessCardHolderContext.Employees.Find(id);
            return employee;
        }

        public List<Employee> FindByCompanyId(int id)
        {
            List<Employee> employees = businessCardHolderContext.Employees.Where(c => c.CompanyId == id).ToList();
            return employees;
        }

        public IEnumerable<Employee> FindAll()
        {
            return businessCardHolderContext.Employees.ToList();
        }

        public IEnumerable<Employee> Search(string firstName, string lastName, string companyName, string jobTitle, string phoneNumber, string mobileNumber)
        {
            List<Employee> employees = businessCardHolderContext.Employees.Where(e => 
                e.FirstName.Contains(firstName) && e.LastName.Contains(lastName) && e.Company.Name.Contains(companyName) && 
                e.JobTitle.Contains(jobTitle) && e.PhoneNumber.Contains(phoneNumber) && e.MobilePhoneNumber.Contains(mobileNumber))
                .ToList();
            return employees;
        }
    }
}
