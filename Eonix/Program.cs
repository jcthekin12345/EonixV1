using Eonix.Core.Systems.Interfaces;
using Eonix.Core.Systems.Producers;
using System.Collections;
namespace Eonix;

class Program
{
    static void Main(string[] args)
    {
        Producer[] upgradeShop = new Producer[3];
        upgradeShop[0] = new ("Friend", "A good buddy to help ya along the way",10.5, 0.1);
        upgradeShop[1] = new("Worker", "A good office worker", 100, 0.5);
        upgradeShop[2] = new("Manager", "Will take charge of your company", 150, 0.9);

        foreach (var upgrades in upgradeShop)
        {
            ShowLn(upgrades);
        }
    }

    static void Show<T>(T? input)
    {
        Console.Write(input);
    }

    static void ShowLn<T>(T? input)
    {
        Console.WriteLine(input);
    }
}