namespace InterfaceSagretion;

interface IWorkerGood
{
    void Work();
}

class GoodWorker : IWorkerGood
{
    public void Work()
    {
        Console.WriteLine("Working");
    }
}

interface IEater
{
    void Eat();
}

interface ISleeper
{
    void Sleep();
}

class BetterWorker : IWorkerGood, IEater, ISleeper
{
    public void Work()
    {
        Console.WriteLine("Working");
    }

    public void Eat()
    {
        Console.WriteLine("Eating");
    }

    public void Sleep()
    {
        Console.WriteLine("Sleeping");
    }
}

class Program
{
    static void Main()
    {
        IWorkerGood goodWorker = new GoodWorker();
        goodWorker.Work();

        Console.WriteLine();

        BetterWorker betterWorker = new BetterWorker();
        betterWorker.Work();
        betterWorker.Eat();
        betterWorker.Sleep();
    }
}
