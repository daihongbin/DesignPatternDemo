using System;
using System.Windows.Forms;

namespace MallCashier
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        #region 事件
        //窗体加载
        private void frmMain_Load(object sender, EventArgs e)
        {
            cbxType.Items.AddRange(new object[]{"正常收费","打8折","打7折","打5折"});
            cbxType.SelectedIndex = 0;
        }

        //确定按钮
        private double total = 0.0d;
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrice.Text) || string.IsNullOrEmpty(txtNum.Text)) return;

            #region 未增加打折时
            /*
            var totalPrices = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text);
            */
            #endregion

            #region 增加打折
            /*
            var totalPrices = 0.0d;
            switch (cbxType.SelectedIndex)
            {
                case 0:
                    totalPrices = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text);
                    break;
                case 1:
                    totalPrices = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text) * 0.8;
                    break;
                case 2:
                    totalPrices = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text) * 0.7;
                    break;
                case 3:
                    totalPrices = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text) * 0.5;
                    break;
            }
            */
            #endregion


            #region 使用工厂模式
            /*
            CashSuper csuper = CashFactory.CreateCashAccept(cbxType.SelectedItem.ToString());
            var totalPrices = 0.0d;
            totalPrices = csuper.AcceptCash(Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text));
            total += totalPrices;
            */
            #endregion

            #region 单独使用策略模式
            /*
            CashContext cc = null;

            switch (cbxType.SelectedItem.ToString())
            {
                case "正常收费":
                    cc = new CashContext(new CashNormal());
                    break;
                case "满300返100":
                    cc = new CashContext(new CashReturn("300","100"));
                    break;
                case "打8折":
                    cc = new CashContext(new CashRebate("0.8"));
                    break;
            }

            double totalPrices = cc.GetResult(Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text));
            total += totalPrices;
            lbxList.Items.Add($"单价：{txtPrice.Text}数量：{txtNum.Text} {cbxType.SelectedItem} 合计：{totalPrices}");
            lblResult.Text = total.ToString();
            */
            #endregion

            #region 策略模式与简单工厂模式相结合
            CashContext csuper = new CashContext(cbxType.SelectedItem.ToString());
            var totalPrices = csuper.GetResult(Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text));
            #endregion

            total += totalPrices;
            lbxList.Items.Add($"单价：{txtPrice.Text}数量：{txtNum.Text} {cbxType.SelectedItem} 合计：{totalPrices}");
            lblResult.Text = total.ToString();
            ResetTxtText();
        }

        //重置按钮
        private void button2_Click(object sender, EventArgs e)
        {
            ResetTxtText();
        }
        #endregion



        #region 方法

        private void ResetTxtText()
        {
            txtNum.Text = "";
            txtPrice.Text = "";
        }
        #endregion

        
    }
}
