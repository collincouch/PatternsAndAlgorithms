using System;

/// <summary>
/// Used if you have a simple object that may
/// be expensive.  Therefore we create a proxy
/// </summary>
namespace IK.DesignPatterns
{

    abstract class Greeter
    {
        public abstract string greet();
    }

    class RealGreeter:Greeter
    {
       

        public override string greet()
        {
            return "Hi there";
        }
    }


    class GreeterProxy : Greeter
    {
        Greeter greeter;

        public override string greet()
        {

            if (greeter == null) greeter = new RealGreeter();
            //lookup greeter object on network
            //check security, etc.
            //send a request to cal "greet method"

            return greeter.greet();
        }
    }

    public class ProxyPattern
    {
        
        public void TestProxyPattern()
        {
            Greeter greeter = new GreeterProxy();
            Console.WriteLine(greeter.greet());
            Console.WriteLine(greeter.greet());
        }
    }
}
