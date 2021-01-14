using System;
/// <summary>
/// Example shows how a mobile phone handles
/// an incoming call when the state can be in
/// slient, vibrate or sound state.
/// </summary>
namespace IK.DesignPatterns
{

    public class Phone{
        public RingState r = new SoundState();

        public void ring()
        {
            r.ring();
        }

        public void volumnUp()
        {
            r = r.nextStateVolumnUp();
        }

        public void volumnDown()
        {
            r = r.nextStateVolumnDown();
        }
    }

    public abstract class RingState
    {
        public abstract void ring();
        public abstract RingState nextStateVolumnUp();
        public abstract RingState nextStateVolumnDown();
    }


    public class SoundState : RingState
    {
        public override RingState nextStateVolumnDown()
        {
            return new VibrateState();
        }

        public override RingState nextStateVolumnUp()
        {
            return this;
        }

        public override void ring()
        {
            Console.WriteLine("Phone makes a sound");
        }
    }

    public class VibrateState : RingState
    {
        public override RingState nextStateVolumnDown()
        {
            return this;
        }

        public override RingState nextStateVolumnUp()
        {
            return new SoundState();
        }

        public override void ring()
        {
            Console.WriteLine("Phone is vibrating");
        }
    }

    public class SlientState : RingState
    {
        public override RingState nextStateVolumnDown()
        {
            return this;
        }

        public override RingState nextStateVolumnUp()
        {
            return new VibrateState();
        }

        public override void ring()
        {
            Console.WriteLine(".......");
        }
    }
    public class StatePattern
    {
        public void TestStatePattern()
        {

            Phone p = new Phone();
            p.ring();

            p.volumnDown();
            p.ring();

            p.volumnDown();
            p.ring();

            p.volumnDown();
            p.ring();

            p.volumnUp();
            p.volumnUp();
            p.volumnUp();
            p.ring();



        }
    }
}
