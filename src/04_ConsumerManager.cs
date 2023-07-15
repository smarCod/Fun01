using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun01.src;


public enum ConsumerTyp
{
    Base,
    Water,
    Air,
    Power
};

public class ConsumerManager
{
    private IConsumer _consumerBase;
    private IConsumer _consumerWater;
    private IConsumer _consumerAir;
    private IConsumer _consumerPower;

    private IConsumer GetBase(IConsumer consumerBase)
    {
        if (_consumerBase == null)
            _consumerBase = consumerBase;
        return _consumerBase;
    }
    public IConsumer ConsumerBase
    {
        get { return _consumerBase; }
        set { _consumerBase = value; }
    }

    private IConsumer GetWater(IConsumer water)
    {
        _consumerWater ??= water;
        return _consumerWater;
    }
    public IConsumer ConsumerWater
    {
        get { return _consumerWater; }
        set { _consumerWater = value; }
    }

    private IConsumer GetAir(IConsumer air)
    {
        _consumerAir ??= air;
        return _consumerAir;
    }
    public IConsumer ConsumerAir
    {
        get { return _consumerAir; }
        set { _consumerAir = value; }
    }

    private IConsumer GetPower(IConsumer power)
    {
        _consumerPower ??= power;
        return _consumerPower;
    }
    public IConsumer ConsumerPower
    {
        get { return _consumerPower; }
        set { _consumerPower = value; }
    }

    public ConsumerManager() : this(new BaseConsumer(), new Water(), new Air(), new Power())
    {
    }

    public ConsumerManager(IConsumer consumerBase, IConsumer water, IConsumer air, IConsumer power)
    {
        _consumerBase = GetBase(consumerBase);
        _consumerWater = GetWater(water);
        _consumerAir = GetAir(air);
        _consumerPower = GetPower(power);
    }

    public void PrintWaterPressure()
    {
        Console.WriteLine("--> " + _consumerWater.Pressure);
    }

    public IConsumer GetBaseConsumer()
    {
        return _consumerBase;
    }
    public IConsumer GetWaterConsumer()
    {
        return _consumerWater;
    }
    public IConsumer GetAirConsumer()
    {
        return _consumerAir;
    }
    public IConsumer GetPowerConsumer()
    {
        return _consumerPower;
    }

    public string PrintConsumerValues()
    {
        return $"\t{_consumerAir.PrintValues()} \n\t {_consumerWater.PrintValues()} \n\t {_consumerPower.PrintValues()}";
    }
}