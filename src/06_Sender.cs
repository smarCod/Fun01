



namespace Fun01.src;



public class ConsumerSender
{
    public ConsumerSender()
    {
        this.PressureToLowEventArgs += new EventHandler<InfoSectionEventArgs>(this.ConsumerPressureToLow);
    }

    public event EventHandler<InfoSectionEventArgs>? PressureToLowEventArgs;

    public void CheckPressureToLow(IConsumer consumer)
    {
        this.OnPressureEventConsumerPressureToLow(new InfoSectionEventArgs(
            new Exception(), consumer.ConsumptionType, consumer.Pressure.ToString()), PressureToLowEventArgs);

    }
}