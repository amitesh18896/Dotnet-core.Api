using Customer.PresentationLayer.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Customer.Services.IService
{
    public interface ICustomerService
    {
        IEnumerable<CustomerViewModel> GetAll();
        CustomerViewModel GetById(object id);
        void AddCustomer(CustomerViewModel model);
        void UpdateCustomer(CustomerViewModel model);
        void DeleteCustomerByID(int Id);

    }
}