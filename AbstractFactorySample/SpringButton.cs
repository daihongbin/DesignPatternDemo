using System;

namespace AbstractFactorySample
{
    public class SpringButton : IButton
    {
        public void Display()
        {
            Console.WriteLine("显示浅绿色按钮...");
        }
    }

    public class SpringTextField : ITextField
    {
        public void Display()
        {
            Console.WriteLine("显示绿色边框文本框...");
        }
    }

    public class SpringComboBox : IComboBox
    {
        public void Display()
        {
            Console.WriteLine("显示绿色边框下拉框...");
        }
    }
}
