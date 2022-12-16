using Customer.DAL.UnitOfWork;
using Customer.Domain.Models;
using Customer.PresentationLayer.Mapper;
using Customer.PresentationLayer.ViewModel;
using Customer.Services.IService;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Customer.Services.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly IUnitOfWork uow;
        public CustomerService(IUnitOfWork _uow)
        {
            uow = _uow;
        }
        public IEnumerable<CustomerViewModel> GetAll()
        {
            var products = this.uow.GenericRepository<CustomerUser>().Get().ToList();
            var productViewModel = products.ConvertToProductViewModelList();

            return productViewModel;
        }
        public CustomerViewModel GetById(object id)
        {


            var customer = uow.GenericRepository<CustomerUser>().GetByID(id);

            var productViewModel = customer.ConvertToProductViewModel();

          

            return productViewModel;
        }

       

       

        public void AddCustomer(CustomerViewModel model)
        {
            var objProduct = new CustomerUser
            {
                Id = model.Id,
                Name = model.Name,
                ModifiedOn = model.ModifiedOn,
                Rate = model.Rate,
                Description = model.Description,
                Barcode = model.Barcode,
                AddedOn = DateTime.UtcNow,
                IsDelete = false

            };
            if (objProduct != null)
            {
                uow.GenericRepository<CustomerUser>().Insert(objProduct);
                uow.Save();
            }
        }

        public void UpdateCustomer(CustomerViewModel model)
        {
            if (model.Id > 0)
            {
                var existingProduct = this.uow.GenericRepository<CustomerUser>().GetByID(model.Id);
                existingProduct.Id = model.Id;
                existingProduct.Name = model.Name;
                existingProduct.ModifiedOn = model.ModifiedOn;
                existingProduct.Rate = model.Rate;
                existingProduct.Description = model.Description;
                existingProduct.Barcode = model.Barcode;

                uow.Save();
            }

        }

        public void DeleteCustomerByID(int Id)
        {
            var product = uow.GenericRepository<CustomerUser>().GetByID(Id);

            product.IsDelete = true;
            uow.Save();
        }
    }
    }
