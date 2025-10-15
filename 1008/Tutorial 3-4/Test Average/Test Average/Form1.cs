using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        // 建構子：初始化表單元件
        public Form1()
        {
            InitializeComponent();
        }

        // 當使用者按下「計算平均」按鈕時觸發
        private void calculateButton_Click(object sender, EventArgs e)
        {
            const decimal BASE HOURS
            try
            {


                test1 = double.Parse(test1TextBox.Text);
                test2 = double.Parse(test2TextBox.Text);
                test3 = double.Parse(test3TextBox.Text);

                double average = (test1 + test2 + test3) / 3.0;

                averageLabel.Text = average.ToString("n2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("請輸入有效的數字。", ex.Message);
            }
        }
        // 當使用者按下「清除」按鈕時觸發
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除所有輸入與輸出欄位內容
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";

            test1TextBox.Focus();
        }

        // 當使用者按下「離開」按鈕時觸發
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
