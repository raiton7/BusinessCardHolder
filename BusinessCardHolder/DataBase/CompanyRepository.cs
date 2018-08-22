using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using BusinessCardHolder.Models;
using System.Text;
using System.Threading.Tasks;

namespace BusinessCardHolder.DataBase
{
    public class CompanyRepository
    {
        private BusinessCardHolderContext businessCardHolderContext;

        public CompanyRepository()
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
            // cU - companyUpdate
            Company companyUpdate = businessCardHolderContext.Companies.SingleOrDefault(cU => cU.Id == company.Id);
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

        public IEnumerable<Company> Search(string name, string nip, string address, string city, string postCode, string phoneNumber)
        {
            List<Company> companies = businessCardHolderContext.Companies.Where(c => 
                c.Name.Contains(name) && c.Nip.Contains(nip) && c.Address.Contains(address) && c.City.Contains(c.City) && 
                c.PostCode.Contains(postCode) && c.PhoneNumber.Contains(phoneNumber))
                .ToList();
            return companies;
        }
    }
}
