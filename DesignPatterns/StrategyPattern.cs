using System;
/// <summary>
/// Used when you want to exchange an algorthim
/// at runtime or make it configurable.
/// An example is when you want to change
/// a compression algorthim on a file at runtime.
/// </summary>
namespace IK.DesignPatterns
{
    public class TestFile
    {
        public CompressionStragegy strategy;
        public void compress()
        {
            strategy.compress();
        }
    }

    public abstract class CompressionStragegy
    {
        public abstract void compress();
    }


    class ZipCompression : CompressionStragegy
    {
        public override void compress()
        {
            Console.WriteLine("Complression with ZIP");
        }
    }

    class RarCompression : CompressionStragegy
    {
        public override void compress()
        {
            Console.WriteLine("Complression with RAR");
        }
    }
    public class StrategyPattern
    {

        

        public void TestStrategyPattern()
        {

            TestFile f = new TestFile();
            f.strategy = new ZipCompression();
            f.compress();

        }
    }
}
