namespace Eonix;

public class AutoClicker : IProducer
{
    public string Name { get; set; } = "AutoClicker";
    public string Description { get; set; } = "A clicks for you while you watch the money go up!";
    public string Type { get; set; } = "Upgrade";
    public double BaseCost { get; set; } = 10.99;
    public double BaseProduction { get; set; } = 0.5;

    public double GetCurrentProduction()
    {
        return BaseProduction;
    }
    
    public void Produce()
    {
        var production = 0.0;
        Console.WriteLine("AutoClicker Produced");
        production += GetCurrentProduction();
        Console.WriteLine($"Production: {production}");
    }
    
}