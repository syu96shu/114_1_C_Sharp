namespace Tutorial_2_6
{
    partial class Form
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.weektextBox2 = new System.Windows.Forms.TextBox();
            this.yeartextBox1 = new System.Windows.Forms.TextBox();
            this.monthtextBox1 = new System.Windows.Forms.TextBox();
            this.dayOfmonthtextBox1 = new System.Windows.Forms.TextBox();
            this.weektextBox1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateOutputLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 642);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 89);
            this.button1.TabIndex = 0;
            this.button1.Text = "顯示日期";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(347, 642);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(143, 89);
            this.clear.TabIndex = 1;
            this.clear.Text = "清除";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(633, 642);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(143, 89);
            this.exit.TabIndex = 2;
            this.exit.Text = "離開";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.button3_Click);
            // 
            // weektextBox2
            // 
            this.weektextBox2.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.weektextBox2.Location = new System.Drawing.Point(313, 79);
            this.weektextBox2.Name = "weektextBox2";
            this.weektextBox2.Size = new System.Drawing.Size(490, 65);
            this.weektextBox2.TabIndex = 3;
            // 
            // yeartextBox1
            // 
            this.yeartextBox1.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.yeartextBox1.Location = new System.Drawing.Point(313, 397);
            this.yeartextBox1.Name = "yeartextBox1";
            this.yeartextBox1.Size = new System.Drawing.Size(490, 65);
            this.yeartextBox1.TabIndex = 4;
            // 
            // monthtextBox1
            // 
            this.monthtextBox1.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.monthtextBox1.Location = new System.Drawing.Point(313, 283);
            this.monthtextBox1.Name = "monthtextBox1";
            this.monthtextBox1.Size = new System.Drawing.Size(490, 65);
            this.monthtextBox1.TabIndex = 5;
            // 
            // dayOfmonthtextBox1
            // 
            this.dayOfmonthtextBox1.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dayOfmonthtextBox1.Location = new System.Drawing.Point(313, 183);
            this.dayOfmonthtextBox1.Name = "dayOfmonthtextBox1";
            this.dayOfmonthtextBox1.Size = new System.Drawing.Size(490, 65);
            this.dayOfmonthtextBox1.TabIndex = 6;
            // 
            // weektextBox1
            // 
            this.weektextBox1.AutoSize = true;
            this.weektextBox1.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.weektextBox1.Location = new System.Drawing.Point(131, 82);
            this.weektextBox1.Name = "weektextBox1";
            this.weektextBox1.Size = new System.Drawing.Size(141, 48);
            this.weektextBox1.TabIndex = 7;
            this.weektextBox1.Text = "星期 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(179, 414);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 48);
            this.label6.TabIndex = 8;
            this.label6.Text = "年 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(179, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 48);
            this.label7.TabIndex = 9;
            this.label7.Text = "月 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(179, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 48);
            this.label8.TabIndex = 10;
            this.label8.Text = "日 :";
            // 
            // dateOutputLabel1
            // 
            this.dateOutputLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dateOutputLabel1.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateOutputLabel1.Location = new System.Drawing.Point(179, 519);
            this.dateOutputLabel1.Name = "dateOutputLabel1";
            this.dateOutputLabel1.Size = new System.Drawing.Size(596, 91);
            this.dateOutputLabel1.TabIndex = 11;
            this.dateOutputLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form
            // 
            this.ClientSize = new System.Drawing.Size(923, 852);
            this.Controls.Add(this.dateOutputLabel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.weektextBox1);
            this.Controls.Add(this.dayOfmonthtextBox1);
            this.Controls.Add(this.monthtextBox1);
            this.Controls.Add(this.yeartextBox1);
            this.Controls.Add(this.weektextBox2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.button1);
            this.Name = "Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox weektextBox;
        private System.Windows.Forms.TextBox monthtextBox;
        private System.Windows.Forms.TextBox dayOfmonthtextBox;
        private System.Windows.Forms.TextBox yeartextBox;
        private System.Windows.Forms.Label dateOutputLabe;
        private System.Windows.Forms.Button showDateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox weektextBox2;
        private System.Windows.Forms.TextBox yeartextBox1;
        private System.Windows.Forms.TextBox monthtextBox1;
        private System.Windows.Forms.TextBox dayOfmonthtextBox1;
        private System.Windows.Forms.Label weektextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label dateOutputLabel1;
    }
}

