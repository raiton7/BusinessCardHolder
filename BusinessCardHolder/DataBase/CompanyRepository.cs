using BusinessCardHolder.Models;
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

        CompanyRepository(BusinessCardHolderContext businessCardHolderContext)
        {
            this.businessCardHolderContext = businessCardHolderContext;
        }

        public void Add(CompanyModel companyModel)
        {
            businessCardHolderContext.Companies.Add(companyModel);
        }

        public void DeleteById(int id)
        {
            CompanyModel companyModel = businessCardHolderContext.Companies.Find(id);
            businessCardHolderContext.Companies.Remove(companyModel);
        }

        public void Update(CompanyModel companyModel)
        {
            // cMU - companyModelUpdate
            CompanyModel companyModelUpdate = businessCardHolderContext.Companies.SingleOrDefault(cMU => cMU.Id == companyModel.Id);
            if (companyModelUpdate != null)
            {
                companyModelUpdate.Name = companyModel.Name;
                companyModelUpdate.Nip = companyModel.Nip;
                companyModelUpdate.Address = companyModel.Address;
                companyModelUpdate.City = companyModel.City;
                companyModelUpdate.PostCode = companyModel.PostCode;
                companyModelUpdate.PhoneNumber = companyModel.PhoneNumber;
                companyModelUpdate.Notes = companyModel.Notes;
            }
        }

        public CompanyModel FindById(int id)
        {
            CompanyModel companyModel = businessCardHolderContext.Companies.Find(id);
            return companyModel;
        }

        public IEnumerable<CompanyModel> FindAll()
        {
            return businessCardHolderContext.Companies.ToList();
        }
    }
}
