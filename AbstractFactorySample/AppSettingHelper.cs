using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace AbstractFactorySample
{
    public class AppSettingHelper
    {
        public static string GetLoggerFactoryName()
        {
            IConfigurationRoot GetConfiguration()
            {
                var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .AddEnvironmentVariables();

                IConfigurationRoot configurationRoot = builder.Build();
                return configurationRoot;
            }

            return GetConfiguration().GetValue<string>("LoggerFactory");
        }

        public static object GetLoggerFactoryInstance()
        {
            var assemblyName = AppSettingHelper.GetLoggerFactoryName();
            var type = Type.GetType(assemblyName);

            var instance = Activator.CreateInstance(type);
            return instance;
        }
    }
}
