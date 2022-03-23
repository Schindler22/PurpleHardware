namespace PurpleHardware;

public class UserClient: User
{
    public UserClient(string name, string lastName, string mail, 
                    string phone, string password, string cpf, string address) 
                    : base(name, lastName, mail, phone, password)
    {
        Cpf = cpf;
        Address = address;
    }

    public string Cpf { get; set; }
    public string Address { get; set; }

}
