// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;

Console.WriteLine("Checkpoint 2 Level 1");

Console.WriteLine("---------------------------");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Hi! Let's begin to select your items!");
Console.WriteLine("----------------------------");
Console.ForegroundColor = ConsoleColor.White;
List<Item> ItemList = new List<Item>();

while (true)
{
    Console.WriteLine("Enter a category! Stop and show list by writing 'q'.");
    string category = Console.ReadLine();


    //if(input=="q")
    if (category.Trim().ToLower() == "q") //all versions of q will leed to exit
    {
        break;
    }

    Console.WriteLine("Enter a product! Stop and show list by writing 'q'.");
    string product = Console.ReadLine();

    if (product.Trim().ToLower() == "q") //all versions of q will leed to exit
    {
        break;
    }

    Console.WriteLine("Enter a price! Stop and show list by writing 'q'.");
    int price = int.Parse(Console.ReadLine());

    if (price.ToString().Trim().ToLower() == "q") //all versions of q will leed to exit
    {
        break;
    }

    //Create objects + add to list
    Item products = new Item(category, product, price);
    ItemList.Add(products);
}

//Products in list, green color;
Console.WriteLine("-----------");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Here are your selected products:");
Console.WriteLine("-----------");
Console.WriteLine("Category".PadRight(20) + "Product".PadRight(20) + "Price");

foreach (var Item in ItemList)

{
    Console.WriteLine(Item.Category.PadRight(20) + Item.Product.PadRight(20) + Item.Price);//Show list as table
}

Console.WriteLine("-----------");
int totalPrice = ItemList.Sum(x => x.Price);
Console.WriteLine("Your total price in kronor is ".PadRight(40) + totalPrice);
Console.ForegroundColor = ConsoleColor.White;

//create class - added to library 

class Item
{
    public Item(string category, string product, int price)
    {
        Category = category;
        Product = product;
        Price = price;

    }

    public string Category { get; set; }
    public string Product { get; set; }
    public int Price { get; set; }

}

