using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    //静态单例实现
    class Static_Singleton
    {
        public static readonly Static_Singleton instance = new Static_Singleton();

        private Static_Singleton() { }
    }

    //两个类等价
    class Static_Singleton2
    {
        public static readonly Static_Singleton2 instance;

        static Static_Singleton2()
        {
            instance = new Static_Singleton2();
        }

        private Static_Singleton2() { }
    }
}
