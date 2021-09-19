using System;
using System.Windows.Forms;

namespace Project1
{
    class ExtButton:Button
    {
        private const int MIN_DISABLED = 5;

        public string StrTextBox
        {
            set
            {
                this.Text = value;
                bool enabled = value != null && value.Length > MIN_DISABLED;
                this.Enabled = enabled;

            }
            get
            {
                return this.Text + "OK";
            }
        }


    }
}
