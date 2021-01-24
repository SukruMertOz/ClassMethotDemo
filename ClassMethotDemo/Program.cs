using System;

namespace ClassMethotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 14;
            customer1.Name="Sena Nur ";
            customer1.LastName = "Senisevmez";
            customer1.Age = 24;
            customer1.SecretQuestion = "What is your Highschool ?";

            Customer customer2 = new Customer();
            customer2.Id = 15;
            customer2.Name ="Mert ";
            customer2.LastName = "Oz";
            customer2.Age = 20;
            customer2.SecretQuestion = "Who is your first love ?";

            Customer customer3 = new Customer();
            customer3.Id =16;
            customer3.Name = "Selin ";
            customer3.LastName = "Tek";
            customer3.Age=19;
            customer3.SecretQuestion = "What is your momy's second name ?";
            Customer customer = new Customer { Id = 13, Name = "Sevda", LastName = "Tek", Age = 25, SecretQuestion = "What is your momy's second name ?" };

            Customer[] customers = new Customer[] { customer1,customer2,customer3};

            

            CustomerManager customerManager = new CustomerManager();
            customerManager.AddCustomer(customer1);
            customerManager.AddCustomer(customer2);
            customerManager.AddCustomer(customer3);
            customerManager.ShowCustomers(customers);
            customerManager.UpdateCustomers(customer3);
            customerManager.DeleteCustomer(customer3);
            




        }
    }
}
