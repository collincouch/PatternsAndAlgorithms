using System;
/// <summary>
/// Only when you want to have one instance of a class
/// 
/// </summary>
///

///Singleton is considered hamful
namespace IK.DesignPatterns
{
    public sealed class Throttler
    {
        private static Throttler instance = null;
        private static readonly object padlock = new object();

        //you would not want to create multiple
        //instaance of throttler
        private Throttler()
        {

        }

        public static Throttler Instance
        {
            get
            {
                lock(padlock)
                {                    
                    if(instance==null)
                    {
                        instance = new Throttler();
                    }
                    return instance;                    
                }
            }
        }
        public void throttle()
        {
            ///do throttle logic here
        }
    }
    public class SingletonPattern
    {
        public SingletonPattern()
        {
        }
    }
}
