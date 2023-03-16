using System;
namespace ACM.BL
{
	public class AddressRepository
	{
		public AddressRepository()
		{
		}
        public Address Retrieve(int addressID)
        {
            Address address = new Address(addressID);

            if (addressID == 1)
            {
                address.addressType = 1;
                address.streetLine1 = "asd1";
                address.streetLine2 = "asd2";
                address.city = "Ramalllah";
                address.state = "Jenin";
                address.country = "Palestine";
                address.postalCode = "123";

            }
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerID(int customerID)
        {
            List<Address> addressList = new List<Address>();
            Address address = new Address(1)
            {
                addressType = 1,
                streetLine1 = "asd1",
                streetLine2 = "asd2",
                city = "Ramalllah",
                state = "Jenin",
                country = "Palestine",
                postalCode = "123"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                addressType = 2,
                streetLine1 = "asd3",
                streetLine2 = "asd4",
                city = "Ramalllah1",
                state = "Jenin11",
                country = "Palestine1",
                postalCode = "1234"
            };
            addressList.Add(address);

            return addressList;

        }

        public bool Save(Address address)
        {
            return true;
        }
    }
}

