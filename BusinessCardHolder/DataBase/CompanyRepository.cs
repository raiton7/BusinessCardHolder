using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessCardHolder.DataBase
{
    public class CompanyRepository
    {
        private BusinessCardHolderContext businessCardHolderContext;

        CompanyRepository()
        {
            businessCardHolderContext = new BusinessCardHolderContext();
        }

        public void Add(Company company)
        {
            businessCardHolderContext.Companies.Add(company);
            businessCardHolderContext.SaveChanges();
        }

        public void DeleteById(int id)
        {
            Company company = businessCardHolderContext.Companies.Find(id);
            businessCardHolderContext.Companies.Remove(company);
            businessCardHolderContext.SaveChanges();
        }

        public void Update(Company company)
        {
            // cMU - CompanyUpdate
            Company companyUpdate = businessCardHolderContext.Companies.SingleOrDefault(cMU => cMU.Id == company.Id);
            if (companyUpdate != null)
            {
                companyUpdate.Name = company.Name;
                companyUpdate.Nip = company.Nip;
                companyUpdate.Address = company.Address;
                companyUpdate.City = company.City;
                companyUpdate.PostCode = company.PostCode;
                companyUpdate.PhoneNumber = company.PhoneNumber;
                companyUpdate.Notes = company.Notes;
            }
            businessCardHolderContext.SaveChanges();
        }

        public Company FindById(int id)
        {
            Company company = businessCardHolderContext.Companies.Find(id);
            return company;
        }

        public IEnumerable<Company> FindAll()
        {
            return businessCardHolderContext.Companies.ToList();
        }
    }
}
