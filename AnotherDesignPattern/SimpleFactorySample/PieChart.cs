using System;

namespace SimpleFactorySample
{
    public class PieChart : IChartable
    {
        public PieChart()
        {
            Console.WriteLine("创建饼状图...");
        }

        public void Display()
        {
            Console.WriteLine("显示饼状图...");
        }
    }
}
