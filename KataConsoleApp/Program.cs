// See https://aka.ms/new-console-template for more information
using Carts;
using Catalog;

var productCatalog = new ProductCatalog();

var myCart = new Cart();

var nitendoSwitch = productCatalog.GetProduct("Classic T-Shirt", 10);
var playstation = productCatalog.GetProduct("Longsleeve T-Shirt", 5);
var pc = productCatalog.GetProduct("Classic Cap", 5);
var pcGamer = productCatalog.GetProduct("Premium Cap", 2);

myCart.AddItem(nitendoSwitch!.Name!, 10, nitendoSwitch.Price, nitendoSwitch.IsGameConsole);
myCart.AddItem(playstation!.Name!, 5, playstation.Price, playstation.IsGameConsole);
myCart.AddItem(pc!.Name, 5, pc.Price, pc.IsGameConsole);
myCart.AddItem(pcGamer!.Name, 2, pcGamer.Price, pcGamer.IsGameConsole);

// Initial Price
Console.WriteLine("Initial Total Price");
Console.WriteLine($"myCart total: {myCart.GetPrice(new Promos[] { })}");

// Day 1
Console.WriteLine("Day 1: promo1");
Console.WriteLine($"myCart total: {myCart.GetPrice(new Promos[] { Promos.Promo1 })}");

// Day 2
Console.WriteLine("Day 2: promo2 + promo3");
Console.WriteLine($"myCart total: {myCart.GetPrice(new Promos[] { Promos.Promo2, Promos.Promo3 })}");

// Day 3
Console.WriteLine("Day 3: promo4");
Console.WriteLine($"myCart total: {myCart.GetPrice(new Promos[] { Promos.Promo4 })}");



