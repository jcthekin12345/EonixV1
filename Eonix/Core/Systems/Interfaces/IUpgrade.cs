namespace Eonix.Core.Systems.Interfaces;

public interface IUpgrade<T> : IComparable<T>
{
    T Level { get; set; }

    T GetLevel();
}