namespace Eonix;

public interface IProducer 
{
    string Name { get; set; }
    string Description { get; set; }
    double BaseCost { get; set; }
    double BaseProduction { get; set; }
    
    double GetCurrentProduction();
    void Produce();
}