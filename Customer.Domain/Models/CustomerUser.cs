using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Customer.Domain.Models
{
     public   class CustomerUser
     {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string Barcode { get; set; }
            public decimal Rate { get; set; }
            public DateTime AddedOn { get; set; }
            public DateTime ModifiedOn { get; set; }
            public bool IsDelete { get; set; }

       
    }
}
