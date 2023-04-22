using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompressionImages
{
    public partial class FrmCompressImages : Form
    {
        private DelegateVoids _checkIsProgressRunning;

        public FrmCompressImages(DelegateVoids checkIsProgressRunning)
        {
            InitializeComponent();
            _checkIsProgressRunning = checkIsProgressRunning;
        }
        private void FrmCompressImages_Load(object sender, EventArgs e)
        {
            lblNotice.Text = "";
            progressBar1.Step = 1;
        }

        private void btnSavePNG_Click(object sender, EventArgs e)
        {
            lblNotice.Text = "";
            rtbImage.Clear();
            progressBar1.Value = 0;
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = true;
            dlg.Filter = "Image Files( *.jpeg, *.jpg, *.jpe, *.jfif) | *.jpeg; *.jpg; *.jpe; *.jfif";
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                _checkIsProgressRunning(true);
                btnSaveJPG.Enabled = false;
                btnSavePNG.Enabled = false;
                List<String> list = dlg.FileNames.ToList<String>();
                lblTotal.Text = list.Count.ToString();
                progressBar1.Maximum = list.Count;

                //await SaveImagePNG(list);
                var threadParameters = new ThreadStart(delegate { SaveImagePNG(list); });
                var thread1 = new Thread(threadParameters);
                thread1.IsBackground = true;
                thread1.Start();
            }
            dlg.Dispose();
        }
        private void btnSaveJPG_Click(object sender, EventArgs e)
        {
            _checkIsProgressRunning(true);
            lblNotice.Text = "";
            rtbImage.Clear();
            progressBar1.Value = 0;
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = true;
            dlg.Filter = "Image Files( *.png, *.jpe, *.jfif) | *.png; *.jpe; *.jfif";
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                btnSavePNG.Enabled = false;
                btnSaveJPG.Enabled = false;
                List<String> list = dlg.FileNames.ToList<String>();
                lblTotal.Text = list.Count.ToString();
                progressBar1.Maximum = list.Count;

                var threadParameters = new ThreadStart(delegate { SavaImageJPG(list); });
                var thread2 = new Thread(threadParameters);
                thread2.IsBackground = true;
                thread2.Start();
            }

            dlg.Dispose();
        }
        private void SaveImagePNG(List<String> list)
        {
            int count = 0;
            string filePath = @"";
            try
            {
                for (int i = 0; i < list.Count; i++)
                {
                    count = i + 1;

                    using (FileStream str = File.OpenRead(list[i]))
                    {
                        string fullPath = Path.Combine(filePath, GetNameImg(list[i]) + ".png");
                        //img.FileImg.Save(fullPath, ImageFormat.Png);
                        //Image.FromFile(img.Name).Save(fullPath, ImageFormat.Png);
                        Image.FromStream(str).Save(fullPath, ImageFormat.Png);

                        GC.Collect();
                        //Process.Start("notepad.exe", filePath);
                    }
                    File.Delete(list[i]);

                    rtbImage.Invoke(new Action(() => { UpdateRtb(list[i]); }));

                    lblProgress.Invoke(new Action(() => { UpdateTb(count); }));

                    //lblRateProgress.Invoke(new Action(() => { UpdateLblRateProgress(count, totalFile); }));

                    progressBar1.Invoke(new Action(() => { ActiveProcessbar(); }));
                }
                if (count < list.Count) MessageBox.Show("The process was interrupted due to the number of images being too large. You can continue with the images incomplete.", "Notification");
                lblNotice.Invoke(new Action(() => { UpdateLb("Save PNG completed"); }));
                btnSaveJPG.Invoke(new Action(() => { btnSaveJPG.Enabled = true; }));
                btnSavePNG.Invoke(new Action(() => { btnSavePNG.Enabled = true; }));
                _checkIsProgressRunning(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification");
            }
        }
        private void SavaImageJPG(List<String> list)
        {
            int count = 0;
            string filePath = @"";
            try
            {
                for (int i = 0; i < list.Count; i++)
                {
                    count = i + 1;

                    using (FileStream str = File.OpenRead(list[i]))
                    {
                        string fullPath = Path.Combine(filePath, GetNameImg(list[i]) + ".jpg");
                        //img.FileImg.Save(fullPath, ImageFormat.Png);
                        //Image.FromFile(img.Name).Save(fullPath, ImageFormat.Png);
                        Image.FromStream(str).Save(fullPath, ImageFormat.Jpeg);

                        //GC.Collect();
                        //Process.Start("notepad.exe", filePath);
                    }
                    File.Delete(list[i]);

                    rtbImage.Invoke(new Action(() => { UpdateRtb(list[i]); }));

                    lblProgress.Invoke(new Action(() => { UpdateTb(count); }));

                    //lblRateProgress.Invoke(new Action(() => { UpdateLblRateProgress( count, list.Count); }));

                    progressBar1.Invoke(new Action(() => { ActiveProcessbar(); }));
                }
                if (count < list.Count) MessageBox.Show("The process was interrupted due to the number of images being too large. You can continue with the images incomplete.", "Notification");
                lblNotice.Invoke(new Action(() => { UpdateLb("Save JPG completed"); }));
                btnSavePNG.Invoke(new Action(() => { btnSavePNG.Enabled = true; }));
                btnSaveJPG.Invoke(new Action(() => { btnSaveJPG.Enabled = true; }));
                _checkIsProgressRunning(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification");
            }
        }
        private string GetNameImg(string name)
        {
            int i = name.LastIndexOf('.');
            return name.Substring(0, i);
        }
        private void ActiveProcessbar()
        {
            progressBar1.PerformStep();
        }
        private void UpdateRtb(string fileName)
        {
            fileName += "\n" + rtbImage.Text;
            rtbImage.Text = fileName;
        }
        private void UpdateTb(int fileCount)
        {
            lblProgress.Text = (fileCount++).ToString();
        }
        private void UpdateLb(string text)
        {
            lblNotice.Text = text;
        }

        private void FrmCompressImages_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!btnSaveJPG.Enabled || !btnSavePNG.Enabled)
            {
                _checkIsProgressRunning(true);
            }
        }
    }
}
