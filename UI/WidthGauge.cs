using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrueNASLocker.UI
{
    public class WidthGauge : Control
    {
        public WidthGauge()
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

            this.Width = Parent.Width - Parent.Margin.Left - Parent.Margin.Right;
        }
    }
}
