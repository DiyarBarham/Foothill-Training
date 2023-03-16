using System;
namespace ACM.BL
{
	public class Order
	{
		public DateTimeOffset? orderDate { get; set; }
		public int orderID { get; private set; }
		public int customerID { get; set; }
		public int shippingAddressID { get; set; }
		public List<OrderItem> OrderItems { get; set; }

		public Order()
		{
		}

        public Order(int orderID)
        {
			this.orderID = orderID;
			OrderItems = new List<OrderItem>(); 
        }

		public bool Validate()
		{
			bool isValid = true;

			if (orderDate == null) isValid = false;

			return isValid;
		}
    }
}

