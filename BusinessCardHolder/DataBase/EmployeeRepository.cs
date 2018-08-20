using System;
using System.Collections.Generic;
using System.Linq;
using BusinessCardHolder.Models;
using System.Text;
using System.Threading.Tasks;

namespace BusinessCardHolder.DataBase
{
    class EmployeeRepository
    {
        private BusinessCardHolderContext businessCardHolderContext;

        EmployeeRepository(BusinessCardHolderContext businessCardHolderContext)
        {
            this.businessCardHolderContext = businessCardHolderContext;
        }
        
        public void Add(EmployeeModel employeeModel)
        {
            businessCardHolderContext.Employees.Add(employeeModel);
        }

        public void DeleteById(int id)
        {
            EmployeeModel employeeModel = businessCardHolderContext.Employees.Find(id);
            businessCardHolderContext.Employees.Remove(employeeModel);
        }

        public void Update(EmployeeModel employeeModel)
        {
            // cMU - EmployeeModelUpdate
            EmployeeModel employeeModelUpdate = businessCardHolderContext.Employees.SingleOrDefault(cMU => cMU.Id == employeeModel.Id);
            if (employeeModelUpdate != null)
            {
                employeeModelUpdate.CompanyId = employeeModel.CompanyId;
                employeeModelUpdate.FirstName = employeeModel.FirstName;
                employeeModelUpdate.LastName = employeeModel.LastName;
                employeeModelUpdate.JobTitle = employeeModel.JobTitle;
                employeeModelUpdate.PhoneNumber = employeeModel.PhoneNumber;
                employeeModelUpdate.MobilePhoneNumber = employeeModel.MobilePhoneNumber;
            }
        }

        public EmployeeModel FindById(int id)
        {
            EmployeeModel employeeModel = businessCardHolderContext.Employees.Find(id);
            return employeeModel;
        }

        public IEnumerable<EmployeeModel> FindAll()
        {
            return businessCardHolderContext.Employees.ToList();
        }
    }
}
