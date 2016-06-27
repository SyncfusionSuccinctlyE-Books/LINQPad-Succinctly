using System.Drawing;
using System.Windows.Forms;

namespace LINQPad.customcontrols
{
    public class CustomButton : Button
    {
        public CustomButton()
        {
            FlatStyle = FlatStyle.Flat;
            BackColor = Color.FromArgb(244, 152, 31);
            ForeColor = Color.Black;
            Font = new Font("Segoe UI", 12);
            Text = "Custom Button Class";
        }

        public sealed override Color BackColor
        {
            get { return base.BackColor; }
            set { base.BackColor = value; }
        }

        public sealed override Color ForeColor
        {
            get { return base.ForeColor; }
            set { base.ForeColor = value; }

        }

        public sealed override Font Font
        {
            get { return base.Font; }
            set { base.Font = value; }

        }

        public sealed override string Text 
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

    }
}
