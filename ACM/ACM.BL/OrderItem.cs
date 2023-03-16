using System;
namespace ACM.BL
{
	public class OrderItem
	{
		public int orderItemID { get; private set; }
		public int productID { get; set; }
		public decimal? purchasePrice { get; set; }
		public int quantity { get; set; }

		public OrderItem()
		{
		}

        public OrderItem(int orderItemID)
        {
			this.orderItemID = orderItemID;
        }

		public OrderItem Retrieve(int orderItemID)
		{
			return new OrderItem();
		}

		public bool Save()
		{
			return true;
		}

		public bool Validate()
		{
			bool isValid = true;

			if (quantity <= 0) isValid = false;
			if (productID <= 0) isValid = false;
			if (purchasePrice == null) isValid = false;

			return isValid;
		}
    }
}

