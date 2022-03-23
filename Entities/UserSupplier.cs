namespace PurpleHardware;

public class UserSupplier
{
    public UserSupplier(string cpnj, string address)
    {
        CNPJ = cpnj;
        Address = address;
    }
    public string CNPJ { get; set; }
    public string Address { get; set; }

}
