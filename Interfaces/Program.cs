using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            

            ICustomerDal[] customerDals = new ICustomerDal[] { new OracleCustomerDal(), new SqlServerCustomerDal() };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
            PersonManager manager = new PersonManager();
            Customer customer = new Customer();
            customer.FirstName = "Engin";
            customer.LastName = "Demirog";
            manager.Add(customer);

            Student student = new Student();
            student.Id = 1;
            student.FirstName = "Derin";
            student.LastName = "Demirog";
            manager.Add(student);

            


        }
    }
}
