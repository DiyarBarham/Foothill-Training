namespace Price_Calculater_Kata;
class Program
{
    static void Main(string[] args)
    {
        double tax = 0.2, discount=0;
        int choice = 0;
        List<Product> productsList = new List<Product>();
        while (true)
        {
            StaticMethods.menu();
            choice = Convert.ToInt32(Console.ReadLine());

            if(choice == 1)
            {
                productsList.Add(StaticMethods.newProduct());

            } else if(choice == 2)
            {
                tax = Convert.ToDouble(Console.ReadLine());

            } else if(choice == 3)
            {
                StaticMethods.printProductDetails(productsList);
            } else if (choice == 4)
            {
                StaticMethods.printProductPrice(productsList, tax);

            } else if (choice == 5)
            {
                discount = Convert.ToDouble(Console.ReadLine());

            } else if (choice == 6)
            {
                StaticMethods.printProductPrice(productsList, tax, discount);
            }
        }
        
    }
    
}

