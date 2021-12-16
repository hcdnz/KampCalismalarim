using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using MernisReferanceService;
using System;

namespace InterfaceAbstractDemo.Adepters
{
    public class MernisServiceAdepter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(); 
            return client.TCKimlikNoDogrula(Convert.ToInt64(customer.NationlityId), customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year);
        }

        public void Save(Customer customer)
        {
            
        }
    }
}
