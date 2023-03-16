﻿namespace ACM.BL;
public class Customer
{
    public String emailAddress { get; set; }
    public int customerID{ get; private set; }
    public String firstName { get; set; }
    public String lastName { get; set; }
    public String fullName { get {
            return firstName + ", " + lastName;} }


    public bool Validate()
    {
        bool isValid = true;

        if (String.IsNullOrWhiteSpace(lastName)) isValid = false;
        if (String.IsNullOrWhiteSpace(emailAddress)) isValid = false;


        return isValid;
    }

    public Customer Retrieve(int customerID)
    {
        return new Customer();
    }

    public bool save()
    {
        return true;
    }
}
