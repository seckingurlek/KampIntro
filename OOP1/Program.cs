﻿using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitINStock = 3;
            product1.UnitPrice = 500;

          
            Console.WriteLine(product1.ProductName);

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitINStock = 5, ProductName = "Kalem, UnitPrice = 35" };
            //PascalCase camelCase ikinci isim büyük
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

            productManager.Update(product1);





        }
    }
}
