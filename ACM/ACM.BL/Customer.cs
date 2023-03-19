using System;
using Acme.common;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ACM.BL;
public class Customer : EntityClass, ILoggable
{
    public String emailAddress { get; set; }
    public int customerID{ get; private set; }
    public String firstName { get; set; }
    public String lastName { get; set; }
    public String fullName { get {
            return firstName + ", " + lastName;} }
    public List<Address> addressList { get; set; }
    public int customerType { get; set; } 

    public Customer(): this(0)
    {

    }

    public Customer(int customerID)
    {
        this.customerID = customerID;
        addressList = new List<Address>( );
    }

    public override bool Validate()
    {
        bool isValid = true;

        if (String.IsNullOrWhiteSpace(lastName)) isValid = false;
        if (String.IsNullOrWhiteSpace(emailAddress)) isValid = false;


        return isValid;
    }

    public string Log() =>
        $"{customerID}: {fullName} Email: {emailAddress} Status: {entityState.ToString()}";

    public override string ToString() => fullName;
}

