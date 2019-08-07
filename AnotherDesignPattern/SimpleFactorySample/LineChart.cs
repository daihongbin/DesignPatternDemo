using System;

namespace SimpleFactorySample
{
    public class LineChart : IChartable
    {
        public LineChart()
        {
            Console.WriteLine("创建折线图...");
        }

        public void Display()
        {
            Console.WriteLine("显示折线图...");
        }
    }
}
