using CompressionImages.CustomControls;
using FontAwesome.Sharp;

namespace CompressionImages
{
    public partial class FrmMain : Form
    {
        private static bool _isProgressRunning = false;
        private IconButtonCustom? _currentButton;
        private List<IconButtonCustom> _listCurrentButton = new List<IconButtonCustom>();
        private Panel _leftBorderBtn = new Panel();
        private Form? _currenFrm;
        private FrmDashboard _FrmDashboard = new FrmDashboard();
        private FrmCompressImages _FrmCompressImages = new FrmCompressImages(CheckIsProgressRunning);
        private FrmGetCaptcha _FrmGetCaptcha = new FrmGetCaptcha();
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            RenderSideBar();
            ChangeSideBar(true);
            //_currenFrm = new FrmCompressImages(CheckIsProgressRunning);
            //ShowCurrentForm();
        }
        private void ShowCurrentForm()
        {
            if (_currenFrm != null)
            {
                _currenFrm.Size = panelSidebar.Size;
                _currenFrm.Dock = DockStyle.Fill;
                _currenFrm.FormBorderStyle = FormBorderStyle.None;
                this.pnLoad.Controls.Clear();
                _currenFrm.TopLevel = false;
                this.pnLoad.Controls.Add(_currenFrm);
                _currenFrm.Show();
            }
        }

        private static void CheckIsProgressRunning(bool isProgressRunning)
        {
            _isProgressRunning = isProgressRunning;
        }
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isProgressRunning)
            {
                DialogResult dlr = MessageBox.Show("Progress is running." + "\n Turning off apps in the middle can damage your files." + "\n Are you sure?", "Warning",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dlr == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        #region Create btn
        private void RenderSideBar()
        {
            panelSidebar.Controls.Clear();

            _leftBorderBtn.Size = new Size(7, panelSidebar.Height / 9);
            _leftBorderBtn.Padding = new Padding(0, 0, 0, 0);
            _leftBorderBtn.Visible = false;
            panelSidebar.Controls.Add(_leftBorderBtn);

            var btnGetCaptcha = new IconButtonCustom();
            RenderInitialBtn(btnGetCaptcha);
            btnGetCaptcha.IconChar = IconChar.Message;
            btnGetCaptcha.Name = "btnGetCaptcha";
            btnGetCaptcha.Text = "Get captcha";
            btnGetCaptcha.OtherText = "Get captcha";
            btnGetCaptcha.Click += BtnSidebar_Click;
            panelSidebar.Controls.Add(btnGetCaptcha);
            _listCurrentButton.Add(btnGetCaptcha);

            var btnCompressImages = new IconButtonCustom();
            RenderInitialBtn(btnCompressImages);
            btnCompressImages.IconChar = IconChar.Images;
            btnCompressImages.Name = "btnCompressImages";
            btnCompressImages.Text = "Compress images";
            btnCompressImages.OtherText = "Compress images";
            btnCompressImages.Click += BtnSidebar_Click;
            panelSidebar.Controls.Add(btnCompressImages);
            _listCurrentButton.Add(btnCompressImages);

            var btnDashboard = new IconButtonCustom();
            RenderInitialBtn(btnDashboard);
            btnDashboard.IconChar = IconChar.Dashboard;
            btnDashboard.Name = "btnDashBoard";
            btnDashboard.Text = "Dashboard";
            btnDashboard.OtherText = "Dashboard";
            btnDashboard.Click += BtnSidebar_Click;
            panelSidebar.Controls.Add(btnDashboard);
            _listCurrentButton.Add(btnDashboard);

            panelSidebar.Controls.Add(LogoImg);

            RenderInitialBtn(btnCurrent);
            btnCurrent.Dock = DockStyle.Left;
            btnCurrent.Text = "";
            btnCurrent.Enabled = false;
        }

        private void BtnSidebar_Click(object? sender, EventArgs e)
        {
            if (sender != null)
            {
                if (_currenFrm != null)
                {
                    _currenFrm.Hide();
                }
                var btn = (IconButton)sender;
                AcctiveBtn(btn);
                switch (btn.Name)
                {
                    case "btnDashBoard":
                        {
                            _currenFrm = _FrmDashboard;
                            break;
                        }
                    case "btnCompressImages":
                        {
                            _currenFrm = _FrmCompressImages;
                            break;
                        }
                    case "btnGetCaptcha":
                        {
                            _currenFrm = _FrmGetCaptcha;
                            break;
                        }
                }
                ShowCurrentForm();
                btnCurrent.Text = btn.Text;
                btnCurrent.IconChar = btn.IconChar;
            }

        }
        private void AcctiveBtn(object? button)
        {
            if (button != null)
            {
                DisableBtn();
                _currentButton = (IconButtonCustom)button;
                _currentButton.ImageAlign = ContentAlignment.MiddleRight;
                _currentButton.TextAlign = ContentAlignment.MiddleCenter;
                _currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                //_currentButton.BackColor = Color.FromArgb(37, 36, 81);
                _currentButton.ForeColor = Color.Orange;
                _currentButton.IconColor = Color.Orange;
                _currentButton.FlatAppearance.BorderSize = 1;

                _leftBorderBtn.BackColor = Color.Orange;
                _leftBorderBtn.Location = new Point(0, _currentButton.Location.Y);
                _leftBorderBtn.Visible = true;
                _leftBorderBtn.BringToFront();
            }
        }
        private void DisableBtn()
        {
            if (_currentButton != null)
            {
                _currentButton.ImageAlign = ContentAlignment.MiddleLeft;
                _currentButton.TextAlign = ContentAlignment.MiddleLeft;
                _currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                //_currentButton.BackColor = Color.FromArgb(37, 36, 81);
                _currentButton.ForeColor = Color.White;
                _currentButton.IconColor = Color.White;
                _currentButton.FlatAppearance.BorderSize = 0;
            }
        }
        private void RenderInitialBtn(object button)
        {
            var btn = (IconButton)button;
            btn.Padding = new Padding(10, 0, 2, 0);
            btn.Dock = DockStyle.Top;
            btn.ImageAlign = ContentAlignment.MiddleLeft;
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Height = panelSidebar.Height / 9;
            //btn.IconChar = IconChar.List;
            btn.IconSize = (int)(btn.Height * 0.5);
            btn.IconColor = Color.White;
            btn.ForeColor = Color.White;
            btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn.BackColor = Color.Black;//Color.FromArgb(37, 36, 81);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;

        }
        #endregion

        private void LogoImg_Click(object sender, EventArgs e)
        {
            ChangeSideBar();
        }
        private void ChangeSideBar(bool isInitial = false)
        {
            var collumn0 = tableLayoutMain.ColumnStyles[0];
            collumn0.SizeType = SizeType.Absolute;
            if (isInitial)
            {
                collumn0.Width = (int)(tableLayoutMain.Width * 0.2);
            }
            else
            {
                if (collumn0.Width == (int)(tableLayoutMain.Width * 0.2))
                {
                    collumn0.Width = (int)(tableLayoutMain.Width * 0.05);
                    foreach (var btn in _listCurrentButton)
                    {
                        btn.Text = "";
                    }
                }
                else
                {
                    collumn0.Width = (int)(tableLayoutMain.Width * 0.2);
                    foreach (var btn in _listCurrentButton)
                    {
                        btn.Text = btn.OtherText;
                    }
                }
            }
        }
    }
}