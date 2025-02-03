using System;
using System.Dynamic;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(string name, string aStreet, string aCity, string aState, string aCountry)
    {
        Address newAddress = new Address(aStreet, aCity, aState, aCountry); 
        _customer = new Customer(name, newAddress);
        _products = new List<Product>();
    }

    public void AddNewProduct(Product item) => _products.Add(item);

    public double GetTotalBalance()
    {
        
        double totalAmount = GetShippingCost(); 
        Console.WriteLine($"Shipping: ${totalAmount}");

        foreach(var item in _products)
        {
            totalAmount += item.GetUnitBalance();
        }
        
        
        return Math.Round(totalAmount, 2);
    }
    public double GetShippingCost()
    {
        if (_customer.GetResidence())
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }
    public string GetPackingLabel()
    {
        string packingInfo= "\n-------------Packing label-------------";
        foreach(var item in _products)
        {
            packingInfo = string.Concat(packingInfo, item.GetDetails().ToString());
        }

        return packingInfo;
    }
    public string GetShippingLabel()
    {
        string shippingInfo = $"\n-------------Shipping label-------------\nShip to: {_customer.GetCustomerInfo()}\n";
        return shippingInfo;
    }


}