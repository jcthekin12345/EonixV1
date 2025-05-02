using Eonix.Core.Systems.Producers;
using Eonix.Core.Utils;

namespace Eonix;

class Program
{
    static void Main(string[] args)
    {
        var upgradeShop = new Producer[3];
        upgradeShop[0] = new Producer("Friend", "A good buddy to help ya along the way", 0.5, 0.2);
        upgradeShop[1] = new Producer("Worker", "A good office worker", 100, 0.3);
        upgradeShop[2] = new Producer("Manager", "Will take charge of your company", 150, 0.4);
        var num = 0;
        foreach (var upgrades in upgradeShop)
        {
            ProducerUtils.EditName(upgrades, $"Batman {num++ + 1}");
            ShowLn($"\nPrices: {upgrades.GetUpgradeCost():C}");
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