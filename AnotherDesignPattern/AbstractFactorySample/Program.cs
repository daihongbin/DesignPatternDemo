using System;

namespace AbstractFactorySample
{
    class Program
    {
        static void Main(string[] args)
        {
            ISkinFactory skinFactory = (ISkinFactory)AppSettingHelper.GetSkinFactoryInstance();
            if (skinFactory == null)
            {
                Console.WriteLine("读取当前选中皮肤类型失败...");
            }

            IButton button = skinFactory.CreateButton();
            ITextField textField = skinFactory.CreateTextField();
            IComboBox comboBox = skinFactory.CreateComboBox();

            button.Display();
            textField.Display();
            comboBox.Display();

            Console.ReadKey();
        }
    }
}
