using System;
namespace Price_Calculater_Kata
{
	public static class StaticMethods
	{
		public static String printPrice(double price)
		{
			return $"${price.ToString("F")}";
		}

        public static void menu()
        {
			Console.WriteLine("1- Add new Product");
            Console.WriteLine("2- Change Tax value");
            Console.WriteLine("3- print product details");
            Console.WriteLine("4- print product price before and after TAX");
            Console.WriteLine("5- Change discount value");
        }

		public static Product newProduct()
        {
            Console.WriteLine("Enter product name:");
            String? name = Console.ReadLine();
            Console.WriteLine("Enter product UPC:");
            int? upc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter product price:");
            double? price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter product discount:");
            double discount = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Enter product cap:");
            double cap = Convert.ToDouble(Console.ReadLine());
            return new Product(name, upc, price, discount, cap);
        }

        public static Product? findProduct(List<Product> productsList)
        {
            Console.WriteLine("Enter Product UPC");
            int? upc = Convert.ToInt32(Console.ReadLine());
            foreach(Product p in productsList)
            {
                if(p.upc == upc)
                {
                    return p;
                }
            }

            return null;

            
        }

        public static void printProductDetails(List<Product> productsList)
        {
            Product? p = findProduct(productsList);
            Console.WriteLine(p.ToString());
        }

        public static void printProductPrice(List<Product> productsList, double tax)
        {
            Product? p = findProduct(productsList);
            Console.WriteLine($"Product price before tax is {printPrice(p.price)}" +
                $" and after TAX is {printPrice(p.price + p.price*tax)}");
        }

        public static void printProductPrice(List<Product> productsList, double tax
            , double discount)
        {
            Product? p = findProduct(productsList);
            Console.WriteLine("If you want TAX after discount " +
                "press 0 and if before press 1:");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("If you want additive discount " +
                "press 0 and if multiplicative press 1:");
            int discountType = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Cost = {p.price}");
            double cappedValue = p.price * p.cap,
                addValue = p.price * (1 - p.discount) + p.price * (1 - discount),
                multiValue = p.price * (1 - p.discount) * (1 - discount);
            //SimpleSumDiscount(p, discountedPrice, discount);
            double[] discountStatments = new double[] {
                cappedValue > addValue ? cappedValue : addValue,
                cappedValue > multiValue ? cappedValue : multiValue
            };

            Console.WriteLine($"Discount = {printPrice(
                discountStatments[discountType])}");

            Console.WriteLine($"Packaging  = {printPrice(p.price * p.packageCost)}");
            Console.WriteLine($"Transport = {printPrice(p.transportCost)}");

            //if (c == 1)
            //{
            //    Console.WriteLine($"TAX = {printPrice(discountedPrice * tax)}");
                
            //} else
            //{
            //    Console.WriteLine($"TAX = {printPrice(p.price * tax)}");
            //}
            string[] printStatments = new string[] {
                $"TAX = {printPrice(discountStatments[discountType] * tax)}",
                $"TAX = {printPrice(p.price * tax)}"
            };
            Console.WriteLine(printStatments[c]);


            Console.WriteLine($"TOTAL = {printPrice(
                discountStatments[discountType] * tax -
                    discountStatments[discountType] * discount +
                    p.price * p.packageCost +
                    p.transportCost)}");
            if (discount != 0 || p.discount !=0)
            {
                Console.WriteLine($"Deduced amount by discount is " +
                    $"{printPrice(discountStatments[discountType] - p.price +
                    discountStatments[discountType] * p.discount)}");
            }
        }


        public static void AdditiveDiscount(Product? p,
            double discountedPrice, double discount)
        {
                Console.WriteLine($"Discount = {printPrice(p.price * p.discount +
                    discountedPrice * discount)}");
        }

        public static void MultiplicaativeDiscount(Product? p,
            double discountedPrice, double discount)
        {
            Console.WriteLine($"Discount = {printPrice(p.price * p.discount +
                discountedPrice * discount)}");
        }
    }
}

