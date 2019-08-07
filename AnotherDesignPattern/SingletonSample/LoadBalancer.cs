using System;
using System.Collections.Generic;
using System.Linq;

namespace SingletonSample
{
    /// <summary>
    /// 假装自己是一个负载均衡器
    /// </summary>
    public class LoadBalancer
    {
        //私有静态变量，存储唯一实例
        private static LoadBalancer instance = null;

        private IList<CustomServer> serverList = null;

        //私有构造函数
        private LoadBalancer()
        {
            serverList = new List<CustomServer>();
        }

        //公共静态方法，返回唯一实例
        public static LoadBalancer GetLoadBalancer()
        {
            if (instance == null)
            {
                instance = new LoadBalancer();
            }

            return instance;
        }

        public void AddServer(CustomServer server)
        {
            serverList.Add(server);
        }

        public void RemoveServer(string serverName)
        {
            var server = serverList.FirstOrDefault(r => r.Name == serverName);
            serverList.Remove(server);
        }

        private Random rand = new Random();
        public CustomServer GetServer()
        {
            int index = rand.Next(serverList.Count);
            return serverList[index];
        }
    }

    public class CustomServer
    {
        public string Name { get; set; }

        public int Size { get; set; }
    }
}
