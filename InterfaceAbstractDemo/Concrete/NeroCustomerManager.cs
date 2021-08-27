using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Concrete
{
    public class NeroCustomerManager:BaseCustomerManager
    {
        private IPersonCheckService _personCheckService;
        
       

        public override void Save(Customer customer)
        {
            base.Save(customer);
        }
    }
}
