using Customer.Domain.Models;
using Customer.PresentationLayer.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Customer.PresentationLayer.Mapper
{
    public static class CustomerMapper
    {
        public static CustomerViewModel ConvertToProductViewModel(this CustomerUser model)
        {
            var output = new CustomerViewModel()
            {
                Id=model.Id,
                Name=model.Name,
                Description=model.Description,
                Barcode=model.Barcode,
                Rate=model.Rate
            };

            return output;
        }

        public static List<CustomerViewModel> ConvertToProductViewModelList
            (this List<CustomerUser> model)
        {
            List<CustomerViewModel> output = model.ConvertAll(ConvertToProductViewModel);

            return output;
        }

    }
}