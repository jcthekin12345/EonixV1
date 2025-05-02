using Eonix.Core.Systems.Interfaces;

namespace Eonix.Core.Utils;

public class ProducerUtils
{
    public static void ShowName(IProducer producer)
    {
        Console.WriteLine(producer.Name);
    }

    public static void EditName(IProducer producer, string newName)
    {
        producer.Name = newName;
    }
}