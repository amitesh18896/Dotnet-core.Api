using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Customer.PresentationLayer.ViewModel;
using Customer.Services.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Customer.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet(Name = "Products")]
        public IEnumerable<CustomerViewModel> GetAll()
        {
            return _customerService.GetAll();

        }

        [HttpPut]
        public void Update(CustomerViewModel model)
        {
            _customerService.UpdateCustomer(model);
        }
        [HttpPost]
        public void AddProduct(CustomerViewModel model)
        {
            _customerService.AddCustomer(model);
        }
        [HttpDelete]
        public void DeleteProductByID(int Id)
        {
            _customerService.DeleteCustomerByID(Id);
        }
    }
}