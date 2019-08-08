using System;

namespace AbstractFactorySample
{
    public class SummerButton : IButton
    {
        public void Display()
        {
            Console.WriteLine("显示浅蓝色按钮...");
        }
    }

    public class SummerTextField : ITextField
    {
        public void Display()
        {
            Console.WriteLine("显示蓝色边框文本框...");
        }
    }

    public class SummerComboBox : IComboBox
    {
        public void Display()
        {
            Console.WriteLine("显示蓝色边框下拉框...");
        }
    }
}
