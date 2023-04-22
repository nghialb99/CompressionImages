namespace CompressionImages
{
    partial class FrmCompressImages
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gradientPanel1 = new CustomControls.GradientPanel();
            lblNotice = new Label();
            lblProgress = new Label();
            btnSaveJPG = new CustomControls.ButtonCustom();
            btnSavePNG = new CustomControls.ButtonCustom();
            label3 = new Label();
            lblTotal = new Label();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            gradientPanel2 = new CustomControls.GradientPanel();
            rtbImage = new RichTextBox();
            gradientPanel1.SuspendLayout();
            gradientPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.Angle = 0F;
            gradientPanel1.BottomColor = Color.FromArgb(93, 204, 216);
            gradientPanel1.Controls.Add(lblNotice);
            gradientPanel1.Controls.Add(lblProgress);
            gradientPanel1.Controls.Add(btnSaveJPG);
            gradientPanel1.Controls.Add(btnSavePNG);
            gradientPanel1.Controls.Add(label3);
            gradientPanel1.Controls.Add(lblTotal);
            gradientPanel1.Controls.Add(progressBar1);
            gradientPanel1.Controls.Add(label1);
            gradientPanel1.Dock = DockStyle.Top;
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(697, 85);
            gradientPanel1.TabIndex = 0;
            gradientPanel1.TopColor = Color.FromArgb(192, 255, 255);
            // 
            // lblNotice
            // 
            lblNotice.AutoSize = true;
            lblNotice.BackColor = Color.Transparent;
            lblNotice.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNotice.ForeColor = Color.Red;
            lblNotice.Location = new Point(9, 66);
            lblNotice.Name = "lblNotice";
            lblNotice.Size = new Size(42, 15);
            lblNotice.TabIndex = 7;
            lblNotice.Text = "Notice";
            // 
            // lblProgress
            // 
            lblProgress.AutoSize = true;
            lblProgress.BackColor = Color.Transparent;
            lblProgress.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblProgress.Location = new Point(72, 41);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(13, 15);
            lblProgress.TabIndex = 6;
            lblProgress.Text = "0";
            // 
            // btnSaveJPG
            // 
            btnSaveJPG.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnSaveJPG.BackColor = Color.Transparent;
            btnSaveJPG.BackgroundColor = Color.Transparent;
            btnSaveJPG.BorderColor = Color.FromArgb(62, 136, 144);
            btnSaveJPG.BorderRadius = 1;
            btnSaveJPG.BorderSize = 2;
            btnSaveJPG.FlatAppearance.BorderSize = 0;
            btnSaveJPG.FlatStyle = FlatStyle.Flat;
            btnSaveJPG.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveJPG.ForeColor = Color.Black;
            btnSaveJPG.Location = new Point(535, 41);
            btnSaveJPG.Name = "btnSaveJPG";
            btnSaveJPG.Size = new Size(150, 40);
            btnSaveJPG.TabIndex = 2;
            btnSaveJPG.Text = "Save JPG";
            btnSaveJPG.TextColor = Color.Black;
            btnSaveJPG.UseVisualStyleBackColor = false;
            btnSaveJPG.Click += btnSaveJPG_Click;
            // 
            // btnSavePNG
            // 
            btnSavePNG.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnSavePNG.BackColor = Color.Transparent;
            btnSavePNG.BackgroundColor = Color.Transparent;
            btnSavePNG.BorderColor = Color.FromArgb(62, 136, 144);
            btnSavePNG.BorderRadius = 1;
            btnSavePNG.BorderSize = 2;
            btnSavePNG.FlatAppearance.BorderSize = 0;
            btnSavePNG.FlatStyle = FlatStyle.Flat;
            btnSavePNG.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSavePNG.ForeColor = Color.Black;
            btnSavePNG.Location = new Point(379, 41);
            btnSavePNG.Name = "btnSavePNG";
            btnSavePNG.Size = new Size(150, 40);
            btnSavePNG.TabIndex = 1;
            btnSavePNG.Text = "Save PNG";
            btnSavePNG.TextColor = Color.Black;
            btnSavePNG.UseVisualStyleBackColor = false;
            btnSavePNG.Click += btnSavePNG_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(167, 41);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 5;
            label3.Text = "Total:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.Location = new Point(208, 41);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(13, 15);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "0";
            // 
            // progressBar1
            // 
            progressBar1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progressBar1.BackColor = Color.White;
            progressBar1.Location = new Point(12, 12);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(673, 23);
            progressBar1.Step = 1;
            progressBar1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(9, 41);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 3;
            label1.Text = "Progress:";
            // 
            // gradientPanel2
            // 
            gradientPanel2.Angle = 0F;
            gradientPanel2.BottomColor = Color.FromArgb(93, 204, 216);
            gradientPanel2.Controls.Add(rtbImage);
            gradientPanel2.Dock = DockStyle.Fill;
            gradientPanel2.Location = new Point(0, 85);
            gradientPanel2.Name = "gradientPanel2";
            gradientPanel2.Padding = new Padding(10);
            gradientPanel2.Size = new Size(697, 357);
            gradientPanel2.TabIndex = 1;
            gradientPanel2.TopColor = Color.FromArgb(192, 255, 255);
            // 
            // rtbImage
            // 
            rtbImage.Dock = DockStyle.Fill;
            rtbImage.Location = new Point(10, 10);
            rtbImage.Name = "rtbImage";
            rtbImage.Size = new Size(677, 337);
            rtbImage.TabIndex = 0;
            rtbImage.Text = "";
            // 
            // FrmCompressImages
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 442);
            Controls.Add(gradientPanel2);
            Controls.Add(gradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCompressImages";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCompressImages";
            FormClosing += FrmCompressImages_FormClosing;
            Load += FrmCompressImages_Load;
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            gradientPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.GradientPanel gradientPanel1;
        private Label lblNotice;
        private Label lblProgress;
        private CustomControls.ButtonCustom btnSaveJPG;
        private CustomControls.ButtonCustom btnSavePNG;
        private Label label3;
        private Label lblTotal;
        private ProgressBar progressBar1;
        private Label label1;
        private CustomControls.GradientPanel gradientPanel2;
        private RichTextBox rtbImage;
    }
}