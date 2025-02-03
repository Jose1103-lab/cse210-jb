using System;
using System.Net.Mail;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Order newOrder1 = new Order("Jose brito", "test1", "test3", "test4", "Rep dom");
        Product newItem1 = new Product(001, "Itemx", 5.45, 2);
        Product newItem2 = new Product(003, "Itemx", 4.44, 2);
        Product newItem3 = new Product(004, "Itemx", 5.99, 5);
        newOrder1.AddNewProduct(newItem1);
        newOrder1.AddNewProduct(newItem2);
        newOrder1.AddNewProduct(newItem3);

        Console.WriteLine(newOrder1.GetShippingLabel());
        Console.WriteLine("Total amount: $" + newOrder1.GetTotalBalance());
        Console.WriteLine(newOrder1.GetPackingLabel());
        Console.WriteLine("Total amount: $" + newOrder1.GetTotalBalance());


        Order newOrder2 = new Order("Pedro Parker", "Element1", "Element3", "Element4", "UsA");
        Product newItem4 = new Product(001, "Itemx", 5.45, 2);
        Product newItem5 = new Product(003, "Itemx", 4.44, 2);
        newOrder2.AddNewProduct(newItem4);
        newOrder2.AddNewProduct(newItem5);

        Console.WriteLine(newOrder2.GetShippingLabel());
        Console.WriteLine("Total amount: $" + newOrder2.GetTotalBalance());
        Console.WriteLine(newOrder2.GetPackingLabel());
        Console.WriteLine("Total amount: $" + newOrder2.GetTotalBalance());

    }
}