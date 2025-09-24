namespace tutorial_2_5
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cardbackpictureBox = new System.Windows.Forms.PictureBox();
            this.cardFacepictureBox = new System.Windows.Forms.PictureBox();
            this.showBackbutton = new System.Windows.Forms.Button();
            this.showFacebutton = new System.Windows.Forms.Button();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            ((System.ComponentModel.ISupportInitialize)(this.cardbackpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardFacepictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.SuspendLayout();
            // 
            // cardbackpictureBox
            // 
            this.cardbackpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("cardbackpictureBox.Image")));
            this.cardbackpictureBox.Location = new System.Drawing.Point(233, 66);
            this.cardbackpictureBox.Name = "cardbackpictureBox";
            this.cardbackpictureBox.Size = new System.Drawing.Size(202, 281);
            this.cardbackpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardbackpictureBox.TabIndex = 0;
            this.cardbackpictureBox.TabStop = false;
            this.cardbackpictureBox.Visible = false;
            // 
            // cardFacepictureBox
            // 
            this.cardFacepictureBox.Image = ((System.Drawing.Image)(resources.GetObject("cardFacepictureBox.Image")));
            this.cardFacepictureBox.Location = new System.Drawing.Point(233, 66);
            this.cardFacepictureBox.Name = "cardFacepictureBox";
            this.cardFacepictureBox.Size = new System.Drawing.Size(202, 281);
            this.cardFacepictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardFacepictureBox.TabIndex = 1;
            this.cardFacepictureBox.TabStop = false;
            this.cardFacepictureBox.Visible = false;
            this.cardFacepictureBox.Click += new System.EventHandler(this.cardFacepictureBox_Click);
            // 
            // showBackbutton
            // 
            this.showBackbutton.Location = new System.Drawing.Point(167, 379);
            this.showBackbutton.Name = "showBackbutton";
            this.showBackbutton.Size = new System.Drawing.Size(123, 48);
            this.showBackbutton.TabIndex = 2;
            this.showBackbutton.Text = "顯示背面";
            this.showBackbutton.UseVisualStyleBackColor = true;
            this.showBackbutton.Click += new System.EventHandler(this.shoeBackbutton_Click);
            // 
            // showFacebutton
            // 
            this.showFacebutton.Location = new System.Drawing.Point(368, 379);
            this.showFacebutton.Name = "showFacebutton";
            this.showFacebutton.Size = new System.Drawing.Size(123, 48);
            this.showFacebutton.TabIndex = 3;
            this.showFacebutton.Text = "顯示正面";
            this.showFacebutton.UseVisualStyleBackColor = true;
            this.showFacebutton.Click += new System.EventHandler(this.showFacebutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showFacebutton);
            this.Controls.Add(this.showBackbutton);
            this.Controls.Add(this.cardFacepictureBox);
            this.Controls.Add(this.cardbackpictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardbackpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardFacepictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cardbackpictureBox;
        private System.Windows.Forms.PictureBox cardFacepictureBox;
        private System.Windows.Forms.Button showBackbutton;
        private System.Windows.Forms.Button showFacebutton;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
    }
}

