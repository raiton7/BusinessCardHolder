using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessCardHolder.DataBase
{
    class EmployeeRepository
    {
        private BusinessCardHolderContext businessCardHolderContext;

        EmployeeRepository()
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
            // cMU - EmployeeUpdate
            Employee employeeUpdate = businessCardHolderContext.Employees.SingleOrDefault(cMU => cMU.Id == employee.Id);
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

        public IEnumerable<Employee> FindAll()
        {
            return businessCardHolderContext.Employees.ToList();
        }
    }
}
