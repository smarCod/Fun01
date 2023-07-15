




namespace Fun01.src;


public interface IConsumer
{
    int Id { get; set; }
    ConsumerTyp ConsumptionType { get; set; }
    float Consumption { get; set; }     //  Verbrauch
    float Pollution { get; set; }       //  Verschmutzung
    float Pressure { get; set; }

    string PrintValues();
}

public class Consumer : ConsumerSender, IConsumer
{
    public int Id { get; set; }
    public virtual ConsumerTyp ConsumptionType { get; set; }

    private float _consumption;
    public float Consumption
    {
        get { return _consumption; }
        set { _consumption = value; }
    }

    private float _pollution;
    public float Pollution
    {
        get { return _pollution; }
        set { _pollution = value; }
    }

    private float _pressure;
    public float Pressure
    {
        get
        {
            return _pressure;
        }
        set
        {
            _pressure = value;
            if (_pressure <= 100)
            {
                CheckPressureToLow(this);
            }

        }
    }

    public string PrintValues()
    {
        return $"\t{this.ConsumptionType} Consumption {this.Consumption} Pollution {Pollution} Pressure {Pressure}";
    }
}

public class BaseConsumer : Consumer
{
    public override ConsumerTyp ConsumptionType => ConsumerTyp.Base;
}

public class Water : Consumer
{
    public override ConsumerTyp ConsumptionType => ConsumerTyp.Water;
}
public class Air : Consumer
{
    public override ConsumerTyp ConsumptionType => ConsumerTyp.Air;
}
public class Power : Consumer
{
    public override ConsumerTyp ConsumptionType => ConsumerTyp.Power;
}