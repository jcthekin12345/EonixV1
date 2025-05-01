namespace Eonix.Core.Systems.Interfaces;

public interface IProducer 
{
    
    string Name { get; set; }
    string Description { get; set; }
    int Level { get; set; }
    double BaseCost { get; set; }
    double BaseProduction { get; set; }
    double GetCurrentProduction();
    
}