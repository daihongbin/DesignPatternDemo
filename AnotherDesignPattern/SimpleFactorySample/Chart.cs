using System;

namespace SimpleFactorySample
{
    public class Chart
    {
        private string type; //图标类型

        public Chart(object[] data, string type)
        {
            this.type = type;

            if (this.type.Equals("historgram", StringComparison.OrdinalIgnoreCase))
            {
                //初始化柱状图
            }
            else if (this.type.Equals("pie", StringComparison.OrdinalIgnoreCase))
            {
                //初始化饼状图
            }
            else if (this.type.Equals("line", StringComparison.OrdinalIgnoreCase))
            {
                //初始化线形图
            }
        }

        public void Display()
        {
            if (this.type.Equals("histogram", StringComparison.OrdinalIgnoreCase))
            {
                // 显示柱状图
            }
            else if (this.type.Equals("pie", StringComparison.OrdinalIgnoreCase))
            {
                // 显示饼状图
            }
            else if (this.type.Equals("line", StringComparison.OrdinalIgnoreCase))
            {
                // 显示折线图
            }
        }
    }
}
