using System;

namespace SingletonSample
{
    class Program
    {
        static void Main(string[] args)
        {
            LoadBalancer balancer, balancer2, balancer3;
            balancer = LoadBalancer.GetInstance();
            balancer2 = LoadBalancer.GetInstance();
            balancer3 = LoadBalancer.GetInstance();

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
            Console.ReadLine();

        }
    }
}
