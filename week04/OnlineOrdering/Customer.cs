using System;
using System.ComponentModel;

public class Customer
{
    private string _customerName;
    private Address _address;
    private bool _isResident;

    public Customer(string custName, Address custAddress)
    {
        _customerName = custName;
        _address = custAddress;
        SetResidence();
    }
    public void SetResidence() => _isResident = _address.GetIfResidence();

    public bool GetResidence() => _isResident;

    public string GetCustomerInfo() => $"{_customerName}\n{_address.GetFullAddress()}";

}