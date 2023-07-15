







namespace Fun01.src;

public interface ISection
{
    string IdentificationSection { get; set; }
    IConsumer GetConsumerByTyp(ConsumerTyp consumerTyp);
    ConsumerManager GetConsumerManager();
    DeviceManager GetDeviceManager();

    void PrintConsumerValues();
}

public class Section : ISection
{
    private ConsumerManager _consumerManager = new ConsumerManager();
    private DeviceManager _deviceManager = new DeviceManager();

    public virtual string IdentificationSection { get; set; } = "Base";

    public Section() : this(new ConsumerManager(), new DeviceManager())
    {
    }
    public Section(ConsumerManager consumerManager, DeviceManager deviceManager)
    {
        _consumerManager = consumerManager;
        _deviceManager = deviceManager;
    }

    public IConsumer GetConsumerByTyp(ConsumerTyp consumerTyp)
    {
        switch (consumerTyp)
        {
            case ConsumerTyp.Water:
                Console.WriteLine("water case");
                return _consumerManager.GetWaterConsumer();
            case ConsumerTyp.Air:
                Console.WriteLine("air case");
                return _consumerManager.GetAirConsumer();
            case ConsumerTyp.Power:
                Console.WriteLine("power case");
                return _consumerManager.GetPowerConsumer();
        }
        return _consumerManager.GetBaseConsumer();

    }


    public void PrintConsumerValues()
    {
        Console.WriteLine(_consumerManager.PrintConsumerValues());
    }

    // Dem Devicemanager eine Liste mit Devices �bergeben
    public void AddDevicesToSection(Func<IList<IDevice>> deviceListe)
    {
        Console.WriteLine();
    }
    public ConsumerManager GetConsumerManager()
    {
        return _consumerManager;
    }

    public DeviceManager GetDeviceManager()
    {
        return _deviceManager;
    }
}

public class Corridor : Section
{
    public override string IdentificationSection { get; set; } = "Corridor";
}

public class Room : Section
{
    public override string IdentificationSection { get; set; } = "Room";

}

public class Stairs : Section
{
    public override string IdentificationSection { get; set; } = "Stairs";

}