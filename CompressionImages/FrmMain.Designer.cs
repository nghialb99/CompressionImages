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
            this.btnCompressImages = new CompressionImages.CustomControls.ButtonCustom();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gradientPanel1 = new CompressionImages.CustomControls.GradientPanel();
            this.btnGetCaptcha = new CompressionImages.CustomControls.ButtonCustom();
            this.pnLoad = new CompressionImages.CustomControls.GradientPanel();
            this.gradientPanel3 = new CompressionImages.CustomControls.GradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.gradientPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCompressImages
            // 
            this.btnCompressImages.BackColor = System.Drawing.Color.Transparent;
            this.btnCompressImages.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnCompressImages.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(136)))), ((int)(((byte)(144)))));
            this.btnCompressImages.BorderRadius = 1;
            this.btnCompressImages.BorderSize = 2;
            this.btnCompressImages.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompressImages.FlatAppearance.BorderSize = 0;
            this.btnCompressImages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompressImages.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCompressImages.ForeColor = System.Drawing.Color.Black;
            this.btnCompressImages.Location = new System.Drawing.Point(0, 58);
            this.btnCompressImages.Name = "btnCompressImages";
            this.btnCompressImages.Size = new System.Drawing.Size(173, 40);
            this.btnCompressImages.TabIndex = 3;
            this.btnCompressImages.Text = "Compress Images";
            this.btnCompressImages.TextColor = System.Drawing.Color.Black;
            this.btnCompressImages.UseVisualStyleBackColor = false;
            this.btnCompressImages.Click += new System.EventHandler(this.btnCompressImages_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(287, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Designed by Nghĩa Lê";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::CompressionImages.Properties.Resources.MyLogo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 0F;
            this.gradientPanel1.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(204)))), ((int)(((byte)(216)))));
            this.gradientPanel1.Controls.Add(this.btnGetCaptcha);
            this.gradientPanel1.Controls.Add(this.btnCompressImages);
            this.gradientPanel1.Controls.Add(this.pictureBox1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(173, 442);
            this.gradientPanel1.TabIndex = 3;
            this.gradientPanel1.TopColor = System.Drawing.Color.Empty;
            // 
            // btnGetCaptcha
            // 
            this.btnGetCaptcha.BackColor = System.Drawing.Color.Transparent;
            this.btnGetCaptcha.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnGetCaptcha.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(136)))), ((int)(((byte)(144)))));
            this.btnGetCaptcha.BorderRadius = 1;
            this.btnGetCaptcha.BorderSize = 2;
            this.btnGetCaptcha.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGetCaptcha.FlatAppearance.BorderSize = 0;
            this.btnGetCaptcha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetCaptcha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGetCaptcha.ForeColor = System.Drawing.Color.Black;
            this.btnGetCaptcha.Location = new System.Drawing.Point(0, 98);
            this.btnGetCaptcha.Name = "btnGetCaptcha";
            this.btnGetCaptcha.Size = new System.Drawing.Size(173, 40);
            this.btnGetCaptcha.TabIndex = 4;
            this.btnGetCaptcha.Text = "Get Captcha";
            this.btnGetCaptcha.TextColor = System.Drawing.Color.Black;
            this.btnGetCaptcha.UseVisualStyleBackColor = false;
            this.btnGetCaptcha.Click += new System.EventHandler(this.brnGetCaptcha_Click);
            // 
            // pnLoad
            // 
            this.pnLoad.Angle = 0F;
            this.pnLoad.BottomColor = System.Drawing.Color.Empty;
            this.pnLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLoad.Location = new System.Drawing.Point(173, 0);
            this.pnLoad.Name = "pnLoad";
            this.pnLoad.Size = new System.Drawing.Size(697, 442);
            this.pnLoad.TabIndex = 4;
            this.pnLoad.TopColor = System.Drawing.Color.Empty;
            // 
            // gradientPanel3
            // 
            this.gradientPanel3.Angle = 0F;
            this.gradientPanel3.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(204)))), ((int)(((byte)(216)))));
            this.gradientPanel3.Controls.Add(this.label1);
            this.gradientPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradientPanel3.Location = new System.Drawing.Point(173, 421);
            this.gradientPanel3.Name = "gradientPanel3";
            this.gradientPanel3.Size = new System.Drawing.Size(697, 21);
            this.gradientPanel3.TabIndex = 5;
            this.gradientPanel3.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(870, 442);
            this.Controls.Add(this.gradientPanel3);
            this.Controls.Add(this.pnLoad);
            this.Controls.Add(this.gradientPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(886, 481);
            this.MinimumSize = new System.Drawing.Size(886, 481);
            this.Name = "FrmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compress Images";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel3.ResumeLayout(false);
            this.gradientPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private CustomControls.GradientPanel gradientPanel1;
        private CustomControls.ButtonCustom btnGetCaptcha;
        private CustomControls.GradientPanel pnLoad;
        private CustomControls.GradientPanel gradientPanel3;
        private CustomControls.ButtonCustom btnCompressImages;
    }
}