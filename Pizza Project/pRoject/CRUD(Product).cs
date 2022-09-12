using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_Project.pRoject
{
    class CRUD_Product_
    {
        public static void Add()
        {
            string Name = Console.ReadLine();
            String Ingrident=Console.ReadLine();
            decimal Price =Convert.ToInt32 (Console.ReadLine());

            List<Product> products = new List<Product>();
            products.Add(new Product { Name = Name, Ingrident = Ingrident, Price = Price });

        }
    }
}
