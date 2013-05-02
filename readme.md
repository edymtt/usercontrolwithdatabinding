UserControl DataBinding in Windows Forms
==

This sample shows how to do databinding and error validation in Windows Forms in three
different scenario:

1. databinding with stock controls (Customer.Title property);
2. databinding with user control for string properties (Customer.FirstName and Customer.LastName);
3. databinding with user control for complex object properties (Customer.DefaultAddress, Customer.InvoiceAddress
and Customer.DeliveryAddress)

Quick walkthrough
--

* Customer and Address implements INotifyPropertyChanged for databinding and IDataErrorInfo for validation;
* NameAddress is an UserControl that wraps a TextBox by simply exposing its Text property;
* AddressControl is an UserControl for Address POCO -- using internally both a BindingSource
and an ErrorProvider.