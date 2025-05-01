using Eonix.Core.Systems.Interfaces;
namespace Eonix.Core.Systems.Models;

public class Level : Interfaces.ILevel<int>
{
    public int Value { get; set; }
    public string? Name { get; set; }
}