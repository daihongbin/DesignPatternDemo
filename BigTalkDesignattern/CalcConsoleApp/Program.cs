using System;
using System.Globalization;

namespace CalcConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region 第1版
            /*
            Console.WriteLine("请输入数字A：");
            var A = Console.ReadLine();

            Console.WriteLine("请输入运算符号（+、-、*、/）：");
            var B = Console.ReadLine();

            Console.WriteLine("请输入数字C：");
            var C = Console.ReadLine();

            var D = "";
            if (B == "+")
                D = Convert.ToString(Convert.ToDouble(A) + Convert.ToDouble(C));

            if (B == "-")
                D = Convert.ToString(Convert.ToDouble(A) - Convert.ToDouble(C));

            if (B == "*")
                D = Convert.ToString(Convert.ToDouble(A) * Convert.ToDouble(C));

            if (B == "/")
                D = Convert.ToString(Convert.ToDouble(A) / Convert.ToDouble(C));

            Console.WriteLine("结果是：" + D);
            */
            #endregion

            #region 第2版
            /*
            try
            {
                Console.WriteLine("请输入数字A：");
                var strNumberA = Console.ReadLine();

                Console.WriteLine("请输入运算符号（+、-、*、/）：");
                var strOperate = Console.ReadLine();

                Console.WriteLine("请输入数字C：");
                var strNumberB = Console.ReadLine();

                var strResult = "";

                switch (strOperate)
                {
                    case "+":
                        strResult = Convert.ToString(Convert.ToDouble(strNumberA) + Convert.ToDouble(strNumberB));
                        break;
                    case "-":
                        strResult = Convert.ToString(Convert.ToDouble(strNumberA) - Convert.ToDouble(strNumberB));
                        break;
                    case "*":
                        strResult = Convert.ToString(Convert.ToDouble(strNumberA) * Convert.ToDouble(strNumberB));
                        break;
                    case "/":
                        if (strNumberB != "0")
                            strResult = Convert.ToString(Convert.ToDouble(strNumberA) / Convert.ToDouble(strNumberB));
                        else
                            strResult = "除数不能为0";
                        break;
                }

                Console.WriteLine("结果是：" + strResult);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("您的输入有误：" + ex.Message);
            }
            */
            #endregion

            #region 第3版
            /*
            try
            {
                Console.WriteLine("请输入数字A：");
                var strNumberA = Console.ReadLine();

                Console.WriteLine("请输入运算符号（+、-、*、/）：");
                var strOperate = Console.ReadLine();

                Console.WriteLine("请输入数字C：");
                var strNumberB = Console.ReadLine();

                var strResult = "";

                strResult = Operation.GetResult(
                    Convert.ToDouble(strNumberA),
                    Convert.ToDouble(strNumberB),
                    strOperate
                    ).ToString();

                Console.WriteLine("结果是：" + strResult);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("您的输入有误：" + ex.Message);
            }
            */
            #endregion


            #region 使用简单工厂模式
            try
            {
                Console.WriteLine("请输入数字A：");
                var strNumberA = Console.ReadLine();

                Console.WriteLine("请输入运算符号（+、-、*、/）：");
                var strOperate = Console.ReadLine();

                Console.WriteLine("请输入数字C：");
                var strNumberB = Console.ReadLine();

                Operation2 oper;
                oper = OperationFactory.CreateOperate(strOperate);
                oper.NumberA = Convert.ToDouble(strNumberA);
                oper.NumberB = Convert.ToDouble(strNumberB);
                var strResult = oper.GetResult().ToString();

                Console.WriteLine("结果是：" + strResult);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("您的输入有误：" + ex.Message);
            }
            #endregion
        }
    }
}
