using System;
namespace ACM.BL
{	
	public class Address
	{
		public int addressID { get; set; }
        public int addressType { get; set; }
		public String city { get; set; }
        public String country { get; set; }
        public String postalCode { get; set; }
        public String state { get; set; }
        public String streetLine1 { get; set; }
        public String streetLine2 { get; set; }


        public Address()
		{
		}

        public Address(int addressID)
        {
            this.addressID = addressID;
        }

        public bool Validate()
        {
            bool isValid = true;

            if (postalCode == null) isValid = false;

            return isValid;
        }
    }
}

