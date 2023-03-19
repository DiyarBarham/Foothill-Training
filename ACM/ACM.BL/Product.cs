using System;
using Acme.common;
namespace ACM.BL
{
	public class Product : EntityClass, ILoggable
	{
        public decimal? currentPrice { get; set; }
        public String productDescription { get; set; }
        public int productID { get; private set; }
        private String _productName;
        public String productName {
            get
            {
                return _productName.InsertSpaces();
            }
            set
            {
                _productName = value; 
            }
        }

        public Product()
		{
		}

        public Product(int productID)
        {
            this.productID = productID;
        }

        public string Log() =>
            $"{productID}: {productName} Detail: {productDescription} Status: {entityState.ToString()}";

        public override bool Validate()
        {
            bool isValid = true;

            if (String.IsNullOrWhiteSpace(productName)) isValid = false;
            if (currentPrice == null) isValid = false;

            return isValid;
        }
    }
}

