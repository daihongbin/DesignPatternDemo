using System;

namespace FactoryMethodSample
{
    public interface ILogger
    {
        void WriteLog();
    }

    public class FileLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("文件日志记录。。。。。。");
        }
    }

    public class DatabaseLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("数据库日志记录。。。。。。");
        }
    }
}
