using System;

namespace StrategyConsoleApp
{
    /// <summary>
    /// 抽象算法类
    /// </summary>
    abstract class Strategy
    {
        /// <summary>
        /// 算法方法
        /// </summary>
        public abstract void AlgorithmInterface();
    }

    /// <summary>
    /// 具体算法A
    /// </summary>
    class ConcreteStrategyA : Strategy
    {
        /// <summary>
        /// 算法A实现方法
        /// </summary>
        public override void AlgorithmInterface()
        {
            Console.WriteLine("算法A实现");
        }
    }

    /// <summary>
    /// 具体算法B
    /// </summary>
    class ConcreteStrategyB : Strategy
    {
        /// <summary>
        /// 算法B实现方法
        /// </summary>
        public override void AlgorithmInterface()
        {
            Console.WriteLine("算法B实现");
        }
    }

    /// <summary>
    /// 具体算法C
    /// </summary>
    class ConcreteStrategyC : Strategy
    {
        /// <summary>
        /// 算法C实现方法
        /// </summary>
        public override void AlgorithmInterface()
        {
            Console.WriteLine("算法C实现");
        }
    }
}