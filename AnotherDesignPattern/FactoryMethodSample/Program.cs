using System;

namespace FactoryMethodSample
{
    //工厂方法模式
    class Program
    {
        static void Main(string[] args)
        {
            //ILoggerFactory factory = new FileLoggerFactory(); //可通过引入配置文件实现
            LoggerFactory factory = (LoggerFactory)AppSettingHelper.GetLoggerFactoryInstance();
            if (factory == null)
            {
                return;
            }

            ILogger logger = factory.CreateLogger();
            logger.WriteLog();

            Console.ReadLine();
        }
    }
}
