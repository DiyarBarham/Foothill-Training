﻿using System;
namespace Price_Calculater_Kata
{
	public class Product
	{
		public String? name { get; set; }
		public int? upc { get; set; }
		public double price { get; set; }

		public Product()
		{
		}

		public Product(String? name, int? upc, double? price)
		{
			this.name = name;
			this.upc = upc;
			this.price = (double) price;
		}

        public override string ToString()
        {
            return "Product: " + name + " UPC: " + upc + " Price: " + price;
        }
    }
}

