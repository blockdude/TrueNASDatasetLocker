namespace TrueNASLocker.UI
{
    public class FlowLayoutPanelEx : FlowLayoutPanel
    {
        private bool _centerVertical = false;
        private bool _centerHorizontal = false;

        public bool CenterVertical
        {
            get => _centerVertical;
            set => _centerVertical = value;
        }

        public bool CenterHorizontal
        {
            get => _centerHorizontal;
            set => _centerHorizontal = value;
        }

        public FlowLayoutPanelEx() : base()
        {
            this.Resize += OnResize;
        }

        private Size SizeOfControls()
        {
            int height = 0;
            int xMin = 0;
            int xMax = 0;

            foreach (Control control in this.Controls)
            {
                height += control.Height + control.Margin.Top + control.Margin.Bottom;

                int left = control.Location.X - control.Margin.Left;
                int right = control.Location.X + control.Width + control.Margin.Right;

                xMin = Math.Min(xMin, left);
                xMax = Math.Max(xMax, right);
            }

            return new Size(xMax - xMin, height);
        }

        private void OnResize(object? sender, EventArgs e)
        {
            if (!CenterVertical && !CenterHorizontal)
                return;

            Padding padding = Padding.Empty;
            Size controlSize = SizeOfControls();

            if (CenterVertical)
            {
                padding.Top = (this.Height - controlSize.Height) / 2;
            }

            if (CenterHorizontal)
            {
                padding.Left = (this.Width) / 2;
            }

            this.Padding = padding;
        }
    }
}
