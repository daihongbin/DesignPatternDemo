namespace FactoryMethodSample
{
    public interface ILoggerFactory
    {
        ILogger CreateLogger();
    }

    public class FileLoggerFactory : LoggerFactory
    {
        public override ILogger CreateLogger()
        {
            //创建文件日志记录器
            ILogger logger = new FileLogger();

            //创建文件，代码省略

            return logger;
        }
    }

    public class DatabaseLoggerFactory : LoggerFactory
    {
        public override ILogger CreateLogger()
        {
            //连接数据库，代码省略

            //创建数据库日志记录器对象

            ILogger logger = new DatabaseLogger();

            //初始化数据库日志记录器 代码省略

            return logger;
        }
    }
}
