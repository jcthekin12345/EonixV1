namespace Eonix;

public interface Producer 
{
    string Name { get; set; }
    string Description { get; set; }
    string Type { get; set; } 
    double BaseCost { get; set; }
    double BaseProduction { get; set; }
    
    void Produce();
}