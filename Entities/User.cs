using System;

namespace PurpleHardware;

public class User
{
    public User(string name, string lastName, string mail, string phone, string password)
    {
        Id = Guid.NewGuid();
        Name = name;
        LastName = lastName;
        Mail = mail;
        Phone = phone;
        Password = password;
    }
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Mail { get; set; }
    public string Phone { get; set; }
    public string Password { get; set; }
}
