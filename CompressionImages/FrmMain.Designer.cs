namespace CompressionImages
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            label1 = new Label();
            LogoImg = new PictureBox();
            panelSidebar = new CustomControls.GradientPanel();
            pnLoad = new CustomControls.GradientPanel();
            pictureBox1 = new PictureBox();
            gradientPanel3 = new CustomControls.GradientPanel();
            tableLayoutMain = new TableLayoutPanel();
            gradientPanel1 = new CustomControls.GradientPanel();
            btnCurrent = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)LogoImg).BeginInit();
            panelSidebar.SuspendLayout();
            pnLoad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gradientPanel3.SuspendLayout();
            tableLayoutMain.SuspendLayout();
            gradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(284, 1);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 1;
            label1.Text = "Designed by Nghĩa Lê";
            // 
            // LogoImg
            // 
            LogoImg.Dock = DockStyle.Top;
            LogoImg.Image = Properties.Resources.MyLogo;
            LogoImg.Location = new Point(0, 0);
            LogoImg.Name = "LogoImg";
            LogoImg.Size = new Size(174, 58);
            LogoImg.SizeMode = PictureBoxSizeMode.StretchImage;
            LogoImg.TabIndex = 2;
            LogoImg.TabStop = false;
            LogoImg.Click += LogoImg_Click;
            // 
            // panelSidebar
            // 
            panelSidebar.Angle = 0F;
            panelSidebar.BottomColor = Color.Black;
            panelSidebar.Controls.Add(LogoImg);
            panelSidebar.Dock = DockStyle.Fill;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Margin = new Padding(0);
            panelSidebar.Name = "panelSidebar";
            tableLayoutMain.SetRowSpan(panelSidebar, 3);
            panelSidebar.Size = new Size(174, 442);
            panelSidebar.TabIndex = 3;
            panelSidebar.TopColor = Color.Black;
            // 
            // pnLoad
            // 
            pnLoad.Angle = 0F;
            pnLoad.BackColor = SystemColors.ActiveCaptionText;
            pnLoad.BottomColor = Color.Empty;
            pnLoad.Controls.Add(pictureBox1);
            pnLoad.Dock = DockStyle.Fill;
            pnLoad.Location = new Point(177, 38);
            pnLoad.Name = "pnLoad";
            pnLoad.Size = new Size(690, 379);
            pnLoad.TabIndex = 4;
            pnLoad.TopColor = Color.Empty;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.MyLogo;
            pictureBox1.Location = new Point(231, 99);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(262, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // gradientPanel3
            // 
            gradientPanel3.Angle = 0F;
            gradientPanel3.BackColor = Color.Black;
            gradientPanel3.BottomColor = Color.Empty;
            gradientPanel3.Controls.Add(label1);
            gradientPanel3.Dock = DockStyle.Fill;
            gradientPanel3.Location = new Point(177, 423);
            gradientPanel3.Name = "gradientPanel3";
            gradientPanel3.Size = new Size(690, 16);
            gradientPanel3.TabIndex = 5;
            gradientPanel3.TopColor = Color.Empty;
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.ColumnCount = 2;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle());
            tableLayoutMain.Controls.Add(gradientPanel3, 1, 2);
            tableLayoutMain.Controls.Add(pnLoad, 1, 1);
            tableLayoutMain.Controls.Add(panelSidebar, 0, 0);
            tableLayoutMain.Controls.Add(gradientPanel1, 1, 0);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(0, 0);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 3;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 94.73684F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 5.263158F));
            tableLayoutMain.Size = new Size(870, 442);
            tableLayoutMain.TabIndex = 6;
            // 
            // gradientPanel1
            // 
            gradientPanel1.Angle = 0F;
            gradientPanel1.BackColor = Color.Black;
            gradientPanel1.BottomColor = Color.Empty;
            gradientPanel1.Controls.Add(btnCurrent);
            gradientPanel1.Dock = DockStyle.Fill;
            gradientPanel1.Location = new Point(177, 3);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(690, 29);
            gradientPanel1.TabIndex = 6;
            gradientPanel1.TopColor = Color.Empty;
            // 
            // btnCurrent
            // 
            btnCurrent.Dock = DockStyle.Left;
            btnCurrent.Enabled = false;
            btnCurrent.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCurrent.IconColor = Color.Black;
            btnCurrent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCurrent.Location = new Point(0, 0);
            btnCurrent.Name = "btnCurrent";
            btnCurrent.Size = new Size(251, 29);
            btnCurrent.TabIndex = 0;
            btnCurrent.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(870, 442);
            Controls.Add(tableLayoutMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(886, 481);
            Name = "FrmMain";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Compress Images";
            FormClosing += FrmMain_FormClosing;
            Load += FrmMain_Load;
            ((System.ComponentModel.ISupportInitialize)LogoImg).EndInit();
            panelSidebar.ResumeLayout(false);
            pnLoad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gradientPanel3.ResumeLayout(false);
            gradientPanel3.PerformLayout();
            tableLayoutMain.ResumeLayout(false);
            gradientPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private PictureBox LogoImg;
        private CustomControls.GradientPanel panelSidebar;
        private CustomControls.GradientPanel pnLoad;
        private CustomControls.GradientPanel gradientPanel3;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutMain;
        private CustomControls.GradientPanel gradientPanel1;
        private FontAwesome.Sharp.IconButton btnCurrent;
    }
}