using System;
using System.Configuration;

namespace AbstractFactorySample
{
    public class AppSettingHelper
    {
        public static string GetLoggerFactoryName(string key)
        {
            var factoryName = string.Empty;
            try
            {
                factoryName = ConfigurationManager.AppSettings[key];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return factoryName;
        }

        public static object GetSkinFactoryInstance()
        {
            var assemblyName = AppSettingHelper.GetLoggerFactoryName("SkinFactory");
            var type = Type.GetType(assemblyName);

            var instance = Activator.CreateInstance(type);
            return instance;
        }
    }
}
