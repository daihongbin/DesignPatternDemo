using System;
using System.Configuration;

//简单工厂模式
namespace SimpleFactorySample
{
    class Program
    {
        static void Main(string[] args)
        {
            var chartType = GetConfiguration("charttype");
            if (string.IsNullOrEmpty(chartType))
            {
                return;
            }

            IChartable chart = ChartFactory.GetChart(chartType);
            if (chart != null)
            {
                chart.Display();
            }

            Console.ReadLine();
        }

        public static string GetConfiguration(string key)
        {
            var settingValue = ConfigurationManager.AppSettings[key];
            return settingValue;
        }
    }
}
