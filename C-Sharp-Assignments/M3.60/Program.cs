using System;

namespace M3._60
{
    class products
    {
        int n,i, qty;
        int[] price = new int[50];
        string[] name = new string[50];
        public void getproduct()
        {
            Console.Write("Enter no of products: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.WriteLine($"Product no {i}: ");
                Console.Write("Enter Name: ");
                name[i] = Console.ReadLine();
                Console.Write("Enter Price: ");
                price[i] = Convert.ToInt32(Console.ReadLine());              
            }
        }
        public void purchaseProd()
        {
            Console.Write("Select Product no: ");
            i = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter quantity: ");
            qty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Purchase details: ");
            Console.WriteLine("Name: " + name[i]);
            Console.WriteLine("Price: " + price[i]);
            Console.WriteLine("Quantity: " + qty);
            Console.WriteLine("Total: " + price[i]* qty);
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            products obj = new products();
            obj.getproduct();
            obj.purchaseProd();
        }
    }
}
