namespace Eonix;

public class Game
{
    double money_ = 0.0;
    List<IProducer> _producers { get; set; } = new();
    public Game()
    {
        _producers.Add(new AutoClicker());
    }

    public void Run()
    {
        while (true)
        {
            Thread.Sleep(1000);
            Console.WriteLine($"Money: {money_}");
            foreach (var producer in _producers)
            {
                money_ += producer.GetCurrentProduction();
            }
        }
    }
}