namespace TrueNASLocker.UI
{
    public class WidthGauge : Control
    {
        public WidthGauge() : base()
        {
            this.ParentChanged += OnParentChange;
        }

        private void OnParentChange(object? sender, EventArgs e)
        {
            if (this.Parent == null)
            {
                return;
            }

            this.Parent.Resize += OnParentResize;
        }

        private void OnParentResize(object? sender, EventArgs e)
        {
            if (this.Parent == null)
            {
                return;
            }

            this.Width = Parent.Width - this.Margin.Left - this.Margin.Right;
        }
    }
}
