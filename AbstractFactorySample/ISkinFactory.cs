namespace AbstractFactorySample
{
    public interface ISkinFactory
    {
        IButton CreateButton();

        ITextField CreateTextField();

        IComboBox CreateComboBox();
    }

    public class SpringSkinFactory : ISkinFactory
    {
        public IButton CreateButton()
        {
            return new SpringButton();
        }

        public IComboBox CreateComboBox()
        {
            return new SpringComboBox();
        }

        public ITextField CreateTextField()
        {
            return new SpringTextField();
        }
    }

    public class SummerSkinFactory : ISkinFactory
    {
        public IButton CreateButton()
        {
            return new SummerButton();
        }

        public IComboBox CreateComboBox()
        {
            return new SummerComboBox();
        }

        public ITextField CreateTextField()
        {
            return new SummerTextField();
        }
    }
}
