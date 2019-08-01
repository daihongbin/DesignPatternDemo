using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var singletonForSingleThread = SingleThrad_Signleton.Instance;

            var singletonForMultiThread = MultiThread_Singleton.Instance;

            var singletonForStatic = Static_Singleton.instance;

            var singletonForStatic2 = Static_Singleton2.instance;
            Console.ReadLine();
        }
    }
}
