namespace CompressionImages
{
    public partial class FrmMain : Form
    {
        private bool _isProgressRunning = false;
        private Button currentButton;
        public FrmMain()
        {
            InitializeComponent();
        }
        
        private void FrmMain_Load(object sender, EventArgs e)
        {
            AddForm(new FrmCompressImages(CheckIsProgressRunning));
            SetDateMenuButonsUI(btnCompressImages);
        }

        private void SetDateMenuButonsUI(object button)
        {
            var btn = (Button)button;
            btn.BackColor = Color.FromArgb(93, 204, 216);
            btn.ForeColor = Color.White;
            if (currentButton != null && currentButton != btn)
            {
                currentButton.BackColor = Color.Transparent;
                currentButton.ForeColor = Color.Black;
            }
            currentButton = btn; // set current button

        }
        private void btnCompressImages_Click(object sender, EventArgs e)
        {
            if (_isProgressRunning)
            {
                MessageBox.Show("Progress is running.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SetDateMenuButonsUI(sender);
                AddForm(new FrmCompressImages(CheckIsProgressRunning));
            }
        }

        private void brnGetCaptcha_Click(object sender, EventArgs e)
        {
            if (_isProgressRunning)
            {
                MessageBox.Show("Progress is running.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SetDateMenuButonsUI(sender);
                AddForm(new FrmGetCaptcha());
            }
        }
        private void AddForm(Form f)
        {
            this.pnLoad.Controls.Clear();
            f.TopLevel = false;
            this.pnLoad.Controls.Add(f);
            f.Show();
        }

        private void CheckIsProgressRunning(bool isProgressRunning)
        {
            _isProgressRunning = isProgressRunning;
        }
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(_isProgressRunning)
            {
                DialogResult dlr = MessageBox.Show("Progress is running." + "\n Turning off apps in the middle can damage your files." + "\n Are you sure?", "Warning",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dlr == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}