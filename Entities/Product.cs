using System;

namespace PurpleHardware;

public class Product
{
    // public Product(string name, string description, string brand, double buyPrice, double sellPrice){
    //     Id = Guid.NewGuid();
    //     Name = name;
    //     Description = description;
    //     Brand = brand;
    //     BuyPrice = buyPrice;
    //     SellPrice = sellPrice;
    // }

    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Brand { get; set; }
    //public Guid? SupplierId { get; set; }
    public double BuyPrice { get; set; }
    public double SellPrice { get; set; }

}
