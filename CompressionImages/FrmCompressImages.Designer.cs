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
            this.gradientPanel1 = new CompressionImages.CustomControls.GradientPanel();
            this.lblNotice = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.btnSaveJPG = new CompressionImages.CustomControls.ButtonCustom();
            this.btnSavePNG = new CompressionImages.CustomControls.ButtonCustom();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.gradientPanel2 = new CompressionImages.CustomControls.GradientPanel();
            this.rtbImage = new System.Windows.Forms.RichTextBox();
            this.gradientPanel1.SuspendLayout();
            this.gradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 0F;
            this.gradientPanel1.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(204)))), ((int)(((byte)(216)))));
            this.gradientPanel1.Controls.Add(this.lblNotice);
            this.gradientPanel1.Controls.Add(this.lblProgress);
            this.gradientPanel1.Controls.Add(this.btnSaveJPG);
            this.gradientPanel1.Controls.Add(this.btnSavePNG);
            this.gradientPanel1.Controls.Add(this.label3);
            this.gradientPanel1.Controls.Add(this.lblTotal);
            this.gradientPanel1.Controls.Add(this.progressBar1);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(697, 85);
            this.gradientPanel1.TabIndex = 0;
            this.gradientPanel1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // lblNotice
            // 
            this.lblNotice.AutoSize = true;
            this.lblNotice.BackColor = System.Drawing.Color.Transparent;
            this.lblNotice.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNotice.ForeColor = System.Drawing.Color.Red;
            this.lblNotice.Location = new System.Drawing.Point(12, 66);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Size = new System.Drawing.Size(42, 15);
            this.lblNotice.TabIndex = 7;
            this.lblNotice.Text = "Notice";
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.BackColor = System.Drawing.Color.Transparent;
            this.lblProgress.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProgress.Location = new System.Drawing.Point(72, 41);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(13, 15);
            this.lblProgress.TabIndex = 6;
            this.lblProgress.Text = "0";
            // 
            // btnSaveJPG
            // 
            this.btnSaveJPG.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveJPG.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnSaveJPG.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(136)))), ((int)(((byte)(144)))));
            this.btnSaveJPG.BorderRadius = 1;
            this.btnSaveJPG.BorderSize = 2;
            this.btnSaveJPG.FlatAppearance.BorderSize = 0;
            this.btnSaveJPG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveJPG.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveJPG.ForeColor = System.Drawing.Color.Black;
            this.btnSaveJPG.Location = new System.Drawing.Point(535, 41);
            this.btnSaveJPG.Name = "btnSaveJPG";
            this.btnSaveJPG.Size = new System.Drawing.Size(150, 40);
            this.btnSaveJPG.TabIndex = 2;
            this.btnSaveJPG.Text = "Save JPG";
            this.btnSaveJPG.TextColor = System.Drawing.Color.Black;
            this.btnSaveJPG.UseVisualStyleBackColor = false;
            this.btnSaveJPG.Click += new System.EventHandler(this.btnSaveJPG_Click);
            // 
            // btnSavePNG
            // 
            this.btnSavePNG.BackColor = System.Drawing.Color.Transparent;
            this.btnSavePNG.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnSavePNG.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(136)))), ((int)(((byte)(144)))));
            this.btnSavePNG.BorderRadius = 1;
            this.btnSavePNG.BorderSize = 2;
            this.btnSavePNG.FlatAppearance.BorderSize = 0;
            this.btnSavePNG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePNG.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSavePNG.ForeColor = System.Drawing.Color.Black;
            this.btnSavePNG.Location = new System.Drawing.Point(379, 41);
            this.btnSavePNG.Name = "btnSavePNG";
            this.btnSavePNG.Size = new System.Drawing.Size(150, 40);
            this.btnSavePNG.TabIndex = 1;
            this.btnSavePNG.Text = "Save PNG";
            this.btnSavePNG.TextColor = System.Drawing.Color.Black;
            this.btnSavePNG.UseVisualStyleBackColor = false;
            this.btnSavePNG.Click += new System.EventHandler(this.btnSavePNG_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(167, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(208, 41);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(13, 15);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "0";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.White;
            this.progressBar1.Location = new System.Drawing.Point(12, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(673, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Progress:";
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.Angle = 0F;
            this.gradientPanel2.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(204)))), ((int)(((byte)(216)))));
            this.gradientPanel2.Controls.Add(this.rtbImage);
            this.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel2.Location = new System.Drawing.Point(0, 85);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.gradientPanel2.Size = new System.Drawing.Size(697, 357);
            this.gradientPanel2.TabIndex = 1;
            this.gradientPanel2.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // rtbImage
            // 
            this.rtbImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbImage.Location = new System.Drawing.Point(10, 10);
            this.rtbImage.Name = "rtbImage";
            this.rtbImage.Size = new System.Drawing.Size(677, 337);
            this.rtbImage.TabIndex = 0;
            this.rtbImage.Text = "";
            // 
            // FrmCompressImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 442);
            this.Controls.Add(this.gradientPanel2);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(697, 442);
            this.MinimumSize = new System.Drawing.Size(697, 442);
            this.Name = "FrmCompressImages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCompressImages";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCompressImages_FormClosing);
            this.Load += new System.EventHandler(this.FrmCompressImages_Load);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.gradientPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

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