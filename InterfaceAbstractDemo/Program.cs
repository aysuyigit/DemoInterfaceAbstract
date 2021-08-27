using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using InterfaceAbstractDemo.Adapters;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Entities.Customer { DateOfBirth = new DateTime(1998, 7, 23), FirstName = "Aysu", LastName = "Yiğit", NationalityId = "12345678901" });
            Console.ReadLine();
        }

    }

}


