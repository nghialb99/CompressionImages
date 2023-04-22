using FontAwesome.Sharp;
using System.ComponentModel;

namespace CompressionImages.CustomControls
{
    internal class IconButtonCustom : IconButton
    {
        //Properties
        [Category("Custom")]
        private string? _OtherText;
        public string? OtherText
        {
            get { return _OtherText; }
            set
            {
                _OtherText = value;
                this.Invalidate();
            }
        }
        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
            if (!this.Enabled)
            {
                this.ForeColor = Color.White;
            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged!);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
