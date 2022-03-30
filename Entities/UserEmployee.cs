namespace PurpleHardware;

public class UserEmployee: User
{
    public UserEmployee(string name, string lastName, string mail, string phone, string password, 
                        string department, string position, string registry) 
                        : base(name, lastName, mail, phone, password)
    {
        Department = department;
        Position = position;
        Registry = registry;
    }

    public string Department { get; set; }
    public string Position { get; set; }
    public string Registry { get; set; }

}
