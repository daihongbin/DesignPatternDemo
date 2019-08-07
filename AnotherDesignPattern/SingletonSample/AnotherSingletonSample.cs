namespace SingletonSample
{
    public class AnotherSingletonSample
    {
        public static AnotherSingletonSample GetInstance()
        {
            return Nested.instance;
        }

        private AnotherSingletonSample()
        {

        }

        class Nested
        {
            static Nested()
            {

            }

            internal static readonly AnotherSingletonSample instance = new AnotherSingletonSample();
        }
    }
}
