namespace CalcConsoleApp
{
    public class Operation
    {
        public static double GetResult(double numberA,double numberB,string operate)
        {
            var result = 0d;
            switch (operate)
            {
                case "+":
                    result = numberA + numberB;
                    break;
                case "-":
                    result = numberA - numberB;
                    break;
                case "*":
                    result = numberA * numberB;
                    break;
                case "/":
                    result = numberA / numberB;
                    break;
            }

            return result;
        }
    }
}