using System;
using System.Windows.Forms;

namespace Project1
{
    class ModalDialogBox: Form
    {
        CheckBox cbGrayShades;
        const int LEFT = 16;

        public ModalDialogBox()
        {
            this.Text = "Color of the Form";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            this.ShowInTaskbar = false;

            this.StartPosition = FormStartPosition.CenterParent;
            this.ClientSize = new System.Drawing.Size(144, 56);

            cbGrayShades = new CheckBox();
            cbGrayShades.Parent = this;
            cbGrayShades.Text = "Only Gray Shades";
            int left;
            int top;
            left = LEFT;
            top = 8;
            cbGrayShades.Location = new System.Drawing.Point(left, top);


            cbGrayShades.Size =
                new System.Drawing.Size(this.ClientSize.Width - left - 4, 12);

            Button btn = new Button();
            btn.Parent = this;
            btn.Text = "OK";
            btn.Location = new System.Drawing.Point(16, 32);
            System.Drawing.Size size = new System.Drawing.Size(48, 14);
            btn.Size = size;
            btn.DialogResult = DialogResult.OK;
            this.AcceptButton = btn;

            btn = new Button();
            btn.Parent = this;
            btn.Text = "Cancel";
            btn.Location = new System.Drawing.Point(80, 32);
            btn.Size = size;
            btn.DialogResult = DialogResult.Cancel;
            this.CancelButton = btn;

            this.AutoScaleDimensions = new System.Drawing.Size(4, 8);
            this.AutoScaleMode = AutoScaleMode.Font;
        }

        public bool GrayShades
        {
            get
            {
                return cbGrayShades.Checked;
            }
            set
            {
                cbGrayShades.Checked = value;
            }
        }
    }
}
