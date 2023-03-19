using System;
using Acme.common;

namespace ACM.BL
{
	public class Order : EntityClass, ILoggable
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

		public override bool Validate()
		{
			bool isValid = true;

			if (orderDate == null) isValid = false;

			return isValid;
		}

        public string Log() =>
            $"{orderID}: Date: {this.orderDate.Value.Date} Status: {this.entityState.ToString()}";

    }
}

