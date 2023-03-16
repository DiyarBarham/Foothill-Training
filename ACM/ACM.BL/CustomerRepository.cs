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
			AddressRepository addressRepository = new AddressRepository();
			if(customerID == 1)
			{
				customer.emailAddress = "asd@asd.com";
				customer.firstName = "asd";
				customer.lastName = "qwe";
				customer.addressList = addressRepository.RetrieveByCustomerID(customerID).ToList();

            } 
			return customer;
		}

		public bool Save()
		{
			return true; 
		}
	}
}

