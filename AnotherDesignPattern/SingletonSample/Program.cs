using System;

namespace SingletonSample
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 普通单例测试
            /*
            LoadBalancer balancer, balancer2, balancer3;
            balancer = LoadBalancer.GetLoadBalancer();
            balancer2 = LoadBalancer.GetLoadBalancer();
            balancer3 = LoadBalancer.GetLoadBalancer();

            //判断负载均衡器是否相同
            if (balancer == balancer2 && balancer == balancer3 && balancer2 == balancer3)
            {
                Console.WriteLine("^_^：服务负载均衡器是唯一的");
            }

            //增加服务器
            balancer.AddServer(new CustomServer {Name = "Server1" });
            balancer.AddServer(new CustomServer {Name = "Server2" });
            balancer.AddServer(new CustomServer {Name = "Server3" });
            balancer.AddServer(new CustomServer {Name = "Server4" });

            //模拟客户端请求的分发
            for (int i = 0;i < 10;i++)
            {
                CustomServer server = balancer.GetServer();
                Console.WriteLine("该请求已分配至：" + server.Name);
            }
            */
            #endregion

            #region 恶汉单例模式测试
            HungrySingletonSample hungrySingletonSample, hungrySingletonSample2, hungrySingletonSample3;
            hungrySingletonSample = HungrySingletonSample.GetInstance();
            hungrySingletonSample2 = HungrySingletonSample.GetInstance();
            hungrySingletonSample3 = HungrySingletonSample.GetInstance();
            if (hungrySingletonSample == hungrySingletonSample2 && hungrySingletonSample == hungrySingletonSample3 && hungrySingletonSample2 == hungrySingletonSample3)
            {
                Console.WriteLine("饿汉单例对象唯一");
            }
            #endregion

            #region 另一种单例模式测试
            AnotherSingletonSample another, another2, another3;
            another = AnotherSingletonSample.GetInstance();
            another2 = AnotherSingletonSample.GetInstance();
            another3 = AnotherSingletonSample.GetInstance();

            if (another == another2 && another2 == another3 && another2 == another3)
            {
                Console.WriteLine("另一种单例模式唯一");
            }
            #endregion

            Console.ReadLine();

        }
    }
}
