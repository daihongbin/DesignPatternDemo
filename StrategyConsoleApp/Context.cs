using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyConsoleApp
{
    /// <summary>
    /// 上下文
    /// </summary>
    class Context
    {
        private Strategy strategy;

        //初始化时，传入具体的策略对象
        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }

        //上下文接口
        //根据具体的策略对象调用具体的策略方法
        public void ContextInterface()
        {
            strategy.AlgorithmInterface();
        }
    }
}
