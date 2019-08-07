using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    /// <summary>
    /// 多线程单例模式，线程安全
    /// </summary>
    class MultiThread_Singleton
    {
        //volatile 保证严格意义的多线程编译器在代码编译时对指令不进行微调。去掉可能导致线程不安全
        private static volatile MultiThread_Singleton instance = null;

        private static object lockHelper = new object();

        private MultiThread_Singleton() { }

        public static MultiThread_Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockHelper)
                    {
                        if (instance == null)
                        {
                            instance = new MultiThread_Singleton();
                        }
                    }
                }

                return instance;
            }
        }
    }
}
