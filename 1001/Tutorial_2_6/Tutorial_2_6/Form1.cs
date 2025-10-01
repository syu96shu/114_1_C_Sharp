using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial_2_6
{
    public partial class Form : System.Windows.Forms.Form
    {
        // 將 dayOfWeekTextBox 宣告為 TextBox 型別，並修正存取 text 屬性為 Text
        private TextBox dayOfWeekTextBox;
        private readonly object dateOutputLabel;

        public Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void weektextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ...

        private void showDateButton_Click(object sender, EventArgs e)
        {
            string dayOfWeek = weektextBox1.Text;
            string month = monthtextBox1.Text;
            string year = yeartextBox1.Text;
            string dayOfmonth = dayOfmonthtextBox1.Text; // 修正：使用 dayOfmonthtextbox.Text

            string output = "中華明國 " + year + " 年 " + month + " 月 " + dayOfmonth + " 日 是星期 " + dayOfWeek;

            dateOutputLabel.Text = output;
        }

        private void dayOfmonthtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            weektextBox.Text = "";
            monthtextBox.Text = "";
            yeartextBox.Text = "";
            dayOfmonthtextBox.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {

        }
    }
}
