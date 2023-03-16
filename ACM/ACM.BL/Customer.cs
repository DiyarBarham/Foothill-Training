namespace ACM.BL;
public class Customer
{
    public String emailAddress { get; set; }
    public int customerID{ get; private set; }
    public String firstName { get; set; }
    public String lastName { get; set; }
    public String fullName { get {
            return firstName + ", " + lastName;} }
     
}

