using System;

namespace CalcConsoleApp
{
    public class Operation2
    {
        public double NumberA { get; set; }

        public double NumberB { get; set; }

        public virtual double GetResult()
        {
            return 0d;
        }
    }

    public class OperationAdd : Operation2
    {
        public override double GetResult()
        {
            return NumberA + NumberB;
        }
    }

    public class OperationSub : Operation2
    {
        public override double GetResult()
        {
            return NumberA - NumberB;
        }
    }

    public class OperationMul : Operation2
    {
        public override double GetResult()
        {
            return NumberA * NumberB;
        }
    }

    public class OperationDiv : Operation2
    {
        public override double GetResult()
        {
            if (NumberB == 0)
                throw new Exception("除数不能为0");
            return NumberA / NumberB;
        }
    }

    public class OperationFactory
    {
        public static Operation2 CreateOperate(string operate)
        {
            Operation2 oper = null;

            switch (operate)
            {
                case "+":
                    oper = new OperationAdd();
                    break;
                case "-":
                    oper = new OperationSub();
                    break;
                case "*":
                    oper = new OperationMul();
                    break;
                case "/":
                    oper = new OperationDiv();
                    break;
            }

            return oper;
        }
    }
}