namespace Tutorial2_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Lable = new Label();
            countryLabel = new Label();
            finlandPictureBox = new PictureBox();
            FrancePictureBox = new PictureBox();
            germanyPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)finlandPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FrancePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)germanyPictureBox).BeginInit();
            SuspendLayout();
            // 
            // Lable
            // 
            Lable.Font = new Font("Microsoft JhengHei UI", 30F);
            Lable.Location = new Point(35, 9);
            Lable.Name = "Lable";
            Lable.Size = new Size(705, 87);
            Lable.TabIndex = 0;
            Lable.Text = "連點國旗會出現國家名稱";
            // 
            // countryLabel
            // 
            countryLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            countryLabel.BackColor = SystemColors.ButtonHighlight;
            countryLabel.BorderStyle = BorderStyle.Fixed3D;
            countryLabel.Font = new Font("Microsoft JhengHei UI", 26F, FontStyle.Regular, GraphicsUnit.Point, 136);
            countryLabel.Location = new Point(100, 315);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(627, 98);
            countryLabel.TabIndex = 1;
            countryLabel.TextAlign = ContentAlignment.MiddleCenter;
            countryLabel.Click += label1_Click;
            // 
            // finlandPictureBox
            // 
            finlandPictureBox.Image = Properties.Resources.Finland;
            finlandPictureBox.InitialImage = (Image)resources.GetObject("finlandPictureBox.InitialImage");
            finlandPictureBox.Location = new Point(12, 99);
            finlandPictureBox.Name = "finlandPictureBox";
            finlandPictureBox.Size = new Size(236, 162);
            finlandPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            finlandPictureBox.TabIndex = 2;
            finlandPictureBox.TabStop = false;
            finlandPictureBox.Click += finland_Click;
            // 
            // FrancePictureBox
            // 
            FrancePictureBox.Image = (Image)resources.GetObject("FrancePictureBox.Image");
            FrancePictureBox.InitialImage = (Image)resources.GetObject("FrancePictureBox.InitialImage");
            FrancePictureBox.Location = new Point(275, 99);
            FrancePictureBox.Name = "FrancePictureBox";
            FrancePictureBox.Size = new Size(236, 162);
            FrancePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            FrancePictureBox.TabIndex = 3;
            FrancePictureBox.TabStop = false;
            FrancePictureBox.Click += FrancePictureBox_Click;
            // 
            // germanyPictureBox
            // 
            germanyPictureBox.Image = (Image)resources.GetObject("germanyPictureBox.Image");
            germanyPictureBox.InitialImage = (Image)resources.GetObject("germanyPictureBox.InitialImage");
            germanyPictureBox.Location = new Point(552, 99);
            germanyPictureBox.Name = "germanyPictureBox";
            germanyPictureBox.Size = new Size(236, 162);
            germanyPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            germanyPictureBox.TabIndex = 4;
            germanyPictureBox.TabStop = false;
            germanyPictureBox.Click += germanyPictureBox_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(germanyPictureBox);
            Controls.Add(FrancePictureBox);
            Controls.Add(finlandPictureBox);
            Controls.Add(countryLabel);
            Controls.Add(Lable);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)finlandPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)FrancePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)germanyPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label Lable;
        private Label countryLabel;
        private PictureBox finlandPictureBox;
        private PictureBox FrancePictureBox;
        private PictureBox germanyPictureBox;
    }
}
