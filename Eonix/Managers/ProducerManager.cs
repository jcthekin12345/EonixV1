using System.Collections;
using Eonix.Core.Systems.Producers;

namespace Eonix.Managers;

public class ProducerManager : IEnumerable<Producer>
{
    readonly List<Producer> producers = new();

    public IEnumerator<Producer> GetEnumerator() => producers.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public void AddProducer(Producer producer)
    {
        producers.Add(producer);
    }

    public void SortProducersByPrice()
    {
        producers.Sort(); // uses the IComparable implementation in Producer
    }
}