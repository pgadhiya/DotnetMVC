using System;
using System.Linq;

namespace M3._39
{
    class employee
    {
        string name, department;
        int maxsal = 0, n = 0,i;
        int[] salary = new int[50];
        //private byte salry;
        public void getdata()
        {
            Console.Write("Enter no of employee: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.Write("employee name {0}: ", i);
                name = Console.ReadLine();
                Console.Write("department :");
                department = Console.ReadLine();
                Console.Write("salary per month :");
                salary[i] = Convert.ToInt32(Console.ReadLine());
            }

        }
        public void displaydata()
        {
            
            for (i = 0; i < n; i++)
            {
                
                if (salary[i] > maxsal )
                {
                    maxsal = salary[i];
                }
                
            }
            Console.Write("Max salary: " + maxsal);
        }
    }
        class Program
        {
            static void Main(string[] args)
            {
                employee e = new employee();
                e.getdata();
                e.displaydata();

        }
        }
    }
