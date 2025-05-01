using Eonix.Core.Systems.Interfaces;

namespace Eonix.Core.Systems.Producers;

public class Producer(
    string name, string description, double baseCost, double baseProduction) : IProducer
{

    public string Name { get; set; } = name;
    public string Description { get; set; } = description;
    public int Level { get; set; } = 1;
    public double BaseCost { get; set; } = baseCost;
    public double BaseProduction { get; set; } = baseProduction;
    
    // Constants for production formula
    const double LevelMultiplier = 1.5;
    const double EfficiencyFactor = 0.1;
    
    
    // Formula: BaseProduction * (LevelMultiplier * Level) * (1 + EfficiencyFactor * Level)
    // This creates exponential growth as levels increase
    public double GetCurrentProduction() =>
        BaseProduction * (LevelMultiplier * Level) * (1 + EfficiencyFactor * Level);
    
    
}