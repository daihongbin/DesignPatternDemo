namespace SingletonSample
{
    //懒汉单例模式，延迟加载
    public class LazySingletonSample
    {
        private static LazySingletonSample instace = null;

        private static readonly object syncLocker = new object();

        public static LazySingletonSample GetInstance()
        {
            //第一重判断
            if (instace == null)
            {
                lock (syncLocker)
                {
                    //第二重判断
                    if (instace == null)
                    {
                        instace = new LazySingletonSample();
                    }
                }
            }
            return instace;
        }
    }
}
