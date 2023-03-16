using System;
namespace ACM.BL
{
	public class CustomerRepository
	{

		public CustomerRepository()
		{

		}

		public Customer Retrieve(int customerID)
		{
			Customer customer = new Customer(customerID);

			if(customerID == 1)
			{
				customer.emailAddress = "asd@asd.com";
				customer.firstName = "asd";
				customer.lastName = "qwe";
				
			}
			return customer;
		}

		public bool Save()
		{
			return true; 
		}
	}
}

