using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Fun01.src;


public class RunDevice
{
    public RunDevice()
    {
        Console.WriteLine("RunDevice");

        //DeviceManager deviceManager = new DeviceManager();
        //deviceManager[new DeC671()] = DeviceTyp.NonMoveable;
        //deviceManager[new DeA3B0()] = DeviceTyp.Moveable;

        //deviceManager.PrintDevicesByTyp( DeviceManagerStaticFunctions.DecideTypMoveable);

    }

    //public DeviceTyp DecideTypMoveable()
    //{
    //    return DeviceTyp.Moveable;
    //}

    //public DeviceTyp DecideTypNonMoveable()
    //{
    //    return DeviceTyp.NonMoveable;
    //}

}

public static class DeviceManagerStaticFunctions
{
    public static DeviceTyp DecideTypMoveable()
    {
        return DeviceTyp.Moveable;
    }

    public static DeviceTyp DecideTypNonMoveable()
    {
        return DeviceTyp.NonMoveable;
    }
}

public enum DeviceTyp
{
    Moveable,
    NonMoveable
};

public class DeviceManager
{
    private Dictionary<IDevice, DeviceTyp> _devices = new Dictionary<IDevice, DeviceTyp>();

    public DeviceTyp this[IDevice device]
    {
        get { return _devices[device]; }
        set { _devices.Add(device, value); }
    }

    public IList<IDevice> GetAllDevices()
    {
        return null;
    }
    public IDevice GetDeviceById(string id)
    {
        return null;
    }
    public IList<IDevice> AppendDevices(IList<IDevice> devices)
    {
        return null;
    }

    public void PrintDevicesByTyp(Func<DeviceTyp> TypTypDeleFunc)
    {
        foreach (var item in _devices)
        {
            if (TypTypDeleFunc() == item.Value)
            {
                Console.WriteLine("--> Value: " + item.Value + " Key: " + item.Key.Name);
            }
        }
    }
}

public interface IDevice
{
    string IdString { get; set; }
    string Name { get; set; }
    void PrintDevice();
}

public class Devive : IDevice
{
    public virtual string IdString { get; set; } = string.Empty;
    public virtual string Name { get; set; } = string.Empty;

    public virtual void PrintDevice()
    {
        Console.WriteLine(this.Name);
    }
}

public class DeA6BC : Devive
{
    public override string IdString { get => base.IdString; set => base.IdString = value; }
    public override string Name { get; set; } = "DeA6BC";
    public override void PrintDevice()
    {
        base.PrintDevice();
    }
}

public class DeC671 : Devive
{
    public override string IdString { get => base.IdString; set => base.IdString = value; }
    public override string Name { get; set; } = "DeC671";
    public override void PrintDevice()
    {
        base.PrintDevice();
    }
}

public class DeA3B0 : Devive
{
    public override string IdString { get => base.IdString; set => base.IdString = value; }
    public override string Name { get; set; } = "DeA3B0";
    public override void PrintDevice()
    {
        base.PrintDevice();
    }
}