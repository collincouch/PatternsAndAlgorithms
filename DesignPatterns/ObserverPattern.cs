using System;
using System.Collections.Generic;
/// <summary>
/// Used to keep track of changes to an object that I an
/// observing.  Example is
/// when a mobile app needs to updated when the
/// geo location of mobile phone changes.
/// </summary>
///
///Also Call PubSub pattern
namespace IK.DesignPatterns
{

    public class MobilePhone
    {
        double lon;
        double lat;
        List<Observer> os = new List<Observer>();

        public void move()
        {
            lon += 3;
            lat += 3;
            notifyLocationChanged();
        }

        public void register(Observer o)
        {
            os.Add(o);
        }
        private void notifyLocationChanged()
        {
            foreach(var o in os)
            {
                o.update(lon, lat);
            }
        }
    }

    public abstract class Observer
    {
        public abstract void update(double lon, double lat);

    }

    public class MobileApp : Observer
    {
        public override void update(double lon, double lat)
        {
            Console.WriteLine(lon + "-" + lat);
        }
    }
    public class ObserverPattern
    {
        public void TesetObserverPattern()
        {

            MobilePhone phone = new MobilePhone();
            phone.register(new MobileApp());
            phone.move();
            phone.move();
            phone.move();
        }
    }
}
