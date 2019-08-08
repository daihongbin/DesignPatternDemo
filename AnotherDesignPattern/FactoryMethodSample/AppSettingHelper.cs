using System;
using System.Configuration;

namespace FactoryMethodSample
{
    public class AppSettingHelper
    {
        public static string GetLoggerFactoryName(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        public static object GetLoggerFactoryInstance()
        {
            var assemblyName = AppSettingHelper.GetLoggerFactoryName("LoggerFactory");
            var type = Type.GetType(assemblyName);

            var instance = Activator.CreateInstance(type);
            return instance;
        }
    }
}
