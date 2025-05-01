namespace Eonix.Core.Systems.Interfaces;



public interface IProgress<T>
{
    T Value { get; set; }
    
}