




namespace Fun01.src;

public class RunStaticFun
{
    public RunStaticFun()
    {
        //  Department Test
        IDepartment department = new DepAH42();
        ISection secRoom01 = new Room();
        ISection secCorridor01 = new Corridor();
        ISection secStairs01 = new Stairs();
        department.AddSection(secCorridor01);
        department.AddSection(secStairs01);
        department.AddSection(secRoom01);

        //department.PrintSections();


        //  Consumer Test
        //  Event if _pressure <= 100
        Console.WriteLine("\nConsumer Test");
        ConsumerManager consumerManager = secRoom01.GetConsumerManager();
        consumerManager.ConsumerPower.Pressure = 12;

        //  is overritten
        consumerManager.ConsumerWater.Pressure = 23;

        secRoom01.GetConsumerByTyp(ConsumerTyp.Water).Pressure = 200;
        secCorridor01.GetConsumerByTyp(ConsumerTyp.Air).Pressure = 10;
        department.PrintSectionConsumerValues();

        IConsumer consumer1 = secRoom01.GetConsumerByTyp(ConsumerTyp.Power);
        //Console.WriteLine("--> " + consumer1.Pressure);


        //  Print the List with pressure to low
        foreach (var item in Information.SectionMessages)
        {
            Console.WriteLine(item.ToString());
        }


        //  Device Test
        //_ = new RunDevice();
        DeviceManager deviceManager = new DeviceManager();
        deviceManager[new DeC671()] = DeviceTyp.NonMoveable;
        deviceManager[new DeA3B0()] = DeviceTyp.Moveable;
        deviceManager[new DeA6BC()] = DeviceTyp.Moveable;

        Console.WriteLine("Liste with Devices and choosen typ");
        deviceManager.PrintDevicesByTyp(DeviceManagerStaticFunctions.DecideTypMoveable);
        Console.WriteLine();
        deviceManager.PrintDevicesByTyp(DeviceManagerStaticFunctions.DecideTypNonMoveable);
    }
}

public static class Information
{
    public static IList<string> SectionMessages = new List<string>();
}

public class InfoSectionEventArgs : Exception
{
    private Exception _error;
    public Exception Error { get { return _error; } }

    private ConsumerTyp _identification;
    public ConsumerTyp Identification { get { return _identification; } }

    public string _ausnahme;
    public string Ausnahme { get { return _ausnahme; } }

    public InfoSectionEventArgs(Exception error, ConsumerTyp identification, string ausnahme)
    {
        _error = error;
        _identification = identification;
        _ausnahme = ausnahme;
    }

    public string GetSectionInformations()
    {
        return $"--> {this._identification} -- {this._ausnahme} -- {this._error}";
    }
}