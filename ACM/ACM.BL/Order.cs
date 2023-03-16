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

		public bool Validate()
		{
			bool isValid = true;

			if (orderDate == null) isValid = false;

			return isValid;
		}
    }
}

