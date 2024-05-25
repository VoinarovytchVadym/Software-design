using System;
using Decorator.Heroes;
using Decorator.Inventories;

namespace Decorator;

public class Program
{
    public static void Main()
    {
        IHero warrior = new Warrior("Warrior", new ArtifactsInventory(new WeaponsInventory(new ClothesInventory())));
        Console.WriteLine(warrior.Inventory.Equip("artifact"));
     
        IHero mage = new Mage("Mage", new WeaponsInventory(new ArtifactsInventory(new ClothesInventory())));
        Console.WriteLine(mage.Inventory.Equip("sword"));

        IHero paladin = new Palladin("Paladin", new ClothesInventory(new WeaponsInventory(new ArtifactsInventory())));
        Console.WriteLine(paladin.Inventory.Equip("hat"));
    }
}