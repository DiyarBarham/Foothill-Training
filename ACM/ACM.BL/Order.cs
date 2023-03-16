using System;
namespace ACM.BL
{
	public class Order
	{
		public DateTimeOffset? orderDate { get; set; }
		public int orderID { get; private set; }

		public Order()
		{
		}

        public Order(int orderID)
        {
			this.orderID = orderID;
        }

		public Order Retrieve(int orderID)
		{
			return new Order();
		}

		public bool Save()
		{
			return true;
		}

		public bool Validate()
		{
			bool isValid = true;

			if (orderDate == null) isValid = false;

			return isValid;
		}
    }
}

