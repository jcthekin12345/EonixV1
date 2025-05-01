namespace Eonix.Core.Systems.Interfaces;



public interface IProgress<T>
{
    T Value { get; set; }
    string? Name { get; set; }

    void DisplayInfo()
    {
        Console.WriteLine($"{Name}: {Value}");
    }
    
}