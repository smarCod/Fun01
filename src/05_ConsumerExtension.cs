using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Fun01.src;

public static class ConsumerExtension
{

    public static void ConsumerPressureToLow(this ConsumerSender consumerSender, Object? sender, InfoSectionEventArgs infoSectionEventArgs)
    {
        //Console.WriteLine("Pressure to Low: " + infoSectionEventArgs.GetSectionInformations());
        Information.SectionMessages.Add(infoSectionEventArgs.GetSectionInformations());
    }

    public static void OnPressureEventConsumerPressureToLow(this ConsumerSender consumerSender, InfoSectionEventArgs infoSectionEventArgs, EventHandler<InfoSectionEventArgs> PressureToLowEventArgs)
    {
        if (PressureToLowEventArgs != null)
        {
            PressureToLowEventArgs(PressureToLowEventArgs, infoSectionEventArgs);
        }
        else
        {
            throw infoSectionEventArgs.Error;
        }
    }
}
