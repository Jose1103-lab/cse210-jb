using System;


public class Product
{
    private int _id;
    private string _name;
    private double _price;
    private int _quantity;

    public Product(int productId, string productName, double productPrice, int productQty)
    {
        _id = productId;
        _name = productName;
        _price = productPrice;
        _quantity = productQty;
    }

    public double GetUnitBalance() => _price * _quantity;

    public string GetDetails() => $"\nId: {_id}\nProduct: {_name}\nUnit price: {_price}\nQty: {_quantity}\n";

}