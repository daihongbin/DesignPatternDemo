namespace MallCashier
{
    /// <summary>
    /// 策略模式
    /// </summary>
    public class CashContext
    {
        private CashSuper cs;

        //单独策略模式
        //public CashContext(CashSuper csuper)
        //{
        //    this.cs = csuper;
        //}

        //策略模式与简单工厂模式相结合
        public CashContext(string type)
        {
            switch (type)
            {
                case "正常收费":
                    cs = new CashNormal();
                    break;
                case "满300返100":
                    cs = new CashReturn("300", "100");
                    break;
                case "打8折":
                    cs = new CashRebate("0.8");
                    break;
            }
        }

        public double GetResult(double money)
        {
            return cs.AcceptCash(money);
        }
    }
}