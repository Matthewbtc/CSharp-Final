using System;

public class Inventory
public static void Main()
{
List<string> items = new List<string>();
items.Add("Potion");
items.Add("Spell Powder");
items.Add("Run Potion");

items.RemoveAt(1);
Console.WriteLine(items.Count);

}