﻿using System;
namespace Price_Calculater_Kata
{
	public class Product
	{
		public String? name { get; set; }
		public int? upc { get; set; }
		public double price { get; set; }
		public double discount { get; set; }
		public double packageCost { get; set; }
        public double transportCost { get; set; }
        public double cap { get; set; }
        public Product()
		{
		}

		public Product(String? name, int? upc, double? price)
		{
			this.name = name;
			this.upc = upc;
			this.price = (double) price;
			this.discount = 0;
			this.cap = 0.2;
		}

        public Product(String? name, int? upc, double? price, double discount, double cap)
        {
            this.name = name;
            this.upc = upc;
            this.price = (double)price;
            this.discount = discount;
			this.cap = cap;
        }

        public override string ToString()
        {
            return $"Product: {name} UPC: {upc} Price: {price} Discount: {discount} CAP: {cap}";
        }
    }
}

