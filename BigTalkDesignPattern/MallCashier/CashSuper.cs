using System;

namespace MallCashier
{
    /// <summary>
    /// 现金收费抽象类
    /// </summary>
    public abstract class CashSuper
    {
        public abstract double AcceptCash(double money);
    }

    /// <summary>
    /// 正常收费子类
    /// </summary>
    public class CashNormal:CashSuper
    {
        public override double AcceptCash(double money)
        {
            return money;
        }
    }

    /// <summary>
    /// 打折收费子类
    /// </summary>
    public class CashRebate : CashSuper
    {
        private double moneyRebate = 1d;

        public CashRebate(string moneyRebate) => this.moneyRebate = double.Parse(moneyRebate);

        public override double AcceptCash(double money)
        {
            return money * moneyRebate;
        }
    }

    /// <summary>
    /// 返利收费子类
    /// </summary>
    public class CashReturn : CashSuper
    {
        private double moneyCondition = 0.0d;

        private double moneyReturn = 0.0d;

        public CashReturn(string moneyCondition,string moneyReturn)
        {
            this.moneyCondition = double.Parse(moneyCondition);
            this.moneyReturn = double.Parse(moneyReturn);
        }

        public override double AcceptCash(double money)
        {
            var result = money;

            if (money >= moneyCondition)
                result = money - Math.Floor(money / moneyCondition) * moneyReturn;

            return result;
        }
    }

    
}
