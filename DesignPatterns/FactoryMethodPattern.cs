using System;
/// <summary>
/// This is a creation pattern
/// </summary>
namespace IK.DesignPatterns
{

    public class TestClass
    {

    }

    public class StrategyCreator
    {
        TestClass factoryMethod()
        {
            return new TestClass();
        }
    }
    
    public class FactoryMethodPattern
    {
        public FactoryMethodPattern()
        {
        }
    }
}
