using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1 & 2
            int i, n, m;
            int[] a = new int[100];

            Console.Write("Input the number of elements to store in the array :");
            n = Convert.ToInt32(Console.ReadLine());


            Console.Write("Input {0} number of elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nThe values store into the array are : \n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", a[i]);
            }
            Console.Write("\nInput the number of last elements to store in the array : \n");
            m = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nThe last values store into the array are : \n");
            for (i = n - m; i < n; i++)
            {
                Console.Write("{0}  ", a[i]);
            }

            //Task 3
            //string value;
            //string client;
            //string stuff;
            //var users = new Dictionary<string, List<Product>>();
            //var products = new List<Product>();
            //products.Add(new Product { Name = "banana" });
            //products.Add(new Product { Name = "apple" });
            //products.Add(new Product { Name = "orange" });

            //Console.WriteLine("Add client - to add new client");
            //Console.WriteLine("Login - to login to store by existing client");
            //Console.WriteLine("Buy - to buy some stuff by existing client");
            //Console.WriteLine("Print all - to display all stuff which was bought by existing client");
            //Console.WriteLine("Exit - to exit from store");

            //do
            //{
            //    value = Console.ReadLine();
            //    if (value == "Add client")
            //    {
            //        Console.WriteLine("Please enter a new client: ");
            //        client = Console.ReadLine();
            //        users.Add(client, new List<Product>());
            //    }
            //    if (value == "Login")
            //    {
            //        Console.WriteLine("Please enter a client name: ");
            //        client = Console.ReadLine();
            //        if (users.Keys.Any(name => name == client))
            //        {
            //            Console.WriteLine("You are login!");
            //            var user = client;
            //            do
            //            {
            //                value = Console.ReadLine();

            //                if (value == "Buy")
            //                {
            //                    Console.WriteLine("Please enter a stuff which you want to buy: ");
            //                    foreach (var prod in products)
            //                    {
            //                        Console.WriteLine($"Product = " + prod.Name);
            //                    }
            //                    stuff = Console.ReadLine();

            //                    if (products.Exists(p => p.Name == stuff))
            //                    {
            //                        users[user].Add(new Product() { Name = stuff });
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine("Product doesn't exist!");
            //                    }
            //                }

            //                if (value == "Print all")
            //                {
            //                    foreach (var prod in users[user])
            //                    {
            //                        Console.WriteLine($"Product = " + prod.Name);
            //                    }
            //                }
            //            }
            //            while (value != "Exit");

            //        }
            //        else
            //        {
            //            Console.WriteLine("User doesn't exist!");
            //        }
            //    }
            //}
            //while (value != "Exit");
        }

        //class Product
        //{
        //    public string Name { get; set; }
        //}


    }
}
