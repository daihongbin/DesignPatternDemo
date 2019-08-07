using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace SimpleFactorySample
{
    class Program
    {
        static void Main(string[] args)
        {
            var chartType = GetConfiguration().GetValue<string>("charttype");
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

        public static IConfigurationRoot GetConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();

            IConfigurationRoot configurationRoot = builder.Build();
            return configurationRoot;
        }
    }
}
