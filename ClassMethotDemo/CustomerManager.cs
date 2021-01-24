using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethotDemo
{
    public class CustomerManager
    {
       public void AddCustomer(Customer customer)
        {
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Customer Added : " + customer.Id+ " Welcome : "+customer.Name+customer.LastName) ;
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Personal Information : "+ "Age : "+customer.Age+ "   "+customer.SecretQuestion);
        }

        public void DeleteCustomer(Customer customer) 
        {
            Console.WriteLine(customer.Id +" "+customer.Name+ " "+customer.LastName +"  Deleted ");
        }
        public void UpdateCustomers(Customer customer)
        {
            Console.WriteLine(customer.Id + " "+customer.Name +" "+ customer.LastName+" " + " Updated   ");
        }
        public void ShowCustomers(Customer[] customers) 
        {
            foreach  (Customer customer in customers)
            {
                Console.WriteLine(customer.Id+" / "+customer.Name+" / "+customer.LastName+" / "+customer.Age+" / "+customer.SecretQuestion);
              
            }
        }

    }
}
