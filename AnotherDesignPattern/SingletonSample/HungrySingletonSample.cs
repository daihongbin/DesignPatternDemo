namespace SingletonSample
{
    /// <summary>
    /// 此处为饿汉单例模式
    /// </summary>
    public class HungrySingletonSample
    {
        //私有静态变量，存储唯一实例
        private static readonly HungrySingletonSample instance = new HungrySingletonSample();

        private HungrySingletonSample()
        {

        }

        public static HungrySingletonSample GetInstance()
        {
            return instance;
        }
    }
}
