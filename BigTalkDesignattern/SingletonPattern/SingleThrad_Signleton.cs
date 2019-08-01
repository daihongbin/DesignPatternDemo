using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    /// <summary>
    /// 单线程单例模式实现
    /// </summary>
    public class SingleThrad_Signleton
    {
        private static SingleThrad_Signleton instance = null;

        private SingleThrad_Signleton() { }

        public static SingleThrad_Signleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SingleThrad_Signleton();
                }

                return instance;
            }
        }
    }
}
